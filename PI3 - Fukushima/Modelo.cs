using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3___Fukushima
{

    public class Modelo
    {
        public Azulejo[] arrayAzulejos { get; set; }

        public int listarModelo(String[] geral)
        {
            int i = 1;

            while (geral[i] != "parede") {
                Azulejo azulejo = new Azulejo();                

                int linha = Convert.ToInt32(geral[i].Substring(0, 1));

                azulejo.id = Convert.ToInt32(geral[i].Substring(2, 1));
                azulejo.quantidade = Convert.ToInt32(geral[i].Substring(4, 1));
                azulejo.carregarImagem();
                
                this.arrayAzulejos[linha - 1] = azulejo;
                i++;
            }

            return i;
        }  
    }
}
