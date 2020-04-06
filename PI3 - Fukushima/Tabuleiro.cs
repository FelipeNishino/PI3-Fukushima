using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzulServer;

namespace PI3___Fukushima
{
    class Tabuleiro
    {
        public int pontos { get; set; }

        bool[,] parede = new bool[5, 5];

        Azulejo[] modelo = new Azulejo[5];

        //public int chao;

        public void Listar(int idJogador, String senhaJogador)
        {
            String[] geral;
            String[] modelo;

            String retorno = Jogo.LerTabuleiro(idJogador, senhaJogador, idJogador);
            retorno = retorno.Replace("\r", "");
            geral = retorno.Split('\n');

            for(int i = 0; geral[i] != "parede"; i++)
            {
                modelo.Append<String>(geral[i]);
            }
        }

    }
}
