using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3___Fukushima
{
    static class Estrategia
    {
        public static void MenorChao()
        {
            //
        }
        public static List<Compra> MaiorModelo(linha[] linhasVazias,List<Jogada> jogadas, List<Jogada> jogadasBoas, int maiorQuantidadeFabrica, int maiorQuantidadeCentro, Tabuleiro tabuleiro)
        {

            List<Jogada> jogadasMaiorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            Azulejo azulejo = new Azulejo();


            //procura a maior quantidade entre as jogadas
            jogadasMaiorQuantidade = jogadas.FindAll(jogada => (jogada.quantidade == maiorQuantidadeFabrica && jogada.IdFabrica != 0) || (jogada.quantidade == maiorQuantidadeCentro && jogada.IdFabrica == 0 && maiorQuantidadeCentro <= 5));
            
            //prucura uma linha vazia que caiba a maiorquantidade
            linha linhaVazia = Array.Find(linhasVazias, linha => linha.posicao == maiorQuantidadeFabrica || (linha.posicao == maiorQuantidadeCentro && maiorQuantidadeCentro <= 5));

            //configura a list de compras validas
            for (int i = 0; i < jogadasMaiorQuantidade.Count; i++)
            {
                Compra compra = new Compra();
                compra.id = jogadasMaiorQuantidade[i].id;
                compra.quantidade = jogadasMaiorQuantidade[i].quantidade;
                compra.IdFabrica = jogadasMaiorQuantidade[i].IdFabrica;
                compra.Local = (compra.id == 0)? "C" : "F";
                compra.LinhaModelo = linhaVazia.posicao;
                compras.Add(compra);
            }

            return compras;
        }
        public static void MenorModelo()
        {
            //tem
        }
        public static List<Compra> PreencheComFabrica(List<Jogada> jogadas, linha[] linhasPreenchidas, Tabuleiro tabuleiro)
        {
            List<Jogada> jogadasBoas = new List<Jogada>();
            List<Compra> compras = new List<Compra>();

            foreach (linha linha in linhasPreenchidas)
            {
                jogadasBoas = jogadas.FindAll(jogada => jogada.quantidade < linha.posicao && jogada.IdFabrica > 0 && jogada.id == linha.azulejo.id && !tabuleiro.verificarAzulejoParede(jogada.id, linha.posicao, tabuleiro));
                foreach (Jogada jogadaBoa in jogadasBoas)
                {
                    Compra compra = new Compra
                    {
                        id = jogadaBoa.id,
                        IdFabrica = jogadaBoa.IdFabrica,
                        quantidade = jogadaBoa.quantidade,
                        LinhaModelo = linha.posicao,
                        Local = "F"
                    };
                    compras.Add(compra);
                }
            }

            return compras;
        }
        public static void PreencheComCentro()
        {
            //tem
        }
        public static void MenorCentro()
        {

        }
        public static void MaiorCentro()
        {
            //tem
        }
    }
}
