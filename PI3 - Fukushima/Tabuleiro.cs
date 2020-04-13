using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace PI3___Fukushima
{
    class Tabuleiro
    {
        public int pontos { get; set; }

        bool[,] parede = new bool[5, 5];

        public Modelo modelo { get; set; }

        private string[] paredeListar, chaoListar;
        


        public void Listar(int idJogador, String senhaJogador, Tabuleiro tabuleiro)
        {
            String geral;
          
            String retorno = Jogo.LerTabuleiro(idJogador, senhaJogador, idJogador);
            retorno = retorno.Replace("\r", "");
            
            geral = retorno.Substring(0, retorno.IndexOf("p") - 1).Replace("modelo\n", "");
            

            if (geral != "") {
                tabuleiro.modelo = new Modelo();
                tabuleiro.modelo.arrayAzulejos = new Azulejo[5];
                frmPartida frmPartida = (frmPartida)Application.OpenForms["frmPartida"];
                modelo.listarModelo(geral);


               

            }

            
            //geral = retorno.Substring(retorno.IndexOf("p"), retorno.IndexOf("c") - 1).Replace("parede\n", "");
            //geral = retorno.Substring(retorno.IndexOf("c")).Replace("chao\n", "");
            
            MessageBox.Show("break");
        }

    }
}
