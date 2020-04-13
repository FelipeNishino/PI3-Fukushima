using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3___Fukushima
{

    class Modelo
    {
        public Azulejo[] arrayAzulejos { get; set; }


        public void listarModelo(String geral)
        {
            string[] modeloListar;
            modeloListar = geral.Split('\n');

            for (int i = 0; i < modeloListar.Length; i++)
            {

                Azulejo azulejo = new Azulejo();
                azulejo.imagem = new PictureBox();

                int linha = Convert.ToInt32(modeloListar[i].Substring(0, 1));

                azulejo.id = Convert.ToInt32(modeloListar[i].Substring(2, 1));
                azulejo.quantidade = Convert.ToInt32(modeloListar[i].Substring(4, 1));


                //modelo.arrayAzulejos[Convert.ToInt32(modeloListar[i].Substring(0, 1)) - 1].id = Convert.ToInt32(modeloListar[i].Substring(2, 1));
                //modelo.arrayAzulejos[Convert.ToInt32(modeloListar[i].Substring(0, 1)) - 1].quantidade = Convert.ToInt32(modeloListar[i].Substring(4, 1));

                switch (azulejo.id)
                {
                    case 1:
                        //azulejo.imagem.Load("Resources/Azul.png");
                        azulejo.imagem.Image = Properties.Resources.Azul;
                        break;

                    case 2:
                        azulejo.imagem.Image = Properties.Resources.Azul;
                        break;

                    case 3:
                        azulejo.imagem.Image = Properties.Resources.Azul;
                        break;

                    case 4:
                        azulejo.imagem.Image = Properties.Resources.Azul;
                        break;

                    case 5:
                        azulejo.imagem.Image = Properties.Resources.Azul;
                        break;

                    default:
                        break;
                }


                this.arrayAzulejos[linha] = azulejo;

            }
        }  
    }
}
