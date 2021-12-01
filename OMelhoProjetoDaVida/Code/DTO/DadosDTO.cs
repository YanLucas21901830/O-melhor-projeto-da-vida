using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMelhoProjetoDaVida.Code.DTO
{
    class DadosDTO
    {
        private int _id;
        private string _ylms, _y03, _s25;

        public int Id { get => _id; set => _id = value; }
        public string Ylms { get => _ylms; set => _ylms = value; }
        public string Y03 { get => _y03; set => _y03 = value; }
        public string S25 { get => _s25; set => _s25 = value; }
    }
}
