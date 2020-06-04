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
        
            //procura a maior quantidade entre as jogadas
            jogadasMaiorQuantidade = jogadas.FindAll(jogada => (jogada.quantidade == maiorQuantidadeFabrica && jogada.IdFabrica != 0) || (jogada.quantidade == maiorQuantidadeCentro && jogada.IdFabrica == 0 && 0 < maiorQuantidadeCentro && maiorQuantidadeCentro <= 5));
            
            //prucura uma linha vazia que caiba a maiorquantidade
            linha linhaVaziaFabricas = Array.Find(linhasVazias, linha => linha.posicao == maiorQuantidadeFabrica);
           
            //percorre todas as jogadas de maior quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
            for (int i = 0; i < jogadasMaiorQuantidade.Count; i++)
            {
               
                //realiza a configuração da compra
                if (!tabuleiro.verificarAzulejoParede(jogadasMaiorQuantidade[i].id, linhaVaziaFabricas.posicao - 1, tabuleiro)) {
                    Compra compra = new Compra();
                    compra.id = jogadasMaiorQuantidade[i].id;
                    compra.quantidade = jogadasMaiorQuantidade[i].quantidade;
                    compra.IdFabrica = jogadasMaiorQuantidade[i].IdFabrica;
                    compra.Local = "F";
                    compra.LinhaModelo = linhaVaziaFabricas.posicao;
                    compras.Add(compra);
                }
            }

            return compras;
        }
        public static List<Compra> MenorModelo(linha[] linhasVazias, List<Jogada> jogadas, List<Jogada> jogadasBoas, int menorQuantidadeFabrica, int menorQuantidadeCentro, Tabuleiro tabuleiro)
        {

            List<Jogada> jogadasMenorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();

            //procura a menor quantidade entre as jogadas
            jogadasMenorQuantidade = jogadas.FindAll(jogada => (jogada.quantidade == menorQuantidadeFabrica && jogada.IdFabrica != 0) || (jogada.quantidade == menorQuantidadeFabrica && jogada.IdFabrica == 0 && 0 < menorQuantidadeFabrica && menorQuantidadeFabrica <= 5));

            //prucura uma linha vazia que caiba a menor quantidade
            linha linhaVaziaFabricas = Array.Find(linhasVazias, linha => linha.posicao == menorQuantidadeFabrica);

            //percorre todas as jogadas de menor quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
            for (int i = 0; i < jogadasMenorQuantidade.Count; i++)
            {

                //realiza a configuração da compra
                if (!tabuleiro.verificarAzulejoParede(jogadasMenorQuantidade[i].id, linhaVaziaFabricas.posicao - 1, tabuleiro))
                {
                    Compra compra = new Compra();
                    compra.id = jogadasMenorQuantidade[i].id;
                    compra.quantidade = jogadasMenorQuantidade[i].quantidade;
                    compra.IdFabrica = jogadasMenorQuantidade[i].IdFabrica;
                    compra.Local = "F";
                    compra.LinhaModelo = linhaVaziaFabricas.posicao;
                    compras.Add(compra);
                }
            }

            return compras;
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
        public static List<Compra> MenorCentro(linha[] linhasVazias, List<Jogada> jogadas, int menorQuantidadeCentro, Tabuleiro tabuleiro)
        {
            List<Jogada> jogadasMenorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            int linhaModelo = 0;

            //procura a menor quantidade entre as jogadas
            jogadasMenorQuantidade = jogadas.FindAll(jogada => jogada.quantidade == menorQuantidadeCentro && jogada.IdFabrica == 0 && 0 < menorQuantidadeCentro);

            //percorre as linhas do modelo procurando uma linha onde possa colocar a menor quantidade do centro
            int i = 0;
            while (i != 4 || linhasVazias[i].posicao <= menorQuantidadeCentro)
            {
                linhaModelo = linhasVazias[i].posicao;
            }


            //percorre todas as jogadas de menor quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
            for (i = 0; i < jogadasMenorQuantidade.Count; i++)
            {
                if (!tabuleiro.verificarAzulejoParede(jogadasMenorQuantidade[i].id, linhaModelo - 1, tabuleiro))
                {
                    Compra compra = new Compra();
                    compra.id = jogadasMenorQuantidade[i].id;
                    compra.quantidade = jogadasMenorQuantidade[i].quantidade;
                    compra.IdFabrica = jogadasMenorQuantidade[i].IdFabrica;
                    compra.Local = "C";
                    compra.LinhaModelo = linhaModelo;
                    compras.Add(compra);
                }
            }

            return compras;
        }
        public static List<Compra> MaiorCentro(linha[] linhasVazias, List<Jogada> jogadas, int maiorQuantidadeCentro, Tabuleiro tabuleiro)
        {
            List<Jogada> jogadasMaiorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            int linhaModelo = 0;

            //procura a maior quantidade entre as jogadas
            jogadasMaiorQuantidade = jogadas.FindAll(jogada => jogada.quantidade == maiorQuantidadeCentro && jogada.IdFabrica == 0 && 0 < maiorQuantidadeCentro);

            //percorre as linhas do modelo procurando uma linha onde possa colocar a maior quantidade do centro
            int i = 0;
            while (i != 4 || linhasVazias[i].posicao <= maiorQuantidadeCentro)
            {
                linhaModelo = linhasVazias[i].posicao;
            }


            //percorre todas as jogadas de maior quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
            for (i = 0; i < jogadasMaiorQuantidade.Count; i++)
            {
                if (!tabuleiro.verificarAzulejoParede(jogadasMaiorQuantidade[i].id, linhaModelo - 1, tabuleiro))
                {
                    Compra compra = new Compra();
                    compra.id = jogadasMaiorQuantidade[i].id;
                    compra.quantidade = jogadasMaiorQuantidade[i].quantidade;
                    compra.IdFabrica = jogadasMaiorQuantidade[i].IdFabrica;
                    compra.Local = "C";
                    compra.LinhaModelo = linhaModelo;
                    compras.Add(compra);
                }
            }

            return compras;
        }
    }
}
