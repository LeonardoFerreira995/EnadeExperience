using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EnadeExperience.Models
{
    public class DisciplinasViewModel
    {
        public int ID { get; set; }
        public string NomeDisciplina { get; set; }
        public int PopUp { get; set; }

        public List<DisciplinasViewModel> ListarDisciplinas()
        {
            List<DisciplinasViewModel> lista = new List<DisciplinasViewModel>();
            DisciplinasViewModel disciplina;

            string sql = "SELECT * FROM Disciplinas ORDER BY Disciplina";
            Conexao objDAL = new Conexao();

            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                disciplina = new DisciplinasViewModel();
                disciplina.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                disciplina.NomeDisciplina = dt.Rows[i]["Disciplina"].ToString();
                lista.Add(disciplina);
            }
            return lista;
        }
        public DisciplinasViewModel CarregarDisciplina(int? id)
        {
            DisciplinasViewModel item = new DisciplinasViewModel();

            string sql = $"SELECT * FROM Disciplinas WHERE ID = {id}";
            Conexao objDAL = new Conexao();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt.Rows.Count == 0)
                return null;

            item.ID = int.Parse(dt.Rows[0]["ID"].ToString());
            item.NomeDisciplina = dt.Rows[0]["Disciplina"].ToString();

            return item;
        }
        public void Inserir()
        {

            string sql = "";

            if (ID == 0)
            {
                sql = $"INSERT INTO Disciplinas " +
                      $"(Disciplina) " +
                      $"VALUES " +
                      $"('{NomeDisciplina}')";

                PopUp = 1;
            }
            else
            {
                sql = $"UPDATE Disciplinas SET Disciplina = '{NomeDisciplina}' WHERE ID = {ID}";

                PopUp = 2;
            }
            Conexao objDal = new Conexao();

            objDal.ExecutarComandoSQL(sql);
        }
        public void Editar(int? id_disciplina)
        {
            if (id_disciplina != null)
            {
                new Conexao().ExecutarComandoSQL("UPDATE Disciplinas SET ID= " + id_disciplina + " WHERE ");
            }

        }
        public void Excluir(int id_disciplina)
        {
            new Conexao().ExecutarComandoSQL("DELETE FROM Disciplinas WHERE ID= " + id_disciplina);
        }
    }
}
