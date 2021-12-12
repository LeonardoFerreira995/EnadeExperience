using EnadeExperience.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text;

namespace EnadeExperience.Controllers
{
    public class QuestoesController : Controller
    {
        private DisciplinasViewModel _disciplinasViewModel;
        private CursoViewModel _cursosViewModel;
        private QuestoesViewModel _questoesViewModel;
        private IWebHostEnvironment hostingEnvironment;
        public QuestoesController(IWebHostEnvironment environment)
        {
            hostingEnvironment = environment;
        }

        public IActionResult Questoes()
        {
            _questoesViewModel = new QuestoesViewModel();
            ViewBag.ListarQuestoes = _questoesViewModel.ListarQuestoes();

            return View();
        }

        [HttpPost]
        public IActionResult IncluirQuestao(QuestoesViewModel formulario, IFormFile Image)
        {
            
            var linkUpload = Path.Combine(hostingEnvironment.WebRootPath, "imgQuestoes");

            if (Image != null)
            {
                using (var fileStream = new FileStream(Path.Combine(linkUpload, formulario.ID + Image.FileName), FileMode.Create))
                {
                    Image.CopyTo(fileStream);
                    formulario.Imagem = "~/imgQuestoes/" + formulario.ID + Image.FileName;
                }
            }

            var FormataQuestao = (formulario.Questao.ToString());

            FormataQuestao = formulario.Questao;

            formulario.Inserir();

            

            _questoesViewModel = new QuestoesViewModel();
            ViewBag.ListarQuestoes = _questoesViewModel.ListarQuestoes();

            ViewBag.PopUpQuestao = formulario.PopUp;

            return View("Questoes");
        }

        [HttpGet]
        public IActionResult IncluirQuestao(int? id)
        {
            if (id != null)
            {
                 _questoesViewModel = new QuestoesViewModel();
                ViewBag.ListaQuestao = _questoesViewModel.CarregarQuestao(id);
                ViewBag.NomeCurso = _questoesViewModel.CarregarNomeCurso(id);
                ViewBag.NomeDisciplina = _questoesViewModel.CarregarNomeDisciplina(id);
            }

            // Dropdownlist
            _disciplinasViewModel = new DisciplinasViewModel();
            ViewBag.Disciplinas = _disciplinasViewModel.ListarDisciplinas();

            _cursosViewModel = new CursoViewModel();
            ViewBag.Cursos = _cursosViewModel.ListarCursos();

            return View();
        }

        public IActionResult DetalhesQuestao(int id)
        {
            _questoesViewModel = new QuestoesViewModel();
            ViewBag.DetalhesQuestao = _questoesViewModel.DetalhesQuestao(id);

            return View();
        }

        [HttpGet]
        public IActionResult EditarQuestao(int id)
        {
            _questoesViewModel = new QuestoesViewModel();
            _questoesViewModel.Editar(id);

            return RedirectToAction("Questoes");
        }

        [HttpGet]
        public IActionResult ExcluirQuestao(int id)
        {
            _questoesViewModel = new QuestoesViewModel();
            _questoesViewModel.Excluir(id);

            return RedirectToAction("Questoes");
        }

        [HttpGet]
        public IActionResult ExcluirQuestaoRelatorio(int id)
        {
            _questoesViewModel = new QuestoesViewModel();
            _questoesViewModel.Excluir(id);

            return RedirectToAction("FiltroQuestoes", "Relatorios");
        }

        public IActionResult ExcluirImagem(int id)
        {
            _questoesViewModel = new QuestoesViewModel();
            _questoesViewModel.ExcluirImagem(id);

            ViewBag.ListaQuestao = _questoesViewModel.CarregarQuestao(id);
            ViewBag.NomeCurso = _questoesViewModel.CarregarNomeCurso(id);
            ViewBag.NomeDisciplina = _questoesViewModel.CarregarNomeDisciplina(id);

            // Dropdownlist
            _disciplinasViewModel = new DisciplinasViewModel();
            ViewBag.Disciplinas = _disciplinasViewModel.ListarDisciplinas();

            _cursosViewModel = new CursoViewModel();
            ViewBag.Cursos = _cursosViewModel.ListarCursos();

            return View("IncluirQuestao");
        }
    }
}
