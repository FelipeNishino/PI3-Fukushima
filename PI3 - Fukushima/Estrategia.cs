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
        public static List<Compra> MenorChao(List<Jogada> jogadas, int menorQuantidadeFabrica, int menorQuantidadeCentro, Tabuleiro tabuleiro)
        {
            List<Jogada> jogadasBoas = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            
            if (menorQuantidadeCentro < menorQuantidadeFabrica)
            {
                jogadasBoas = jogadas.FindAll(jogada => jogada.quantidade == menorQuantidadeCentro);
            }
            else
            {
                jogadasBoas = jogadas.FindAll(jogada => jogada.quantidade == menorQuantidadeFabrica);
            }

            foreach (Jogada jogadaBoa in jogadasBoas)
            {
                Compra compra = new Compra
                {
                    id = jogadaBoa.id,
                    IdFabrica = jogadaBoa.IdFabrica,
                    quantidade = jogadaBoa.quantidade,
                    LinhaModelo = 0,
                    Local = (jogadaBoa.IdFabrica == 0) ? "C" : "F",
                    Fonte = "MenorChao"
                };
                compras.Add(compra);
            }

            return compras;
        }
        public static List<Compra> MaiorModelo(List<linha> linhasVazias,List<Jogada> jogadas, List<Jogada> jogadasBoas, int maiorQuantidadeFabrica, int maiorQuantidadeCentro, Tabuleiro tabuleiro)
        {
            
            List<Jogada> jogadasMaiorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
        
            //procura a maior quantidade entre as jogadas
            jogadasMaiorQuantidade = jogadas.FindAll(jogada => (jogada.quantidade == maiorQuantidadeFabrica && jogada.IdFabrica != 0) || (jogada.quantidade == maiorQuantidadeCentro && jogada.IdFabrica == 0 && 0 < maiorQuantidadeCentro && maiorQuantidadeCentro <= 5));
            
            //prucura uma linha vazia que caiba a maiorquantidade
            linha linhaVaziaFabricas = linhasVazias.Find(linha => linha.posicao == maiorQuantidadeFabrica);

            if (linhaVaziaFabricas.posicao > 0)
            {

                //percorre todas as jogadas de maior quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
                for (int i = 0; i < jogadasMaiorQuantidade.Count; i++)
                {

                    //realiza a configuração da compra
                    if (!tabuleiro.verificarAzulejoParede(jogadasMaiorQuantidade[i].id, linhaVaziaFabricas.posicao - 1, tabuleiro))
                    {
                        Compra compra = new Compra();
                        compra.id = jogadasMaiorQuantidade[i].id;
                        compra.quantidade = jogadasMaiorQuantidade[i].quantidade;
                        compra.IdFabrica = jogadasMaiorQuantidade[i].IdFabrica;
                        compra.Local = "F";
                        compra.LinhaModelo = linhaVaziaFabricas.posicao;
                        compra.Fonte = "MaiorModelo";
                        compras.Add(compra);
                    }
                }
            }

            return compras;
        }
        public static List<Compra> MenorModelo(List<linha> linhasVazias, List<Jogada> jogadas, List<Jogada> jogadasBoas, int menorQuantidadeFabrica, int menorQuantidadeCentro, Tabuleiro tabuleiro)
        {

            List<Jogada> jogadasMenorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();

            //procura a menor quantidade entre as jogadas
            jogadasMenorQuantidade = jogadas.FindAll(jogada => (jogada.quantidade == menorQuantidadeFabrica && jogada.IdFabrica != 0) || (jogada.quantidade == menorQuantidadeFabrica && jogada.IdFabrica == 0 && 0 < menorQuantidadeFabrica && menorQuantidadeFabrica <= 5));

            //prucura uma linha vazia que caiba a menor quantidade
            linha linhaVaziaFabricas = linhasVazias.Find(linha => linha.posicao == menorQuantidadeFabrica);

            if (linhaVaziaFabricas.posicao > 0)
            {

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
                        compra.Fonte = "MenorModelo";
                        compras.Add(compra);
                    }
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
                // Para cada linha já preenchida do modelo, procura todas as jogadas 
                // possíveis tanto do centro como das fábricas que não resultam em azulejos no chão.

                jogadasBoas = jogadas.FindAll(jogada => jogada.quantidade < linha.posicao && jogada.IdFabrica > 0 && jogada.id == linha.azulejo.id);
                foreach (Jogada jogadaBoa in jogadasBoas)
                {
                    // Cada jogada encontrada é transformada numa compra e adicionada na lista.
                    Compra compra = new Compra
                    {
                        id = jogadaBoa.id,
                        IdFabrica = jogadaBoa.IdFabrica,
                        quantidade = jogadaBoa.quantidade,
                        LinhaModelo = linha.posicao,
                        Local = "F",
                        Fonte = "PreencheComFabrica"
                    };
                    compras.Add(compra);
                }
            }

            return compras;
        }
        public static List<Compra> PreencheComCentro(List<Jogada> jogadas, linha[] linhasPreenchidas, Tabuleiro tabuleiro)
        {
            List<Jogada> jogadasBoas = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
                           
            foreach (linha linha in linhasPreenchidas)
            {
                // Para cada linha já preenchida do modelo, procura todas as jogadas 
                // possíveis tanto do centro como das fábricas que não resultam em azulejos no chão.

                jogadasBoas = jogadas.FindAll(jogada => jogada.quantidade < linha.posicao && jogada.id == linha.azulejo.id);
                foreach (Jogada jogadaBoa in jogadasBoas)
                {
                    // Cada jogada encontrada é transformada numa compra e adicionada na lista.
                    Compra compra = new Compra
                    {
                        id = jogadaBoa.id,
                        IdFabrica = 0,
                        quantidade = jogadaBoa.quantidade,
                        LinhaModelo = linha.posicao,
                        Local = "C",
                        Fonte = "PreencheComCentro"
                    };
                    compras.Add(compra);
                }
            }

            return compras;
        }
        public static List<Compra> MenorCentro(List<linha> linhasVazias, List<Jogada> jogadas, int menorQuantidadeCentro, Tabuleiro tabuleiro)
        {
            List<Jogada> jogadasMenorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            List<linha> listaAux = linhasVazias.FindAll(linha => linha.posicao >= menorQuantidadeCentro);
            int linhaModelo = 0;


            if (listaAux.Count > 0) {
                jogadasMenorQuantidade = jogadas.FindAll(jogada => jogada.quantidade == menorQuantidadeCentro && jogada.IdFabrica == 0 && 0 < menorQuantidadeCentro);

                //percorre as linhas do modelo procurando uma linha onde possa colocar a menor quantidade do centro
                int i = 0;
                //while (i != 4 && linhasVazias[i].posicao <= menorQuantidadeCentro)
                //{
                //    linhaModelo = linhasVazias[i].posicao;
                //    i++;
                //}

                linhaModelo = listaAux[listaAux.Count - 1].posicao;

                if (tabuleiro.verificaModelo(tabuleiro, linhaModelo)) { 
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
                            compra.Fonte = "MenorCentro";
                            compras.Add(compra);
                        }
                    }
                }
                //percorre todas as jogadas de menor quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
            }

            
            //procura a menor quantidade entre as jogadas

            return compras;
        }
        public static List<Compra> MaiorCentro(List<linha> linhasVazias, List<Jogada> jogadas, int maiorQuantidadeCentro, Tabuleiro tabuleiro)
        {
            List<Jogada> jogadasMaiorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            List<linha> listaAux = linhasVazias.FindAll(linha => linha.posicao <= maiorQuantidadeCentro);
            int linhaModelo = 0;

            if (listaAux.Count > 0) {
                //procura a maior quantidade entre as jogadas
                jogadasMaiorQuantidade = jogadas.FindAll(jogada => jogada.quantidade == maiorQuantidadeCentro && jogada.IdFabrica == 0 && 0 < maiorQuantidadeCentro);

                //percorre as linhas do modelo procurando uma linha onde possa colocar a maior quantidade do centro
                int i = 0;
                //while (i != 4 && linhasVazias[i].posicao <= maiorQuantidadeCentro)
                //{
                //    linhaModelo = linhasVazias[i].posicao;
                //    i++;
                //}

                linhaModelo = listaAux[listaAux.Count - 1].posicao;

                if (tabuleiro.verificaModelo(tabuleiro, linhaModelo)) { 
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
                            compra.Fonte = "MaiorCentro";
                            compras.Add(compra);
                        }
                    }
                }
                //percorre todas as jogadas de maior quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
            }
           
            return compras;
        }
    }
}
