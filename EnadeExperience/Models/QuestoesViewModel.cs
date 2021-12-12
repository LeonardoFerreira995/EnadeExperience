using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnadeExperience.Models
{
    public class QuestoesViewModel
    {
        public int ID { get; set; }
        public string Imagem { get; set; }
        public string Questao { get; set; }
        public string Disciplina { get; set; }
        public string Disciplina2 { get; set; }
        public string Disciplina3 { get; set; }
        public string Disciplina4 { get; set; }
        public string Disciplina5 { get; set; }
        public string Curso { get; set; }
        public int Ano { get; set; }
        public string Dificuldade { get; set; }
        public string Resposta { get; set; }
        public string Ordem { get; set; }
        public int PopUp { get; set; }

        private CursoViewModel _cursoViewModel;
        private DisciplinasViewModel _disciplinaViewModel;

        public List<QuestoesViewModel> ListarQuestoes()
        {
            List<QuestoesViewModel> lista = new List<QuestoesViewModel>();
            QuestoesViewModel questao;

            string sql = "SELECT * FROM Questoes ORDER BY ID DESC";
            Conexao objDAL = new Conexao();

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                questao = new QuestoesViewModel();
                questao.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                questao.Questao = dt.Rows[i]["Questao"].ToString();

                var curso = ObterNomeCurso(dt.Rows[i]["IdCurso"].ToString());

                if (curso is null)
                    continue;

                questao.Curso = curso;

                var disciplina = ObterNomeDisciplina(dt.Rows[i]["IdDisciplina"].ToString());

                if (disciplina is null)
                    continue;

                questao.Disciplina = disciplina;
                questao.Disciplina2 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina2"].ToString());
                questao.Disciplina3 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina3"].ToString());
                questao.Disciplina4 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina4"].ToString());
                questao.Disciplina5 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina5"].ToString());
                questao.Ano = int.Parse(dt.Rows[i]["Ano"].ToString());
                questao.Dificuldade = dt.Rows[i]["Dificuldade"].ToString();
                questao.Resposta = dt.Rows[i]["Resposta"].ToString();
                questao.Imagem = dt.Rows[i]["Imagem"].ToString();

                lista.Add(questao);
            }
            return lista;
        }

      

        public List<QuestoesViewModel> FiltrarQuestoes()
        {
            List<QuestoesViewModel> lista = new List<QuestoesViewModel>();
            QuestoesViewModel questao;

            // WHERE
            string sqlWhere = "";

            if (Disciplina != null || Curso != null || Ano != 0 || Dificuldade != null)
            {
                sqlWhere = "WHERE";

                // Curso
                if (Curso != null)
                {
                    if (sqlWhere == "WHERE")
                    {
                        sqlWhere += $" IdCurso = {Curso}";
                    }
                    else
                    {
                        sqlWhere += $" AND IdCurso = {Curso}";
                    }
                }

                // Ano
                if (Ano != 0)
                {
                    if (sqlWhere == "WHERE")
                    {
                        sqlWhere += $" Ano = {Ano}";
                    }
                    else
                    {
                        sqlWhere += $" AND Ano = {Ano}";
                    }
                }

                // Dificuldade
                if (Dificuldade != null)
                {
                    if (sqlWhere == "WHERE")
                    {
                        sqlWhere += $" Dificuldade = '{Dificuldade}'";
                    }
                    else
                    {
                        sqlWhere += $" AND Dificuldade = '{Dificuldade}'";
                    }
                }

                // Disciplina
                if (Disciplina != null)
                {
                    if (sqlWhere == "WHERE")
                    {
                        sqlWhere += $" IdDisciplina = {Disciplina}";
                    }
                    else
                    {
                        sqlWhere += $" AND IdDisciplina = {Disciplina}";
                    }
                    
                }
            }

            string sqlOrderBy = "";

            if (Ordem != null)
            {
                sqlOrderBy = $" ORDER BY {Ordem}";
            }

            string sql = "SELECT * FROM Questoes ";
            sql += sqlWhere;
            sql += sqlOrderBy;

            Conexao objDAL = new Conexao();

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                questao = new QuestoesViewModel();
                questao.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                questao.Questao = dt.Rows[i]["Questao"].ToString();

                var curso = ObterNomeCurso(dt.Rows[i]["IdCurso"].ToString());

                if (curso is null)
                    continue;

                questao.Curso = curso;

                var disciplina = ObterNomeDisciplina(dt.Rows[i]["IdDisciplina"].ToString());

                if (disciplina is null)
                    continue;

                questao.Disciplina = disciplina;

                var disciplina2 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina2"].ToString());

                if (disciplina2 is null)
                    continue;

                questao.Disciplina2 = disciplina2;

                var disciplina3 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina3"].ToString());

                if (disciplina3 is null)
                    continue;

                questao.Disciplina3 = disciplina3;

                var disciplina4 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina4"].ToString());

                if (disciplina4 is null)
                    continue;

                questao.Disciplina4 = disciplina4;

                var disciplina5 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina5"].ToString());

                if (disciplina5 is null)
                    continue;

                questao.Disciplina5 = disciplina5;

                questao.Ano = int.Parse(dt.Rows[i]["Ano"].ToString());
                questao.Dificuldade = dt.Rows[i]["Dificuldade"].ToString();
                questao.Resposta = dt.Rows[i]["Resposta"].ToString();
                questao.Imagem = dt.Rows[i]["Imagem"].ToString();

                lista.Add(questao);
            }
            return lista;
        }

        public string AbreviacaoQuestao(string questao)
        {
            if (questao.Length > 200)
            {
                return questao.Substring(0, 470) + "...";
            }
            else
            {
                return questao.Substring(0, questao.Length) + "";
            }
        }

        public string ObterNomeCurso(string id)
        {
            _cursoViewModel = new CursoViewModel();
            var curso = _cursoViewModel.CarregarCurso(Int32.Parse(id));

            if (curso is null)
                return null;

            return curso.NomeCurso;
        }

        public string ObterNomeDisciplina(string id)
        {
            _disciplinaViewModel = new DisciplinasViewModel();
            var disciplina = _disciplinaViewModel.CarregarDisciplina(Int32.Parse(id));

            if (disciplina is null)
                return null;

            return disciplina.NomeDisciplina;
        }

        public string ObterNomeDisciplinaNula(string id)
        {
            // Tratamento pois a Disciplina2, Disciplina3, Disciplina4 e Disciplina5 pode vir nula
            if (id == "" || id == "0")
            {
                var recebeNome = "";
                return recebeNome;
            }
            else
            {
                var disciplina = _disciplinaViewModel.CarregarDisciplina(Int32.Parse(id));

                if (disciplina is null)
                    return null;

                return disciplina.NomeDisciplina;
            }
        }

        public QuestoesViewModel CarregarQuestao(int? id)
        {
            QuestoesViewModel item = new QuestoesViewModel();

            string sql = $"SELECT * FROM Questoes WHERE ID = {id}";
            Conexao objDAL = new Conexao();
            DataTable dt = objDAL.RetDataTable(sql);

            item.ID = int.Parse(dt.Rows[0]["ID"].ToString());
            item.Questao = dt.Rows[0]["Questao"].ToString();
            item.Curso = dt.Rows[0]["IdCurso"].ToString();
            item.Disciplina = dt.Rows[0]["IdDisciplina"].ToString();
            item.Disciplina2 = dt.Rows[0]["IdDisciplina2"].ToString();
            item.Disciplina3 = dt.Rows[0]["IdDisciplina3"].ToString();
            item.Disciplina4 = dt.Rows[0]["IdDisciplina4"].ToString();
            item.Disciplina5 = dt.Rows[0]["IdDisciplina5"].ToString();
            item.Ano = int.Parse(dt.Rows[0]["Ano"].ToString());
            item.Dificuldade = dt.Rows[0]["Dificuldade"].ToString();
            item.Resposta = dt.Rows[0]["Resposta"].ToString();
            item.Imagem = dt.Rows[0]["Imagem"].ToString();

            return item;
        }

        public QuestoesViewModel CarregarNomeCurso(int? id)
        {
            QuestoesViewModel item = new QuestoesViewModel();

            string sql = $"SELECT * FROM Questoes WHERE ID = {id}";
            Conexao objDAL = new Conexao();
            DataTable dt = objDAL.RetDataTable(sql);

            item.ID = int.Parse(dt.Rows[0]["ID"].ToString());
            item.Curso = ObterNomeCurso(dt.Rows[0]["IdCurso"].ToString());

            return item;
        }

        public QuestoesViewModel CarregarNomeDisciplina(int? id)
        {
            QuestoesViewModel item = new QuestoesViewModel();

            string sql = $"SELECT * FROM Questoes WHERE ID = {id}";
            Conexao objDAL = new Conexao();
            DataTable dt = objDAL.RetDataTable(sql);

            item.ID = int.Parse(dt.Rows[0]["ID"].ToString());
            item.Disciplina = ObterNomeDisciplina(dt.Rows[0]["IdDisciplina"].ToString());
            item.Disciplina2 = ObterNomeDisciplinaNula(dt.Rows[0]["IdDisciplina2"].ToString());
            item.Disciplina3 = ObterNomeDisciplinaNula(dt.Rows[0]["IdDisciplina3"].ToString());
            item.Disciplina4 = ObterNomeDisciplinaNula(dt.Rows[0]["IdDisciplina4"].ToString());
            item.Disciplina5 = ObterNomeDisciplinaNula(dt.Rows[0]["IdDisciplina5"].ToString());

            return item;
        }

        public List<QuestoesViewModel> DetalhesQuestao(int id)
        {
            List<QuestoesViewModel> lista = new List<QuestoesViewModel>();
            QuestoesViewModel questao;

            string sql = $"SELECT * FROM Questoes WHERE ID = {id}";
            Conexao objDAL = new Conexao();

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                questao = new QuestoesViewModel();
                questao.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                questao.Questao = AbreviacaoQuestao(dt.Rows[i]["Questao"].ToString());
                questao.Curso = ObterNomeCurso(dt.Rows[i]["IdCurso"].ToString());
                questao.Disciplina = ObterNomeDisciplina(dt.Rows[i]["IdDisciplina"].ToString());
                questao.Disciplina2 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina2"].ToString());
                questao.Disciplina3 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina3"].ToString());
                questao.Disciplina4 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina4"].ToString());
                questao.Disciplina5 = ObterNomeDisciplinaNula(dt.Rows[i]["IdDisciplina5"].ToString());
                questao.Ano = int.Parse(dt.Rows[i]["Ano"].ToString());
                questao.Dificuldade = dt.Rows[i]["Dificuldade"].ToString();
                questao.Resposta = dt.Rows[i]["Resposta"].ToString();
                questao.Imagem = dt.Rows[i]["Imagem"].ToString();

                lista.Add(questao);
            }
            return lista;
        }

        public void ExcluirImagem(int id)
        {
            string sql = "";

            sql = $"UPDATE Questoes SET " +
                          $"Imagem = NULL WHERE ID = {id}";

            Conexao objDal = new Conexao();

            objDal.ExecutarComandoSQL(sql);

        }

        public void Inserir()
        {
            string sql = "";

            if (ID == 0)
            {
                sql = $"INSERT INTO Questoes " +
                      $"(Questao, IdCurso, IdDisciplina, IdDisciplina2, IdDisciplina3, IdDisciplina4, IdDisciplina5, Ano, Dificuldade, Resposta, Imagem) " +
                      $" VALUES " +
                      $"('{Questao}','{Curso}','{Disciplina}','{Disciplina2}','{Disciplina3}','{Disciplina4}','{Disciplina5}','{Ano}','{Dificuldade}', '{Resposta}', '{Imagem}')";

                PopUp = 1;
            }
            else
            {
                if (Imagem != null)
                {
                    sql = $"UPDATE Questoes SET " +
                          $"Questao = '{Questao}', IdCurso = '{Curso}', IdDisciplina = '{Disciplina}', IdDisciplina2 = '{Disciplina2}', IdDisciplina3 = '{Disciplina3}', IdDisciplina4 = '{Disciplina4}', IdDisciplina5 = '{Disciplina5}', Ano = '{Ano}', Dificuldade = '{Dificuldade}', Resposta = '{Resposta}', Imagem = '{Imagem}' WHERE ID = {ID}";

                    PopUp = 2;
                }
                else
                {
                    sql = $"UPDATE Questoes SET " +
                          $"Questao = '{Questao}', IdCurso = '{Curso}', IdDisciplina = '{Disciplina}', IdDisciplina2 = '{Disciplina2}', IdDisciplina3 = '{Disciplina3}', IdDisciplina4 = '{Disciplina4}', IdDisciplina5 = '{Disciplina5}', Ano = '{Ano}', Dificuldade = '{Dificuldade}', Resposta = '{Resposta}' WHERE ID = {ID}";

                    PopUp = 2;
                }
                
            }
            Conexao objDal = new Conexao();

            objDal.ExecutarComandoSQL(sql);
        }
        public void Editar(int? id_questao)
        {
            if (id_questao != null)
            {
                new Conexao().ExecutarComandoSQL("UPDATE Questoes SET ID= " + id_questao + " WHERE ");
            }
        }
        public void Excluir(int id_questao)
        {
            new Conexao().ExecutarComandoSQL("DELETE FROM Questoes WHERE ID= " + id_questao);
        }
    }
}
