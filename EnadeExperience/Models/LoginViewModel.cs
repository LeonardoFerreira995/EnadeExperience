using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EnadeExperience.Models
{
    public class LoginViewModel
    {
        public int ID { get; set; }
        public string UserName{ get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public int PopUp { get; set; }

        public bool Logar()
        {
            string sql = $"SELECT * FROM Usuarios " +
                         $"WHERE " +
                         $"Usuario = '{UserName}' AND Senha = '{Password}' ";

            Conexao objDAL = new Conexao();
            DataTable dt = objDAL.RetDataTable(sql);

            if(dt != null)
            {
                if(dt.Rows.Count == 1)
                {
                    ID = int.Parse(dt.Rows[0]["ID"].ToString());
                    UserName = dt.Rows[0]["Usuario"].ToString();
                 
                    return true;
                }
            }
            return false;
        }

        public void CadastrarUsuario()
        {
            string sql = $"INSERT INTO " +
                         $"Usuarios (Usuario, Senha)" +
                         $"VALUES " +
                         $"('{UserName}', '{Password}')";

            PopUp = 1;

            Conexao objDal = new Conexao();

            objDal.ExecutarComandoSQL(sql);
        }
    }
}
