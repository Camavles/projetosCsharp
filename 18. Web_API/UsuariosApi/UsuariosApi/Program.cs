using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UsuariosApi.Authorization;
using UsuariosApi.Data;
using UsuariosApi.Models;
using UsuariosApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// usando o UsuarioDbContext
builder.Services.AddDbContext<UsuarioDbContext>(opts =>
{
    opts.UseMySql(builder.Configuration.GetConnectionString("UsuarioConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("UsuarioConnection")));
});

// quero adicionar o conceito de Identidade para esse usuário e o papel desse usuario dentro do sistema será gerenciado por vc (IdentityRole)
// quem vai armazenar as infos do meu usuario é meu UsuarioDbContext
builder.Services
    .AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<UsuarioDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("IdadeMinina", 
        policy => policy.AddRequirements(new IdadeMinima(18))
        );
});


// forma de injeção de dependencia 
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<TokenService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
