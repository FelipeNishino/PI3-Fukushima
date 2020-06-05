using System.Collections.Generic;
using System.Linq;

namespace PI3___Fukushima
{
    static class Estrategia
    {
        public static List<Compra> MenorFabrica(List<Jogada> jogadas, int menorQuantidadeFabrica, int menorQuantidadeCentro, Tabuleiro tabuleiro)
        {
            List<Jogada> jogadasBoas = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            
            if (menorQuantidadeCentro < menorQuantidadeFabrica || jogadas.All(jogada => jogada.IdFabrica == 0))
            {
                jogadasBoas = jogadas.FindAll(jogada => jogada.Quantidade == menorQuantidadeCentro);
            }
            else
            {
                jogadasBoas = jogadas.FindAll(jogada => jogada.Quantidade == menorQuantidadeFabrica);
            }

            foreach (Jogada jogadaBoa in jogadasBoas)
            {
                Compra compra = new Compra
                {
                    Id = jogadaBoa.Id,
                    IdFabrica = jogadaBoa.IdFabrica,
                    Quantidade = jogadaBoa.Quantidade,
                    LinhaModelo = 0,
                    Local = (jogadaBoa.IdFabrica == 0) ? "C" : "F",
                    Fonte = "MenorChao"
                };
                compras.Add(compra);
            }

            return compras;
        }
        public static List<Compra> MaiorFabrica(List<Linha> linhasVazias,List<Jogada> jogadas, List<Jogada> jogadasBoas, int maiorQuantidadeFabrica, int maiorQuantidadeCentro, Tabuleiro tabuleiro, bool forcar)
        {
            
            List<Jogada> jogadasMaiorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            Linha linhaVaziaFabricas = new Linha(-1, null);

            //procura a maior quantidade entre as jogadas
            jogadasMaiorQuantidade = jogadas.FindAll(jogada => jogada.Quantidade == maiorQuantidadeFabrica && jogada.IdFabrica != 0);

            //prucura uma linha vazia que caiba a maiorquantidade
            //linhaVaziaFabricas = linhasVazias.Find(linha => linha.posicao + 1>= maiorQuantidadeFabrica);

            foreach (Linha linha1 in linhasVazias)
            {
                if (!forcar)
                {
                    if (maiorQuantidadeFabrica >= linha1.posicao + 1 && maiorQuantidadeFabrica <= linha1.posicao + 2) {
                        linhaVaziaFabricas = linha1;
                        break;
                    }
                }
                else
                {
                    if (maiorQuantidadeFabrica <= linha1.posicao + 2)
                    {
                        linhaVaziaFabricas = linha1;
                        break;
                    }
                }
            }

            if (linhaVaziaFabricas.posicao > -1 && tabuleiro.VerificaModelo(tabuleiro, linhaVaziaFabricas.posicao))
            {

                //percorre todas as jogadas de maior quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
                for (int i = 0; i < jogadasMaiorQuantidade.Count; i++)
                {

                    //realiza a configuração da compra
                    if (!tabuleiro.VerificaAzulejoParede(jogadasMaiorQuantidade[i].Id, linhaVaziaFabricas.posicao, tabuleiro))
                    {
                        Compra compra = new Compra();
                        compra.Id = jogadasMaiorQuantidade[i].Id;
                        compra.Quantidade = jogadasMaiorQuantidade[i].Quantidade;
                        compra.IdFabrica = jogadasMaiorQuantidade[i].IdFabrica;
                        compra.Local = "F";
                        compra.LinhaModelo = linhaVaziaFabricas.posicao + 1;
                        compra.Fonte = "MaiorModelo";
                        if (compra.LinhaModelo - compra.Quantidade <= -2) compra.Prioridade--;
                        if (compra.Quantidade == compra.LinhaModelo) compra.Prioridade++;

                        compras.Add(compra);
                    }
                }
            }

            return compras;
        }
        public static List<Compra> MenorModelo(List<Linha> linhasVazias, List<Jogada> jogadas, List<Jogada> jogadasBoas, int menorQuantidadeFabrica, int menorQuantidadeCentro, Tabuleiro tabuleiro, bool forcar)
        {
            List<Jogada> jogadasMenorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            Linha linhaVaziaFabricas = new Linha(-1, null);

            //procura a menor quantidade entre as jogadas
            jogadasMenorQuantidade = jogadas.FindAll(jogada => jogada.Quantidade == menorQuantidadeFabrica && jogada.IdFabrica != 0);

            //prucura uma linha vazia que caiba a menor quantidade
            //linha linhaVaziaFabricas = linhasVazias.Find(linha => linha.posicao + 1 >= menorQuantidadeFabrica);

            foreach (Linha linha1 in linhasVazias)
            {
                if (!forcar)
                {
                    if (menorQuantidadeFabrica >= linha1.posicao + 1 && menorQuantidadeFabrica <= linha1.posicao + 2)
                    {
                        linhaVaziaFabricas = linha1;
                        break;
                    }
                }
                else
                {
                    if (menorQuantidadeFabrica <= linha1.posicao + 2)
                    {
                        linhaVaziaFabricas = linha1;
                        break;
                    }
                }
            }

            if (linhaVaziaFabricas.posicao > -1 && tabuleiro.VerificaModelo(tabuleiro, linhaVaziaFabricas.posicao))
            {

                //percorre todas as jogadas de menor quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
                for (int i = 0; i < jogadasMenorQuantidade.Count; i++)
                {

                    //realiza a configuração da compra
                    if (!tabuleiro.VerificaAzulejoParede(jogadasMenorQuantidade[i].Id, linhaVaziaFabricas.posicao, tabuleiro))
                    {
                        Compra compra = new Compra();
                        compra.Id = jogadasMenorQuantidade[i].Id;
                        compra.Quantidade = jogadasMenorQuantidade[i].Quantidade;
                        compra.IdFabrica = jogadasMenorQuantidade[i].IdFabrica;
                        compra.Local = "F";
                        compra.LinhaModelo = linhaVaziaFabricas.posicao + 1;
                        compra.Fonte = "MenorModelo";
                        if (compra.LinhaModelo - compra.Quantidade <= -2) compra.Prioridade--;
                        if (compra.Quantidade == compra.LinhaModelo) compra.Prioridade++;
                        compras.Add(compra);
                    }
                }
            }

            return compras;
        }
        public static List<Compra> PreencheComFabrica(List<Jogada> jogadas, Linha[] linhasPreenchidas, Tabuleiro tabuleiro, bool forcar)
        {
            List<Jogada> jogadasBoas = new List<Jogada>();
            List<Compra> compras = new List<Compra>();

            foreach (Linha linha in linhasPreenchidas)
            {
                // Para cada linha já preenchida do modelo, procura todas as jogadas 
                // possíveis tanto do centro como das fábricas que não resultam em azulejos no chão.

                if (forcar) jogadasBoas = jogadas.FindAll(jogada => jogada.Quantidade > 0 && linha.azulejo.Quantidade != linha.posicao + 1 && jogada.IdFabrica > 0 && jogada.Id == linha.azulejo.Id);
                else jogadasBoas = jogadas.FindAll(jogada => jogada.Quantidade <= (linha.posicao + 1 - linha.azulejo.Quantidade) && jogada.Quantidade > 0 && jogada.IdFabrica > 0 && jogada.Id == linha.azulejo.Id);
                
                foreach (Jogada jogadaBoa in jogadasBoas)
                {
                    // Cada jogada encontrada é transformada numa compra e adicionada na lista.
                    Compra compra = new Compra();

                    compra.Id = jogadaBoa.Id;
                    compra.IdFabrica = jogadaBoa.IdFabrica;
                    compra.Quantidade = jogadaBoa.Quantidade;
                    compra.LinhaModelo = linha.posicao + 1;
                    compra.Local = "F";
                    compra.Fonte = "PreencheComFabrica";
                    if (!forcar || compra.Quantidade == compra.LinhaModelo - linha.azulejo.Quantidade) compra.Prioridade++;
                    else if ((linha.posicao + 1) - (compra.Quantidade + linha.azulejo.Quantidade) < -1) compra.Prioridade--;
                    compras.Add(compra);
                }
            }

            return compras;
        }
        public static List<Compra> PreencheComCentro(List<Jogada> jogadas, Linha[] linhasPreenchidas, Tabuleiro tabuleiro, bool forcar)
        {
            List<Jogada> jogadasBoas = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
                           
            foreach (Linha linha in linhasPreenchidas)
            {
                // Para cada linha já preenchida do modelo, procura todas as jogadas 
                // possíveis tanto do centro como das fábricas que não resultam em azulejos no chão.

                if (forcar)
                {
                    jogadasBoas = jogadas.FindAll(jogada => jogada.Quantidade > 0 && linha.azulejo.Quantidade != linha.posicao + 1 && jogada.IdFabrica == 0 && jogada.Id == linha.azulejo.Id);        
                }
                else
                {
                    jogadasBoas = jogadas.FindAll(jogada => jogada.Quantidade <= (linha.posicao + 1 - linha.azulejo.Quantidade) && jogada.Quantidade > 0 && jogada.IdFabrica == 0 && jogada.Id == linha.azulejo.Id);
                }

                foreach (Jogada jogadaBoa in jogadasBoas)
                {
                    // Cada jogada encontrada é transformada numa compra e adicionada na lista.
                    Compra compra = new Compra();
                    compra.Id = jogadaBoa.Id;
                    compra.IdFabrica = 0;
                    compra.Quantidade = jogadaBoa.Quantidade;
                    compra.LinhaModelo = linha.posicao + 1;
                    compra.Local = "C";
                    compra.Fonte = "PreencheComCentro";
                    if (!forcar || compra.Quantidade == compra.LinhaModelo - linha.azulejo.Quantidade) compra.Prioridade++;
                    else if (linha.posicao + 1 - (compra.Quantidade + linha.azulejo.Quantidade) < -1) compra.Prioridade--;
                    compras.Add(compra);
                }
            }

            return compras;
        }

        public static List<Compra> MenorCentro(List<Linha> linhasVazias, List<Jogada> jogadas, int menorQuantidadeCentro, Tabuleiro tabuleiro, bool forcar)
        {
            List<Jogada> jogadasMenorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            List<Linha> listaAux = new List<Linha>();

            if (!forcar) listaAux = linhasVazias.FindAll(linha => menorQuantidadeCentro >= linha.posicao + 1 && menorQuantidadeCentro <= linha.posicao + 2);
            else listaAux = linhasVazias.FindAll(linha => menorQuantidadeCentro <= linha.posicao + 2);
         
            int linhaModelo = 0;

                if (listaAux.Count > 0)
            {
                //procura a menor quantidade entre as jogadas
                jogadasMenorQuantidade = jogadas.FindAll(jogada => jogada.Quantidade == menorQuantidadeCentro && jogada.IdFabrica == 0 && 0 < menorQuantidadeCentro);

                //percorre as linhas do modelo procurando uma linha onde possa colocar a menor quantidade do centro
                int i = 0;
                //while (i != 4 && linhasVazias[i].posicao <= menorQuantidadeCentro)
                //{
                //    linhaModelo = linhasVazias[i].posicao;
                //    i++;
                //}

                linhaModelo = listaAux[listaAux.Count - 1].posicao;

                if (tabuleiro.VerificaModelo(tabuleiro, linhaModelo)) { 
                    for (i = 0; i < jogadasMenorQuantidade.Count; i++)
                    {
                        if (!tabuleiro.VerificaAzulejoParede(jogadasMenorQuantidade[i].Id, linhaModelo, tabuleiro))
                        {
                            Compra compra = new Compra();
                            compra.Id = jogadasMenorQuantidade[i].Id;
                            compra.Quantidade = jogadasMenorQuantidade[i].Quantidade;
                            compra.IdFabrica = jogadasMenorQuantidade[i].IdFabrica;
                            compra.Local = "C";
                            compra.LinhaModelo = linhaModelo + 1;
                            compra.Fonte = "MenorCentro";
                            if (compra.LinhaModelo - compra.Quantidade <= -2) compra.Prioridade--;
                            if (compra.Quantidade == compra.LinhaModelo) compra.Prioridade++;
                            compras.Add(compra);
                        }
                    }
                }
                //percorre todas as jogadas de menor quantidade verificando se é possivel colocar um determinado azulejo em um determinado local no modelo
            }

            
            //procura a menor quantidade entre as jogadas

            return compras;
        }
        public static List<Compra> MaiorCentro(List<Linha> linhasVazias, List<Jogada> jogadas, int maiorQuantidadeCentro, Tabuleiro tabuleiro, bool forcar)
        {
            List<Jogada> jogadasMaiorQuantidade = new List<Jogada>();
            List<Compra> compras = new List<Compra>();
            List<Linha> listaAux = new List<Linha>();

            if (!forcar) listaAux = linhasVazias.FindAll(linha => maiorQuantidadeCentro >= linha.posicao + 1 && maiorQuantidadeCentro <= linha.posicao + 2);
            else listaAux = linhasVazias.FindAll(linha => maiorQuantidadeCentro <= linha.posicao + 2);

            int linhaModelo = 0;

            if (listaAux.Count > 0)
            {
                //procura a maior quantidade entre as jogadas
                jogadasMaiorQuantidade = jogadas.FindAll(jogada => jogada.Quantidade == maiorQuantidadeCentro && jogada.IdFabrica == 0 && 0 < maiorQuantidadeCentro);

                //percorre as linhas do modelo procurando uma linha onde possa colocar a maior quantidade do centro
                int i = 0;
                //while (i != 4 && linhasVazias[i].posicao <= maiorQuantidadeCentro)
                //{
                //    linhaModelo = linhasVazias[i].posicao;
                //    i++;
                //}

                linhaModelo = listaAux[listaAux.Count - 1].posicao;

                if (tabuleiro.VerificaModelo(tabuleiro, linhaModelo)) { 
                    for (i = 0; i < jogadasMaiorQuantidade.Count; i++)
                    {
                        if (!tabuleiro.VerificaAzulejoParede(jogadasMaiorQuantidade[i].Id, linhaModelo, tabuleiro))
                        {
                            Compra compra = new Compra();
                            compra.Id = jogadasMaiorQuantidade[i].Id;
                            compra.Quantidade = jogadasMaiorQuantidade[i].Quantidade;
                            compra.IdFabrica = jogadasMaiorQuantidade[i].IdFabrica;
                            compra.Local = "C";
                            compra.LinhaModelo = linhaModelo + 1;
                            compra.Fonte = "MaiorCentro";
                            if (compra.LinhaModelo - compra.Quantidade <= -2) compra.Prioridade--;
                            if (compra.Quantidade == compra.LinhaModelo) compra.Prioridade++;
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
