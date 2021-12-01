using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMelhoProjetoDaVida.Code.DTO
{
    class UsuarioDTO
    {
        private int _id;
        private string _nome, _tell, _rua, _numero, _bairro, _cidade, _estado, _pais, _cpf, _rg, _datanas, _país, _email, _senha;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Tell { get => _tell; set => _tell = value; }
        public string Rua { get => _rua; set => _rua = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Pais { get => _pais; set => _pais = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Datanas { get => _datanas; set => _datanas = value; }
        public string País { get => _país; set => _país = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
    }
}
