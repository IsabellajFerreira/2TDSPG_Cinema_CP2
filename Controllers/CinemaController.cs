using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using _2TDSPG_Cinema.Models;

namespace _2TDSPG_Cinema.Controllers
{
    public class CinemaController : Controller
    {
        private List<Sessao> sessoes;

        public CinemaController()
        {
            sessoes = new List<Sessao>();
        }

        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml", sessoes);
        }


        [HttpPost]
        public IActionResult AdicionarSessao(string titulo, string diretor, int duracao, DateTime horario, int capacidade, int ingressosDisponiveis)
        {
            Filme filme = new Filme(titulo, diretor, duracao);
            Sessao sessao = new Sessao(filme, horario, capacidade, ingressosDisponiveis);
            sessoes.Add(sessao);
            TempData["Mensagem"] = "Sessão adicionada com sucesso!";
            return RedirectToAction("Index");
        }

    }
}
