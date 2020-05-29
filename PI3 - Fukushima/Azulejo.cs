using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3___Fukushima
{
    public class Azulejo
    {
        public int id { get; set; }
        public int quantidade { get; set; }
        public Image imagem { get; set; }

        public void carregarImagem() {
            switch (this.id)
            {
                case 1:
                    this.imagem = Properties.Resources.Azul;
                    break;

                case 2:
                    this.imagem = Properties.Resources.Amarelo;
                    break;

                case 3:
                    this.imagem = Properties.Resources.Vermelho;
                    break;

                case 4:
                    this.imagem = Properties.Resources.Preto;
                    break;

                case 5:
                    this.imagem = Properties.Resources.Branco;
                    break;

                default:
                    break;
            }

        }
    }

    //1 - azul 
    //2 - amarelo
    //3 - vermelho
    //4 - preto
    //5 - branco
}
