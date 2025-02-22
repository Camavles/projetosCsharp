﻿using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultProdutoService : IProdutoService
    {
        readonly ILeilaoDao _dao;
        readonly ICategoriaDao _categoriaDao;

        public DefaultProdutoService(ILeilaoDao dao, ICategoriaDao categoriaDao)
        {
            _dao = dao;
            _categoriaDao = categoriaDao;
        }
        public Categoria ConsultaCategoriaPorIdComLeiloesEmPregao(int id)
        {
            return _categoriaDao.ConsultaCategoriaPorId(id);
        }

        public IEnumerable<CategoriaComInfoLeilao> ConsultaCategoriasComTotalDeLeiloesEmPregao()
        {
            return _categoriaDao.ConsultaCategorias()
                .Select(c => new CategoriaComInfoLeilao
                {
                    Id = c.Id,
                    Descricao = c.Imagem,
                    EmRascunho = c.Leiloes.Where(l => l.Situacao == SituacaoLeilao.Rascunho).Count(),
                    EmPregao = c.Leiloes.Where(l => l.Situacao == SituacaoLeilao.Pregao).Count(),
                    Finalizados = c.Leiloes.Where(l => l.Situacao == SituacaoLeilao.Finalizado).Count()
                });

           
        }

        public IEnumerable<Leilao> PesquisaLeiloesEmPregaoPorTermo(string termo)
        {
            var termoNormalized = termo.ToUpper();
            return _dao.ListLeilao()
                .Where(c => c.Titulo.ToUpper().Contains(termoNormalized) || c.Descricao.ToUpper().Contains(termoNormalized) || c.Categoria.Descricao.ToUpper().Contains(termoNormalized));
        }
    }
}
