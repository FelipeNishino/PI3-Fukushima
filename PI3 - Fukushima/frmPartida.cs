using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace PI3___Fukushima
{
    public partial class frmPartida : Form
    {
        string[] dadosJogador;
        int idPartida;
        string statusPartida;

        public frmPartida(string _dadosJogador, string _idPartida, string _statusPartida) 
        {
            dadosJogador = _dadosJogador.Split(',');

            idPartida = Convert.ToInt32(_idPartida);
            statusPartida = _statusPartida;

            InitializeComponent();

            txtStatusPartida.Text = statusPartida;
            lblFeedback.Text = "";
            lblTabuleiro.Text = "";
        } 

        private void btnListarJogadoresPartida_Click(object sender, EventArgs e)
        {
            lstListaJogadores.Items.Clear();

            foreach (Jogador jogador in Partida.listarJogadores(idPartida))
            {
                lstListaJogadores.Items.Add(jogador.id + ", " + jogador.nome + ", " + jogador.score);
            }
        }

        private void btnListarFabricas_Click(object sender, EventArgs e)
        {
            string retorno;
            string[] fabricas;
            
            retorno = Jogo.LerFabricas(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);
            retorno = retorno.Replace("\r", "");
            fabricas = retorno.Split('\n');

            lstAzulejosFabricas.Items.Clear();

            foreach (string fabrica in fabricas) {
                lstAzulejosFabricas.Items.Add(fabrica);
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            lblFeedback.Text = Jogo.IniciarPartida(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);
            txtStatusPartida.Text = "Jogando";
        }

        private void btnListarCentro_Click(object sender, EventArgs e)
        {
            string retorno;
            string[] azulejosCentro;

            retorno = Jogo.LerCentro(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);

            verificarErro(retorno);

            
            retorno = retorno.Replace("\r", "");

            azulejosCentro = retorno.Split('\n');

            lstAzulejosCentro.Items.Clear();

            foreach (string azulejo in azulejosCentro) {
                lstAzulejosCentro.Items.Add(azulejo);
            }
        }

        private void btnComprarAzulejo_Click(object sender, EventArgs e)
        {
            string retorno;
            string centro;

            if (cboFabricasCompra.SelectedItem.ToString() == "Centro")
            {
                centro = "C";
            }
            else 
            {
                centro = "F";
            }   
            retorno = Jogo.Jogar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], centro, (cboFabricasCompra.SelectedItem.ToString() == "Centro")? 0 : Convert.ToInt32(cboFabricasCompra.SelectedItem), Convert.ToInt32(cboAzulejoCompra.SelectedItem), Convert.ToInt32(cboModeloCompra.SelectedItem));
            verificarErro(retorno); 
        }  

        public bool verificarErro(string retorno)
        {
            lblFeedback.Text = retorno;

            if (retorno.Length > 4)
            {
                if (retorno.Substring(0, 4) == "ERRO")
                {
                    MessageBox.Show(retorno);
                    return true;
                }
            }
            return false;
        }

        private void btnTabuleiro_Click(object sender, EventArgs e)
        {
            lblTabuleiro.Text = Jogo.LerTabuleiro(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], Convert.ToInt32(dadosJogador[0])); 
        }
    }
}

/*
sala id 54
senha fukushima

jogador id 100
jogador senha 19422f   
*/
