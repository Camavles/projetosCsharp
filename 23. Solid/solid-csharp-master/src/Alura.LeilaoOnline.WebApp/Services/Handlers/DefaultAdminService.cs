using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultAdminService : IAdminService
    {
        readonly ILeilaoDao _dao;

        public DefaultAdminService(ILeilaoDao dao)
        {
            _dao = dao;
        }

        public void CadastraLeilao(Leilao leilao)
        {
            _dao.Include(leilao); // ok
        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
           return _dao.ListCategories(); //ok
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            return _dao.GetLeilaoById(id); // ok
        }

        public IEnumerable<Leilao> ConsultaLeiloes()
        {
            return _dao.ListLeilao(); // ok
        }

        public void FinalizaPregaoDoLeilaoComId(int id)
        {
            var leilao = _dao.GetLeilaoById(id);
            if(leilao != null && leilao.Situacao == SituacaoLeilao.Pregao)
            {
                leilao.Situacao = SituacaoLeilao.Finalizado;
                leilao.Termino = DateTime.Now;
                _dao.Update(leilao); // ok
            }
        }

        public void IniciaPregaoDoLeilaoComId(int id)
        {
            var leilao = _dao.GetLeilaoById(id);
            if(leilao != null && leilao.Situacao == SituacaoLeilao.Rascunho)
            {
                leilao.Situacao = SituacaoLeilao.Pregao;
                leilao.Inicio = DateTime.Now;
                _dao.Update(leilao); //ok
            }
        }

        public void ModificaLeilao(Leilao leilao)
        {
            _dao.Update(leilao); // ok
        }

        public void RemoveLeilao(Leilao leilao)
        {
            if(leilao != null && leilao.Situacao == SituacaoLeilao.Finalizado)
            {
                //leilao.Situacao = SituacaoLeilao.Arquivado;
                //_dao.Update(leilao);

                _dao.Exclude(leilao);
            }
            
        }

        public void ArquivaLeilao(int id)
        {
            var leilao = _dao.GetLeilaoById(id);

            if(leilao != null && leilao.Situacao != SituacaoLeilao.Pregao && leilao.Situacao != SituacaoLeilao.Arquivado)
            {
                leilao.Situacao = SituacaoLeilao.Arquivado;
                _dao.Update(leilao);
            }
        }
    }
}
