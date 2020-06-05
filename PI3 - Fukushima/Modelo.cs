using System;

namespace PI3___Fukushima
{
    public struct Linha
    {
        public int posicao;
        public Azulejo azulejo;

        public Linha(int posicao, Azulejo azulejo) {
            this.posicao = -1;
            this.azulejo = new Azulejo
            {
                Id = -1,
                Quantidade = -1
            };
        }
    }


    public class Modelo
    {
        //public Azulejo[] arrayAzulejos { get; set; }

        public Linha[] linhas { get; set; }

        public Modelo(){
            Azulejo azulejo = new Azulejo
            {
                Id = -1,
                Quantidade = -1
            };

            this.linhas = new Linha[1];
            this.linhas[0].azulejo = azulejo;
            this.linhas[0].posicao = -1;
        }
        public int ListarModelo(String[] geral)
        {
            int i = 1;

            while (geral[i] != "parede") {
                Azulejo azulejo = new Azulejo();                
               
                int linha = Convert.ToInt32(geral[i].Substring(0, 1));

                azulejo.Id = Convert.ToInt32(geral[i].Substring(2, 1));
                azulejo.Quantidade = Convert.ToInt32(geral[i].Substring(4, 1));
                azulejo.CarregarImagem();

                this.linhas[linha - 1].azulejo = azulejo;
                this.linhas[linha - 1].posicao = linha - 1;
                i++;
            }

            return i;
        }  
    }
}
