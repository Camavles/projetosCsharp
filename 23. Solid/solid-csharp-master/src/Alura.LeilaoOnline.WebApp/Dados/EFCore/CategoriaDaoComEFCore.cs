﻿using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Dados.EFCore
{
    public class CategoriaDaoComEFCore: ICategoriaDao
    {
        AppDbContext _context;

        public CategoriaDaoComEFCore(AppDbContext context)
        {
            _context = context;
        }

        public Categoria ConsultaCategoriaPorId(int id)
        {
            return _context.Categorias
                .Include(c => c.Leiloes)
                .First(c => c.Id == id);
        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
            return _context.Categorias
                .Include(c => c.Leiloes);
        }
    }
}

