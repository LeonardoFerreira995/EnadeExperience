using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnadeExperience.Controllers
{
    public class RemocoesController : Controller
    {
        public IActionResult RemoverCurso()
        {
            return View();
        }
        public IActionResult RemoverDisciplina()
        {
            return View();
        }

        public IActionResult RemoverQuestao()
        {
            return View();
        }
    }
}