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
    class DadosBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_dados";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(DadosDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Ylms}','{medDto.Y03}','{medDto.S25}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(DadosDTO medDto)
        {
            string editar = $"update {tabela} set ylms = '{medDto.Ylms}', y03 = '{medDto.Y03}', s25 = '{medDto.S25}' where id = '{medDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(DadosDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
