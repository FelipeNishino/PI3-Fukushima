using System.Drawing;

namespace PI3___Fukushima
{
    public class Azulejo
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Image Imagem { get; set; }

        public void CarregarImagem() {
            switch (this.Id)
            {
                case 1:
                    this.Imagem = Properties.Resources.Azul;
                    break;

                case 2:
                    this.Imagem = Properties.Resources.Amarelo;
                    break;

                case 3:
                    this.Imagem = Properties.Resources.Vermelho;
                    break;

                case 4:
                    this.Imagem = Properties.Resources.Preto;
                    break;

                case 5:
                    this.Imagem = Properties.Resources.Branco;
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
