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
            lblFeedback.Text = lblFabricas.Text = "";
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

            if (rdoDebugN.Checked)
            {
                retorno = Jogo.LerFabricas(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);
            }
            else {
                retorno = Jogo.LerFabricas(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text);
            }

            lblFabricas.Text = retorno;
        }

        private void frmPartida_Load(object sender, EventArgs e)
        {
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            lblFeedback.Text = Jogo.IniciarPartida(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);
            txtStatusPartida.Text = "Jogando";
        }

        private void frmPartida_Activated(object sender, EventArgs e)
        {
        }

        private void cboFabricas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblFabricas.Text = "";
        }
    }
}

/*
sala id 92
senha b

jogador id 109
jogador senha 5024C1   
*/
