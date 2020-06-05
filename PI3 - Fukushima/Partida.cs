using System;
using System.Collections.Generic;
using AzulServer;

namespace PI3___Fukushima
{
    class Partida
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Status { get; set; }

        public string DataCriacao { get; set; }

        public static List<Partida> listarPartidas() {
            List<Partida> partidas = new List<Partida>();
            

            string retorno = Jogo.ListarPartidas("T").Replace("\r", "");

            string[] partidasRetorno = retorno.Split('\n');

            
            for(int i = 0; i < partidasRetorno.Length && partidasRetorno[i] != ""; i++) {
                string[] itens = partidasRetorno[i].Split(',');

                Partida partida = new Partida();
                partida.Id = Convert.ToInt32(itens[0]);
                partida.Nome = itens[1];
                partida.DataCriacao = itens[2];
                partida.Status = itens[3];

                partidas.Add(partida);
            }

            return partidas;
        }

        public static List<Jogador> ListarJogadores(int id)
        {
            List<Jogador> jogadores = new List<Jogador>();

            string retorno = Jogo.ListarJogadores(id).Replace("\r", "");
            string[] jogadoresRetorno = retorno.Split('\n');

            for (int i = 0; i < jogadoresRetorno.Length && jogadoresRetorno[i] != ""; i++){
                string[] itens = jogadoresRetorno[i].Split(',');

                Jogador jogador = new Jogador
                {
                    Id = Convert.ToInt32(itens[0]),
                    Nome = itens[1],
                    Score = Convert.ToInt32(itens[2])
                };

                jogadores.Add(jogador);
            }

            return jogadores;
        }
    }
}
