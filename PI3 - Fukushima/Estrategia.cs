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
            
            if (menorQuantidadeCentro < menorQuantidadeFabrica || jogadas.All(jogada => jogada.IdFabrica == 0))
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
            linha linhaVaziaFabricas = new linha(-1, null);

            //procura a maior quantidade entre as jogadas
            jogadasMaiorQuantidade = jogadas.FindAll(jogada => jogada.quantidade == maiorQuantidadeFabrica && jogada.IdFabrica != 0);

            //prucura uma linha vazia que caiba a maiorquantidade
            //linhaVaziaFabricas = linhasVazias.Find(linha => linha.posicao + 1>= maiorQuantidadeFabrica);

            foreach (linha linha1 in linhasVazias)
            {
                if (linha1.posicao + 1 >= maiorQuantidadeFabrica) {
                    linhaVaziaFabricas = linha1;
                    break;
                }
            }

            if (linhaVaziaFabricas.posicao > -1 && tabuleiro.verificaModelo(tabuleiro, linhaVaziaFabricas.posicao))
            {

                //percorre todas as jogadas de maior quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
                for (int i = 0; i < jogadasMaiorQuantidade.Count; i++)
                {

                    //realiza a configuração da compra
                    if (!tabuleiro.verificarAzulejoParede(jogadasMaiorQuantidade[i].id, linhaVaziaFabricas.posicao, tabuleiro))
                    {
                        Compra compra = new Compra();
                        compra.id = jogadasMaiorQuantidade[i].id;
                        compra.quantidade = jogadasMaiorQuantidade[i].quantidade;
                        compra.IdFabrica = jogadasMaiorQuantidade[i].IdFabrica;
                        compra.Local = "F";
                        compra.LinhaModelo = linhaVaziaFabricas.posicao + 1;
                        compra.Fonte = "MaiorModelo";
                        compra.Prioridade = tabuleiro.verificarAdjacentes(compra.id, compra.LinhaModelo, tabuleiro);
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
            linha linhaVaziaFabricas = new linha(-1, null);

            //procura a menor quantidade entre as jogadas
            jogadasMenorQuantidade = jogadas.FindAll(jogada => jogada.quantidade == menorQuantidadeFabrica && jogada.IdFabrica != 0);

            //prucura uma linha vazia que caiba a menor quantidade
            //linha linhaVaziaFabricas = linhasVazias.Find(linha => linha.posicao + 1 >= menorQuantidadeFabrica);

            foreach (linha linha1 in linhasVazias)
            {
                if (linha1.posicao + 1 >= menorQuantidadeFabrica)
                {
                    linhaVaziaFabricas = linha1;

                    break;
                }
            }

            if (linhaVaziaFabricas.posicao > -1 && tabuleiro.verificaModelo(tabuleiro, linhaVaziaFabricas.posicao))
            {

                //percorre todas as jogadas de menor quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
                for (int i = 0; i < jogadasMenorQuantidade.Count; i++)
                {

                    //realiza a configuração da compra
                    if (!tabuleiro.verificarAzulejoParede(jogadasMenorQuantidade[i].id, linhaVaziaFabricas.posicao, tabuleiro))
                    {
                        Compra compra = new Compra();
                        compra.id = jogadasMenorQuantidade[i].id;
                        compra.quantidade = jogadasMenorQuantidade[i].quantidade;
                        compra.IdFabrica = jogadasMenorQuantidade[i].IdFabrica;
                        compra.Local = "F";
                        compra.LinhaModelo = linhaVaziaFabricas.posicao + 1;
                        compra.Fonte = "MenorModelo";
                        compra.Prioridade = tabuleiro.verificarAdjacentes(compra.id, compra.LinhaModelo, tabuleiro);
                        compras.Add(compra);
                    }
                }
            }

            return compras;
        }
        public static List<Compra> PreencheComFabrica(List<Jogada> jogadas, linha[] linhasPreenchidas, Tabuleiro tabuleiro, bool forcar)
        {
            List<Jogada> jogadasBoas = new List<Jogada>();
            List<Compra> compras = new List<Compra>();

            foreach (linha linha in linhasPreenchidas)
            {
                // Para cada linha já preenchida do modelo, procura todas as jogadas 
                // possíveis tanto do centro como das fábricas que não resultam em azulejos no chão.

                if (forcar)
                {
                    jogadasBoas = jogadas.FindAll(jogada => jogada.quantidade > 0 && linha.azulejo.quantidade != linha.posicao + 1 && jogada.IdFabrica > 0 && jogada.id == linha.azulejo.id);
                }
                else
                {
                    jogadasBoas = jogadas.FindAll(jogada => jogada.quantidade <= (linha.posicao + 1 - linha.azulejo.quantidade) && jogada.quantidade > 0 && jogada.IdFabrica > 0 && jogada.id == linha.azulejo.id);
                }

                foreach (Jogada jogadaBoa in jogadasBoas)
                {
                    // Cada jogada encontrada é transformada numa compra e adicionada na lista.
                    Compra compra = new Compra();

                    compra.id = jogadaBoa.id;
                    compra.IdFabrica = jogadaBoa.IdFabrica;
                    compra.quantidade = jogadaBoa.quantidade;
                    compra.LinhaModelo = linha.posicao + 1;
                    compra.Local = "F";
                    compra.Fonte = "PreencheComFabrica";
                    compra.Prioridade = tabuleiro.verificarAdjacentes(compra.id, compra.LinhaModelo, tabuleiro);

                    compras.Add(compra);
                }
            }

            return compras;
        }
        public static List<Compra> PreencheComCentro(List<Jogada> jogadas, linha[] linhasPreenchidas, Tabuleiro tabuleiro, bool forcar)
        {
            List<Jogada> jogadasBoas = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
                           
            foreach (linha linha in linhasPreenchidas)
            {
                // Para cada linha já preenchida do modelo, procura todas as jogadas 
                // possíveis tanto do centro como das fábricas que não resultam em azulejos no chão.

                if (forcar)
                {
                    jogadasBoas = jogadas.FindAll(jogada => jogada.quantidade > 0 && linha.azulejo.quantidade != linha.posicao + 1 && jogada.IdFabrica == 0 && jogada.id == linha.azulejo.id);        
                }
                else
                {
                    jogadasBoas = jogadas.FindAll(jogada => jogada.quantidade <= (linha.posicao + 1 - linha.azulejo.quantidade) && jogada.quantidade > 0 && jogada.IdFabrica == 0 && jogada.id == linha.azulejo.id);
                }

                foreach (Jogada jogadaBoa in jogadasBoas)
                {
                    // Cada jogada encontrada é transformada numa compra e adicionada na lista.
                    Compra compra = new Compra();
                    compra.id = jogadaBoa.id;
                    compra.IdFabrica = 0;
                    compra.quantidade = jogadaBoa.quantidade;
                    compra.LinhaModelo = linha.posicao + 1;
                    compra.Local = "C";
                    compra.Fonte = "PreencheComCentro";
                    compra.Prioridade = tabuleiro.verificarAdjacentes(compra.id, compra.LinhaModelo, tabuleiro);

                    compras.Add(compra);
                }
            }

            return compras;
        }

        public static List<Compra> asdPreencheComFabrica(List<Jogada> jogadas, linha[] linhasPreenchidas, Tabuleiro tabuleiro)
        {
            List<Jogada> jogadasBoas = new List<Jogada>();
            List<Compra> compras = new List<Compra>();

            foreach (linha linha in linhasPreenchidas)
            {
                // Para cada linha já preenchida do modelo, procura todas as jogadas 
                // possíveis tanto do centro como das fábricas que não resultam em azulejos no chão.

                jogadasBoas = jogadas.FindAll(jogada => jogada.quantidade <= (linha.posicao + 1 - linha.azulejo.quantidade) && jogada.quantidade > 0 && jogada.IdFabrica > 0 && jogada.id == linha.azulejo.id);
                foreach (Jogada jogadaBoa in jogadasBoas)
                {
                    // Cada jogada encontrada é transformada numa compra e adicionada na lista.
                    Compra compra = new Compra();
                    compra.id = jogadaBoa.id;
                    compra.IdFabrica = jogadaBoa.IdFabrica;
                    compra.quantidade = jogadaBoa.quantidade;
                    compra.LinhaModelo = linha.posicao + 1;
                    compra.Local = "F";
                    compra.Fonte = "PreencheComFabrica";
                    compra.Prioridade = tabuleiro.verificarAdjacentes(compra.id, compra.LinhaModelo, tabuleiro);

                    compras.Add(compra);
                }
            }

            return compras;
        }

        public static List<Compra> MenorCentro(List<linha> linhasVazias, List<Jogada> jogadas, int menorQuantidadeCentro, Tabuleiro tabuleiro)
        {
            List<Jogada> jogadasMenorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            List<linha> listaAux = linhasVazias.FindAll(linha => linha.posicao + 1 >= menorQuantidadeCentro);
            int linhaModelo = 0;

            if (listaAux.Count > 0)
            {
                //procura a menor quantidade entre as jogadas
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
                        if (!tabuleiro.verificarAzulejoParede(jogadasMenorQuantidade[i].id, linhaModelo, tabuleiro))
                        {
                            Compra compra = new Compra();
                            compra.id = jogadasMenorQuantidade[i].id;
                            compra.quantidade = jogadasMenorQuantidade[i].quantidade;
                            compra.IdFabrica = jogadasMenorQuantidade[i].IdFabrica;
                            compra.Local = "C";
                            compra.LinhaModelo = linhaModelo + 1;
                            compra.Fonte = "MenorCentro";
                            compra.Prioridade = tabuleiro.verificarAdjacentes(compra.id, compra.LinhaModelo, tabuleiro);

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
            List<linha> listaAux = linhasVazias.FindAll(linha => linha.posicao + 1 >= maiorQuantidadeCentro);
            int linhaModelo = 0;

            if (listaAux.Count > 0)
            {
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
                        if (!tabuleiro.verificarAzulejoParede(jogadasMaiorQuantidade[i].id, linhaModelo, tabuleiro))
                        {
                            Compra compra = new Compra();
                            compra.id = jogadasMaiorQuantidade[i].id;
                            compra.quantidade = jogadasMaiorQuantidade[i].quantidade;
                            compra.IdFabrica = jogadasMaiorQuantidade[i].IdFabrica;
                            compra.Local = "C";
                            compra.LinhaModelo = linhaModelo + 1;
                            compra.Fonte = "MaiorCentro";
                            compra.Prioridade = tabuleiro.verificarAdjacentes(compra.id, compra.LinhaModelo, tabuleiro);

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
