using EnadeExperience.Controllers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EnadeExperience.Models
{
    public class CursoViewModel
    {
        public int ID { get; set; }
        public string NomeCurso { get; set; }
        public int PopUp { get; set; }

        public List<CursoViewModel> ListarCursos()
        {
            List<CursoViewModel> lista = new List<CursoViewModel>();
            CursoViewModel curso;

            string sql = "SELECT * FROM Cursos WITH(READPAST) ORDER BY Curso";
            Conexao objDAL = new Conexao();

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                curso = new CursoViewModel();
                curso.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                curso.NomeCurso = dt.Rows[i]["Curso"].ToString();
                lista.Add(curso);
            }
            return lista;
        }

        public CursoViewModel CarregarCurso(int? id)
        {
            CursoViewModel item = new CursoViewModel();

            string sql = $"SELECT * FROM Cursos WITH(READPAST) WHERE ID = {id}";
            Conexao objDAL = new Conexao();
            DataTable dt = objDAL.RetDataTable(sql);

            if(dt.Rows.Count == 0)
                return null;

            item.ID = int.Parse(dt.Rows[0]["ID"].ToString());
            item.NomeCurso = dt.Rows[0]["Curso"].ToString();

            return item;
        }

        public void Inserir()
        {
            string sql = "";

           

            if (ID == 0)
            {
                sql = $"INSERT INTO Cursos " +
                      $"(Curso) " +
                      $"VALUES " +
                      $"('{NomeCurso}')";

                PopUp = 1;
            }
            else
            {
                sql = $"UPDATE Cursos SET Curso = '{NomeCurso}' WHERE ID = {ID}";

                PopUp = 2;
            }
            
            Conexao objDal = new Conexao();

            objDal.ExecutarComandoSQL(sql);
        }

        public void Editar(int? id_curso)
        {
            if(id_curso != null)
            {
                new Conexao().ExecutarComandoSQL("UPDATE Cursos SET ID= " + id_curso + " WHERE ");
            }
            
        }

        public void Excluir(int id_curso)
        {
            new Conexao().ExecutarComandoSQL("DELETE FROM Cursos WHERE ID= " + id_curso);
        }
    }
}
