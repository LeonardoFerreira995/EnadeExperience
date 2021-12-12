using EnadeExperience.Models;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnadeExperience.Controllers
{
    public class RelatoriosController : Controller
    {
        private CursoViewModel _cursosViewModel;
        private DisciplinasViewModel _disciplinasViewModel;
        private QuestoesViewModel _questoesViewModel;

        public IActionResult FiltroQuestoes()
        {
            // Carrega as questões filtradas
            _questoesViewModel = new QuestoesViewModel();
            ViewBag.QuestoesFiltradas = _questoesViewModel.FiltrarQuestoes();

            // Dropdownlist da página
            _disciplinasViewModel = new DisciplinasViewModel();
            ViewBag.Disciplinas = _disciplinasViewModel.ListarDisciplinas();

            _cursosViewModel = new CursoViewModel();
            ViewBag.Cursos = _cursosViewModel.ListarCursos();

            return View();
        }

        [HttpPost]
        public IActionResult FiltrarQuestao(QuestoesViewModel formulario)
        {
            ViewBag.Resultado = 1;

            ViewBag.QuestoesFiltradas = formulario.FiltrarQuestoes();

            _disciplinasViewModel = new DisciplinasViewModel();
            ViewBag.Disciplinas = _disciplinasViewModel.ListarDisciplinas();

            _cursosViewModel = new CursoViewModel();
            ViewBag.Cursos = _cursosViewModel.ListarCursos();

            return View("FiltroQuestoes");
        }

        public IActionResult VisualizarPDF(QuestoesViewModel formulario)
        {
            return new ViewAsPdf("PDF", formulario.FiltrarQuestoes()) { FileName = "Enade Experience - Relatório PDF.pdf" };
        }

        public IActionResult VisualizarExcel(QuestoesViewModel formulario)
        {
            var questoes = formulario.FiltrarQuestoes();

            StringBuilder arquivo = new StringBuilder();

            arquivo.AppendLine("Questao;Resposta;Curso;Disciplinas;Dificuldade;Ano");

            foreach (var item in questoes)
            {
                arquivo.AppendLine(item.Questao + ";" + item.Resposta + ";" + item.Curso + ";" + item.Disciplina + " " + item.Disciplina2 + " " + item.Disciplina3 + " " + item.Disciplina4 + " " + item.Disciplina5 + ";" + item.Dificuldade + ";" + item.Ano);
            }

            var RecebeString = "";

            string regex = @"(<.+?>|&nbsp;)";

            RecebeString = Regex.Replace(arquivo.ToString(), regex, "").Trim();

            return File(Encoding.Latin1.GetBytes(RecebeString.ToString()), "text/csv", "Enade Experience - Relatório Excel.csv");

        }
        public IActionResult VisualizarProva(QuestoesViewModel formulario)
        {
            return new ViewAsPdf("Prova", formulario.FiltrarQuestoes()) { FileName = "Enade Experience - Prova PDF.pdf" };
        }
    }
}
