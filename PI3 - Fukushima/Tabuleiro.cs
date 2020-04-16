﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace PI3___Fukushima
{
    class Tabuleiro
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
            tabuleiro.modelo.arrayAzulejos = new Azulejo[5];
            i = modelo.listarModelo(geral);

            i++;

            while (geral[i] != "chão")
            {
                tabuleiro.parede[Convert.ToInt32(geral[i].Substring(0, 1)) - 1, Convert.ToInt32(geral[i].Substring(2, 1)) - 1] = true;
                i++;
            }

            i++;
            j = i;

            while (geral[i] != "")
            {
                tabuleiro.chao[i - j] = Convert.ToInt32(geral[i].Substring(2, 1));
                i++;
            }
        }
    }
}
