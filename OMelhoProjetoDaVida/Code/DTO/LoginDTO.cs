using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMelhoProjetoDaVida.Code.DTO
{
    class LoginDTO
    {
        private int _id;
        private string _email, _senha,_CPF;

        public int Id { get => _id; set => _id = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string CPF { get => _CPF; set => _CPF = value; }
    }
}
