using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO;
using DTO;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ContatoController : Controller
    {
        private ContatoDAO _contatoDAO;

        public ContatoController()
        {
            _contatoDAO = new ContatoDAO();

        }

        public IActionResult Details(int id)
        {
            var contatoDAO = new ContatoDAO();
            var contatoDTO = contatoDAO.Consultar(id);

            var contato = new ContatoViewModel()
            {

                Id = contatoDTO.Id,
                Nome = contatoDTO.Nome,
                SobreNome = contatoDTO.SobreNome,
                Celular = contatoDTO.Celular,
                Email = contatoDTO.Email
            };

            return View(contato);
        }
        public IActionResult Index()
        {

            var dao = new ContatoDAO();
            var listaContatoDTO = _contatoDAO.Consultar();
            var listaContato = new List<ContatoViewModel>();
            foreach (var dto in listaContatoDTO)
            {

                listaContato.Add(new ContatoViewModel()
                {

                    Id = dto.Id,
                    Nome = dto.Nome,
                    SobreNome = dto.SobreNome,
                    Celular = dto.Celular,
                    Email = dto.Email,
                });
            }
            return View(listaContato);


        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ContatoViewModel contato)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            var contatoDTO = new ContatoDTO
            {
                Nome = contato.Nome,
                SobreNome = contato.SobreNome,
                Celular = contato.Celular,
                Email = contato.Email,
            };

            var contatoDAO = new ContatoDAO();
            contatoDAO.CriarContato(contatoDTO);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(ContatoViewModel contato)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var contatoDTO = new ContatoDTO
            {
                Id = contato.Id,
                Nome = contato.Nome,
                SobreNome = contato.SobreNome,
                Celular = contato.Celular,
                Email = contato.Email,
            };
            var contatoDAO = new ContatoDAO();
            contatoDAO.AtualizarContato(contatoDTO);
            return RedirectToAction("Index");

        }

        public IActionResult Update(int id)
        {
            var contatoDAO = new ContatoDAO();
            var contatoDTO = contatoDAO.Consultar(id);

            var contato = new ContatoViewModel()
            {

                Id = contatoDTO.Id,
                Nome = contatoDTO.Nome,
                SobreNome = contatoDTO.SobreNome,
                Celular = contatoDTO.Celular,
                Email = contatoDTO.Email
            };

            return View(contato);
        }
        public IActionResult Deletar(int id)
        {
            _contatoDAO.Excluir(id);

            return RedirectToAction("Index");
        }
    }
}