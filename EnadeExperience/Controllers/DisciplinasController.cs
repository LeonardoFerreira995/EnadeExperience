using EnadeExperience.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnadeExperience.Controllers
{
    public class DisciplinasController : Controller
    {
        private DisciplinasViewModel _disciplinasViewModel;
        public IActionResult Disciplinas(DisciplinasViewModel formulario)
        {
            _disciplinasViewModel = new DisciplinasViewModel();
            ViewBag.ListaDisciplinas = _disciplinasViewModel.ListarDisciplinas();

            return View();
        }

        [HttpPost]
        public IActionResult IncluirDisciplina(DisciplinasViewModel formulario)
        {
            formulario.Inserir();

            _disciplinasViewModel = new DisciplinasViewModel();
            ViewBag.ListaDisciplinas = _disciplinasViewModel.ListarDisciplinas();

            ViewBag.PopUpDisciplina = formulario.PopUp;

            return View("Disciplinas");
        }

        [HttpGet]
        public IActionResult IncluirDisciplina(int? id)
        {
            if (id != null)
            {
                _disciplinasViewModel = new DisciplinasViewModel();
                ViewBag.ListaDisciplina = _disciplinasViewModel.CarregarDisciplina(id);
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditarDisciplina(int id)
        {
            _disciplinasViewModel = new DisciplinasViewModel();
            _disciplinasViewModel.Editar(id);

            return RedirectToAction("Disciplinas");
        }

        public IActionResult ExcluirDisciplina(int id)
        {
            _disciplinasViewModel = new DisciplinasViewModel();
            _disciplinasViewModel.Excluir(id);

            return RedirectToAction("Disciplinas");
        }
    }
}
