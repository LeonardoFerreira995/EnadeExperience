using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EnadeExperience.Models
{
    public class DashEnadeViewModel
    {
        public int ID { get; set; }
        public string Instituicao { get; set; }
        public int AnoAplicacao { get; set; }
        public string Curso { get; set; }
        public int Nota { get; set; }
        public int PopUp { get; set; }

        public List<DashEnadeViewModel> ListaDash()
        {
            List<DashEnadeViewModel> lista = new List<DashEnadeViewModel>();

            DashEnadeViewModel item;

            string sql = $"SELECT * FROM DashEnade ORDER BY AnoAplicacao DESC";

            Conexao objDAL = new Conexao();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new DashEnadeViewModel();
                item.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                item.Instituicao = dt.Rows[i]["Instituicao"].ToString();
                item.AnoAplicacao = int.Parse(dt.Rows[i]["AnoAplicacao"].ToString());
                item.Curso = dt.Rows[i]["Curso"].ToString();
                item.Nota = int.Parse(dt.Rows[i]["Nota"].ToString());

                lista.Add(item);
            }
            return lista;
        }

        public DashEnadeViewModel CarregarResultado(int? id)
        {
            DashEnadeViewModel item = new DashEnadeViewModel();

            string sql = $"SELECT * FROM DashEnade WHERE ID = {id}";
            Conexao objDAL = new Conexao();
            DataTable dt = objDAL.RetDataTable(sql);

            item.ID = int.Parse(dt.Rows[0]["ID"].ToString());
            item.Instituicao = dt.Rows[0]["Instituicao"].ToString();
            item.AnoAplicacao = int.Parse(dt.Rows[0]["AnoAplicacao"].ToString());
            item.Curso = dt.Rows[0]["Curso"].ToString();
            item.Nota = int.Parse(dt.Rows[0]["Nota"].ToString());

            return item;
        }

        public void Inserir()
        {
            string sql = "";

            if (ID == 0)
            {
                sql = $"INSERT INTO DashEnade " +
                      $"(Instituicao, AnoAplicacao, Curso, Nota) " +
                      $"VALUES " +
                      $"('{Instituicao}', '{AnoAplicacao}', '{Curso}', '{Nota}')";

                PopUp = 1;
            }
            else
            {
                sql = $"UPDATE DashEnade SET " +
                      $"Instituicao = '{Instituicao}', AnoAplicacao = '{AnoAplicacao}', Curso = '{Curso}', Nota = '{Nota}' WHERE ID = {ID}";

                PopUp = 2;
            }
            Conexao objDal = new Conexao();

            objDal.ExecutarComandoSQL(sql);
        }
        public void Editar(int? id_resultado)
        {
            if (id_resultado != null)
            {
                new Conexao().ExecutarComandoSQL("UPDATE DashEnade SET ID = " + id_resultado + " WHERE ");
            }
        }
        public void Excluir(int id_resultado)
        {
            new Conexao().ExecutarComandoSQL("DELETE FROM DashEnade WHERE ID= " + id_resultado);
        }
    }
}
