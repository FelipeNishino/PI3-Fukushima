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
                
                switch (azulejo.id)
                {
                    case 1:
                        azulejo.imagem = Properties.Resources.Azul;
                        break;

                    case 2:
                        azulejo.imagem = Properties.Resources.Amarelo;
                        break;

                    case 3:
                        azulejo.imagem = Properties.Resources.Vermelho;
                        break;

                    case 4:
                        azulejo.imagem = Properties.Resources.Preto;
                        break;

                    case 5:
                        azulejo.imagem = Properties.Resources.Branco;
                        break;

                    default:
                        break;
                }
                this.arrayAzulejos[linha - 1] = azulejo;
                i++;
            }

            return i;
        }  
    }
}
