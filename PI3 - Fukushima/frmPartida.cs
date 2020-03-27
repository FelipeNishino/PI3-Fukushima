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
            
            if (rdoDebugN.Checked)
            {
                retorno = Jogo.LerFabricas(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);
            }
            else {
                retorno = Jogo.LerFabricas(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text);
            }

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

            if (rdoDebugN.Checked)
            {
                retorno = Jogo.LerCentro(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);
            }
            else
            {
                retorno = Jogo.LerCentro(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text);
            }

            retorno = retorno.Replace("\r", "");

            azulejosCentro = retorno.Split('\n');

            lstAzulejosCentro.Items.Clear();

            foreach (string azulejo in azulejosCentro) {
                lstAzulejosCentro.Items.Add(azulejo);
            }
        }
    }
}

/*
sala id 15
senha 123

jogador id 27
jogador senha 3CEC0B   
*/
