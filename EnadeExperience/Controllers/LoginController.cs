using EnadeExperience.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace EnadeExperience.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult CadastroUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(LoginViewModel usuario)
        {
            bool login = usuario.Logar();
            if (login)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.UserName);
                HttpContext.Session.SetString("IDUsuarioLogado", usuario.ID.ToString());

                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["MensagemLoginInvalido"] = "Dados de Login Inválidos";

                return RedirectToAction("Index", "Login");
            }

        }

        [HttpPost]
        public IActionResult Cadastrar(LoginViewModel usuario)
        {
            if(usuario.Password != usuario.PasswordConfirm)
            {
                TempData["MensagemConfirmacaoInvalida"] = "As Senhas não conferem";

                return RedirectToAction("CadastroUsuario", "Login");
            }
            if (ModelState.IsValid)
            {
                usuario.CadastrarUsuario();

                ViewBag.PopUpUsuario = usuario.PopUp;

                return View("Index");
            }

            return RedirectToAction("CadastroUsuario", "Login");
        }
        //    Conexao conexao = new Conexao();
        //    SqlCommand cmd = new SqlCommand();

        //    cmd.CommandText = "";
        //    cmd.Connection = conexao.Open();

        //    cmd.CommandText = $"SELECT " +
        //                      $"Usuario, " +
        //                      $"Senha " +
        //                      $"FROM usuarios " +
        //                      $"WHERE " +
        //                      $"Usuario = '{usuario}' " +
        //                      $"AND Senha = '{senha}' ";

        //    SqlDataReader reader = cmd.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        int usuarioId = Re
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return Json(new { Msg = "Usuário não encontrado!" });
        //}

        //[HttpPost]
        //public IActionResult Cadastrar(string usuario, string senha)
        //{
        //    Conexao conexao = new Conexao();
        //    SqlCommand cmd = new SqlCommand();

        //cmd.CommandText = "";
        //    cmd.Connection = conexao.Open();

        //    cmd.CommandText = $"SELECT Usuario, Senha FROM usuarios WHERE Usuario = '{usuario}' AND Senha = '{senha}' ";

        //    SqlDataReader reader = cmd.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        conexao.Close();
        //        return Json(new { Msg = "Usuário já existe!" });
        //    }
        //    else
        //    {
        //        conexao.Close();
        //        cmd.CommandText = "";

        //        cmd.Connection = conexao.Open();
        //        cmd.CommandText = $"INSERT INTO Usuarios " +
        //                          $"(Usuario, Senha) " +
        //                          $"VALUES " +
        //                          $"('{usuario}', '{senha}')";
        //        cmd.ExecuteReader();
        //        conexao.Close();
        //        return RedirectToAction("Index", "Login");
        //    }

    }
}
