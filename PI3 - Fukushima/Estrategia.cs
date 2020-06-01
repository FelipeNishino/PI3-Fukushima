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
        public static Compra MaiorModelo(/*List<Fabrica> fabricas, centro, Tabuleiro tabuleiro, Jogador jogador*/)
        {
            ////Pega o azulejo com a maior quantidade da frabica ou do centro e joga na linha do modelo vazia
            Compra compra = new Compra();
            //compra.id = 0;
            //compra.IdFabrica = 0;
            //compra.Local = "";
            //compra.LinhaModelo = 0;

            //Compra[] compras = new Compra[5];

            //Azulejo azulejo = new Azulejo();

            ////pega todas as linhas que não estao preenchidas
            //for (int i = 0; i < compras.Length; i++)
            //{
            //    if (!Array.Find(linhasPreenchidas, linhasPreenchidas.posicao != i)) {
            //        compras[i].LinhaModelo = i; 
            //    }
            //}

            ////procura nas fabricas
            //if (fabricas.Count != 0)
            //{
            //    foreach (Fabrica fabrica1 in fabricas)
            //    {
            //        fabrica1.azulejos.find(azulejo, azulejo.quantidade == compra)
            //        foreach (Azulejo azulejo1 in fabrica1.azulejos)
            //        {
            //            if (azulejo1.quantidade > azulejoComprar.quantidade)
            //            {
            //                azulejoComprar = azulejo1;
            //                idFabricaComprada = fabrica1.id;
            //            }
            //        }
            //    }
            //    compra.Local = "F";
            //}
            //else
            //{
            //    foreach (Azulejo azulejo1 in centro.azulejos)
            //    {
            //        if (azulejo1.quantidade > azulejoComprar.quantidade)
            //        {
            //            azulejoComprar = azulejo1;
            //            idFabricaComprada = 0;
            //        }
            //    }
            //    compra.Local = "C";
            //}
            //int j = 4;
            //while (tabuleiro.modelo.linhas[j].azulejo.id != -1 && j + 1 > azulejoComprar.quantidade)
            //{
            //    j--;
            //}

            //if (!tabuleiro.verificarAzulejoParede(azulejoComprar.id, j, tabuleiro) && tabuleiro.modelo.linhas[j].azulejo.quantidade < j + 1)
            //{
            //    //if (!VerificarErro(Jogo.Jogar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], local, idFabricaComprada, azulejoComprar.id, j + 1)))
            //    if (tabuleiro.modelo.linhas[j].azulejo.id == -1)
            //    {
            //        Jogo.Jogar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], local, idFabricaComprada, azulejoComprar.id, j + 1);
            //        lastPlay = dadosJogador[0] + "," + local + "," + idFabricaComprada + "," + azulejoComprar.id + "," + (j + 1);
            //        sleepTime = 2000;
            //        comprou = true;
            //    }
            //}

            return compra;
        }
        public static void MenorModelo()
        {
            //tem
        }
        public static Compra PreencheComFabrica(List<Jogada> jogadas, linha[] linhasPreenchidas, Tabuleiro tabuleiro)
        {
            Compra compra = new Compra();
            List<Jogada> jogadasBoas = new List<Jogada>();

            foreach (linha linha in linhasPreenchidas)
            {
                jogadasBoas.A
            }

            foreach (linha linha in linhasPreenchidas)
            {
                if (linha.azulejo.quantidade < linha.posicao + 1 && !tabuleiro.verificarAzulejoParede(linha.azulejo.id, linha.posicao, tabuleiro))
                {
                    if (fabricas != null)
                    {
                        foreach (Fabrica fabrica in fabricas)
                        {
                            azulejo = fabrica.azulejos.Find(azulejoFind => azulejoFind.id == linha.azulejo.id);
                            if (azulejo != null)
                            {
                                local = "F";
                                idFabricaComprada = fabrica.id;
                                linhaComprada.azulejo = azulejo;
                                linhaComprada.posicao = linha.posicao;
                                comprou = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        azulejo = centro.azulejos.Find(azulejoFind => azulejoFind.id == linha.azulejo.id);
                        if (azulejo != null)
                        {
                            local = "C";
                            linhaComprada.azulejo = azulejo;
                            linhaComprada.posicao = linha.posicao;
                            comprou = true;
                        }
                    }
                }
            }

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
