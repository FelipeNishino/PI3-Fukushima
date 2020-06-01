using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static Compra PreencheComFabrica(linha[] linhasPreenchidas)
        {
            Compra compra = new Compra();

            //foreach (linha linha in linhasPreenchidas)
            //{
            //    if (linha.azulejo.quantidade < linha.posicao + 1 && !tabuleiro.verificarAzulejoParede(linha.azulejo.id, linha.posicao, tabuleiro))
            //    {
            //        if (fabricas != null)
            //        {
            //            foreach (Fabrica fabrica in fabricas)
            //            {
            //                azulejo = fabrica.azulejos.Find(azulejoFind => azulejoFind.id == linha.azulejo.id);
            //                if (azulejo != null)
            //                {
            //                    local = "F";
            //                    idFabricaComprada = fabrica.id;
            //                    linhaComprada.azulejo = azulejo;
            //                    linhaComprada.posicao = linha.posicao;
            //                    comprou = true;
            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            azulejo = centro.azulejos.Find(azulejoFind => azulejoFind.id == linha.azulejo.id);
            //            if (azulejo != null)
            //            {
            //                local = "C";
            //                linhaComprada.azulejo = azulejo;
            //                linhaComprada.posicao = linha.posicao;
            //                comprou = true;
            //            }
            //        }
            //    }
            //}

            return compra;
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
