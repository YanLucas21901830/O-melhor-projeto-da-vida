using OMelhoProjetoDaVida.Code.DAL;
using OMelhoProjetoDaVida.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMelhoProjetoDaVida.Code.BLL
{
    class LoginBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_usuario";


        public bool RealizarLogin(LoginDTO Login)
        {
            string sql = $"select * from {tabela} where email='{Login.Email}' and senha='{Login.Senha}' and cpf = '{Login.CPF}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
