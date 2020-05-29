using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3___Fukushima
{
    public struct linha
    {
        public int posicao;
        public Azulejo azulejo;

        public linha(int posicao, Azulejo azulejo) {
            this.posicao = -1;
            this.azulejo = new Azulejo();
            this.azulejo.id = -1;
            this.azulejo.quantidade = -1;
        }
    }


    public class Modelo
    {
        //public Azulejo[] arrayAzulejos { get; set; }

        public linha[] linhas { get; set; }

        public Modelo(){
            Azulejo azulejo = new Azulejo
            {
                id = -1,
                quantidade = -1
            };

            this.linhas = new linha[1];
            this.linhas[0].azulejo = azulejo;
            this.linhas[0].posicao = -1;
        }
        public int listarModelo(String[] geral)
        {
            int i = 1;

            while (geral[i] != "parede") {
                Azulejo azulejo = new Azulejo();                
               
                int linha = Convert.ToInt32(geral[i].Substring(0, 1));

                azulejo.id = Convert.ToInt32(geral[i].Substring(2, 1));
                azulejo.quantidade = Convert.ToInt32(geral[i].Substring(4, 1));
                azulejo.carregarImagem();

                this.linhas[linha - 1].azulejo = azulejo;
                this.linhas[linha - 1].posicao = linha - 1;
                i++;
            }

            return i;
        }  
    }
}
