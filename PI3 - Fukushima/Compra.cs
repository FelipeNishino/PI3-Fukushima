using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3___Fukushima
{
    class Compra : Jogada
    {
        public string Local { get; set; }
        public string Fonte{ get; set; }

        public int Prioridade { get; set; }
        public int LinhaModelo { get; set; }
    }
}
