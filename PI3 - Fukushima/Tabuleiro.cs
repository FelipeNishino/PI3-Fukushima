﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace PI3___Fukushima
{
    public class Tabuleiro
    {
        public int pontos { get; set; }

        public bool[,] parede = new bool[5, 5];

        public Modelo modelo { get; set; }

        public int[] chao = new int[] { -1, -1, -1, -1, -1, -1, -1 };

        public void Listar(int idJogador, String senhaJogador, Tabuleiro tabuleiro)
        {
            int i, j;
            String[] geral;
          
            String retorno = Jogo.LerTabuleiro(idJogador, senhaJogador, idJogador);
            retorno = retorno.Replace("\r", "");
            
            geral = retorno.Split('\n');
                        
            tabuleiro.modelo = new Modelo();
            tabuleiro.modelo.linhas = new linha[5];

            for (int k = 0; k < 5; k++)
            {
                tabuleiro.modelo.linhas[k] = new linha(-1, null);
            }

            i = modelo.listarModelo(geral);

            i++;

            while (geral[i] != "chão")
            {
                tabuleiro.parede[Convert.ToInt32(geral[i].Substring(0, 1)) - 1, Convert.ToInt32(geral[i].Substring(2, 1)) - 1] = true;
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

        public bool verificarAzulejoParede(int idAzulejo, int linhaModelo, Tabuleiro tabuleiro) {
            return tabuleiro.parede[linhaModelo, (linhaModelo + (idAzulejo - 1)) % 5];
        }

        public int verificarAdjacentes(int idAzulejo, int linhaModelo, Tabuleiro tabuleiro)
        {
            int i, j, x, y, xAux, yAux, adjacentes = 0;

            x = linhaModelo - 1;
            y = (linhaModelo - 1 + (idAzulejo - 1)) % 5;

            j = 2;
            for (i = -1; i <= 2; ++i)
            {
                xAux = x + (i % 2);
                yAux = y + (j % 2);

                if (xAux >= 0 && xAux <= 4 && yAux >= 0 && yAux <= 4)
                {
                    if (tabuleiro.parede[x + (i % 2), y + (j % 2)] == true)
                    {
                        adjacentes++;
                    }
                }
                j--;
            }

            return adjacentes;
        }

        public int verificarColuna(int idAzulejo, int linhaModelo, Tabuleiro tabuleiro)
        {
            int i, nAzulejos = 0;

            for (i = 0; i < 5; i++)
            {
                if (tabuleiro.parede[i, (linhaModelo - 1 + (idAzulejo - 1)) % 5]) nAzulejos++;
            }

            switch (nAzulejos)
            {
                case 3:
                    return 1;
                case 4:
                    return 10;
                default:
                    return 0;                   
            }
        }

        public int verificarCor(int idAzulejo, int linhaModelo, Tabuleiro tabuleiro)
        {
            int i, nAzulejos = 0;

            for (i = 0; i < 5; i++)
            {
                if (tabuleiro.parede[i, (idAzulejo - 1 + i) % 5]) nAzulejos++;
            }

            return (nAzulejos == 4) ? 100 : 0;
        }

        public bool verificaModelo(Tabuleiro tabuleiro, int linhaModelo) {        
            if(tabuleiro.modelo.linhas[linhaModelo].azulejo.id == -1) return true;

            return false;
        }
    }
}
