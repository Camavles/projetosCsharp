using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using UsuariosApi.Authorization;
using UsuariosApi.Data;
using UsuariosApi.Models;
using UsuariosApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration["ConnectionStrings:UsuarioConnection"];

// usando o UsuarioDbContext
builder.Services.AddDbContext<UsuarioDbContext>(opts =>
{
    opts.UseMySql(connectionString,
        ServerVersion.AutoDetect(connectionString));
});

// quero adicionar o conceito de Identidade para esse usu�rio e o papel desse usuario dentro do sistema ser� gerenciado por vc (IdentityRole)
// quem vai armazenar as infos do meu usuario � meu UsuarioDbContext
builder.Services
    .AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<UsuarioDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddSingleton<IAuthorizationHandler, IdadeAuthorization>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        // valida a nossa chave
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["SymmetricSecurityKey"])),
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew = TimeSpan.Zero
    
    };
});


builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("IdadeMinima", 
        policy => policy.AddRequirements(new IdadeMinima(18))
        );
});


// forma de inje��o de dependencia 
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
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
