﻿using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    // essa camada isola os casos de uso
    // diminuir risco de negócio;
    // casos de uso para usuários 
    public interface IAdminService
    {
        IEnumerable<Categoria> ConsultaCategorias();
        IEnumerable<Leilao> ConsultaLeiloes();
        Leilao ConsultaLeilaoPorId(int id);
        void CadastraLeilao(Leilao leilao);
        void ModificaLeilao(Leilao leilao);
        void RemoveLeilao(Leilao leilao);
        void IniciaPregaoDoLeilaoComId(int id);
        void FinalizaPregaoDoLeilaoComId(int id);
        void ArquivaLeilao(int id);
    }
}
