using EnadeExperience.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnadeExperience.Controllers
{
    public class DashEnadeController : Controller
    {
        private DashEnadeViewModel _dashEnadeViewModel;

        public IActionResult AjusteTelaPrincipal()
        {
            _dashEnadeViewModel = new DashEnadeViewModel();
            ViewBag.ListaDash = _dashEnadeViewModel.ListaDash();

            return View();
        }

        [HttpPost]
        public IActionResult IncluirResultado(DashEnadeViewModel formulario)
        {
            formulario.Inserir();

            _dashEnadeViewModel = new DashEnadeViewModel();
            ViewBag.ListaDash = _dashEnadeViewModel.ListaDash();

            ViewBag.PopUpDash = formulario.PopUp;

            return View("AjusteTelaPrincipal");
        }

        [HttpGet]
        public IActionResult IncluirResultado(int? id)
        {
            if (id != null)
            {
                _dashEnadeViewModel = new DashEnadeViewModel();
                ViewBag.ListaDash = _dashEnadeViewModel.CarregarResultado(id);
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditarResultado(int id)
        {
            _dashEnadeViewModel = new DashEnadeViewModel();
            _dashEnadeViewModel.Editar(id);

            return RedirectToAction("AjusteTelaPrincipal");
        }
        public IActionResult ExcluirResultado(int id)
        {
            _dashEnadeViewModel = new DashEnadeViewModel();
            _dashEnadeViewModel.Excluir(id);

            return RedirectToAction("AjusteTelaPrincipal");
        }
    }
}
