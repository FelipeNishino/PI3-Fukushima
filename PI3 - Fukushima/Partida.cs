using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzulServer;

namespace PI3___Fukushima
{
    class Partida
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string status { get; set; }

        public string dataCriacao { get; set; }

        public static List<Partida> listarPartidas() {
            List<Partida> partidas = new List<Partida>();
            

            string retorno = Jogo.ListarPartidas("T").Replace("\r", "");

            string[] partidasRetorno = retorno.Split('\n');

            
            for(int i = 0; i < partidasRetorno.Length && partidasRetorno[i] != ""; i++) {
                string[] itens = partidasRetorno[i].Split(',');

                Partida partida = new Partida();
                partida.id = Convert.ToInt32(itens[0]);
                partida.nome = itens[1];
                partida.dataCriacao = itens[2];
                partida.status = itens[3];

                partidas.Add(partida);
            }

            return partidas;
        }

        public static List<Jogador> listarJogadores(int id)
        {
            List<Jogador> jogadores = new List<Jogador>();

            string retorno = Jogo.ListarJogadores(id).Replace("\r", "");
            string[] jogadoresRetorno = retorno.Split('\n');

            for (int i = 0; i < jogadoresRetorno.Length && jogadoresRetorno[i] != ""; i++){
                string[] itens = jogadoresRetorno[i].Split(',');

                Jogador jogador = new Jogador();
                jogador.id = Convert.ToInt32(itens[0]);
                jogador.nome = itens[1];
                jogador.score = Convert.ToInt32(itens[2]);

                jogadores.Add(jogador);
            }

            return jogadores;
        }
    }
}
