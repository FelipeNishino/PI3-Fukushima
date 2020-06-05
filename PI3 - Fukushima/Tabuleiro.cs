using System;
using AzulServer;

namespace PI3___Fukushima
{
    public class Tabuleiro
    {
        public bool[,] Parede = new bool[5, 5];

        public Modelo Modelo { get; set; }

        public int[] chao = new int[] { -1, -1, -1, -1, -1, -1, -1 };

        public void Listar(int idJogador, String senhaJogador, Tabuleiro tabuleiro)
        {
            int i, j;
            String[] geral;
          
            String retorno = Jogo.LerTabuleiro(idJogador, senhaJogador, idJogador);
            retorno = retorno.Replace("\r", "");
            
            geral = retorno.Split('\n');
                        
            tabuleiro.Modelo = new Modelo();
            tabuleiro.Modelo.linhas = new Linha[5];

            for (int k = 0; k < 5; k++)
            {
                tabuleiro.Modelo.linhas[k] = new Linha(-1, null);
            }

            i = Modelo.ListarModelo(geral);

            i++;

            while (geral[i] != "chão")
            {
                tabuleiro.Parede[Convert.ToInt32(geral[i].Substring(0, 1)) - 1, Convert.ToInt32(geral[i].Substring(2, 1)) - 1] = true;
                i++;
            }

            i++;
            j = i;

            while (geral[i] != "" && i - j < tabuleiro.chao.Length)
            {
                tabuleiro.chao[i - j] = Convert.ToInt32(geral[i].Substring(2, 1));
                i++;
            }
        }

        public bool VerificaAzulejoParede(int idAzulejo, int linhaModelo, Tabuleiro tabuleiro) {
            return tabuleiro.Parede[linhaModelo, (linhaModelo + (idAzulejo - 1)) % 5];
        }
        public int VerificaPrioridades(int idAzulejo, int linhaModelo, Tabuleiro tabuleiro)
        {
            int i, j, coluna, linhaAux, colunaAux, prioridade, nAzulejos, nCor;
            prioridade = nAzulejos = nCor = 0;

            // transforma idAzulejo e linhaModelo pra base 0
            linhaModelo--;
            idAzulejo--;

            // Verifica os azulejos adjacentes que já estão preenchidos, incrementando a prioridade para cada um

            coluna = (linhaModelo + idAzulejo) % 5;

            j = 2;
            for (i = -1; i <= 2; ++i)
            {
                linhaAux = linhaModelo + (i % 2);
                colunaAux = coluna + (j % 2);

                if (linhaAux >= 0 && linhaAux <= 4 && colunaAux >= 0 && colunaAux <= 4)
                {
                    if (tabuleiro.Parede[linhaAux, colunaAux] == true)
                    {
                        prioridade++;
                    }
                }
                j--;
            }

            // Verifica quantos azulejos tem na mesma coluna e concede um bonus

            for (i = 0; i < 5; i++)
            {
                if (tabuleiro.Parede[i, coluna]) nAzulejos++;
                if (tabuleiro.Parede[i, (idAzulejo + i) % 5]) nCor++;
            }

            switch (nAzulejos)
            {
                case 3:
                    prioridade += 1;
                    break;
                case 4:
                    prioridade += 10;
                    break;
                default:                    
                    break;
            }

            // Se houverem quatro azulejos da mesma cor na parede, a compra que completaria a cor recebe a maior prioridade possível

            if (nCor == 4) prioridade += 100;

            // Dá prioridade a compras que preenchem a coluna central

            if (coluna == 2) prioridade++;

            return prioridade;
        } 

        public bool VerificaModelo(Tabuleiro tabuleiro, int linhaModelo) {        
            if(tabuleiro.Modelo.linhas[linhaModelo].azulejo.Id == -1) return true;

            return false;
        }
    }
}
