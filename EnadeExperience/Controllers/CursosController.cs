using EnadeExperience.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EnadeExperience.Controllers
{
    public class CursosController : Controller
    {
        private CursoViewModel _cursoViewModel;

        public IActionResult Cursos()
        {
            _cursoViewModel = new CursoViewModel();
            ViewBag.ListaCurso = _cursoViewModel.ListarCursos();

            return View();
        }

        [HttpPost]
        public IActionResult IncluirCurso(CursoViewModel formulario)
        {
            formulario.Inserir();

            _cursoViewModel = new CursoViewModel();
            ViewBag.ListaCurso = _cursoViewModel.ListarCursos();

            ViewBag.PopUpCurso = formulario.PopUp;

            return View("Cursos");
        }

        [HttpGet]
        public IActionResult IncluirCurso(int? id)
        {
            if(id != null)
            {
                _cursoViewModel = new CursoViewModel();
                ViewBag.ListaCursos = _cursoViewModel.CarregarCurso(id);
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditarCurso(int id)
        {
            _cursoViewModel = new CursoViewModel();
            _cursoViewModel.Editar(id);

            return RedirectToAction("Cursos");
        }

        [HttpGet]
        public IActionResult ExcluirCurso(int id)
        {
            _cursoViewModel = new CursoViewModel();
            _cursoViewModel.Excluir(id);

            return RedirectToAction("Cursos");
        }

   
    }
}
