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
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblVersaoDll.Text = "Versao DLL: " + Jogo.Versao;
        }



        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T").Replace("\r", "");

            string[] partidas = retorno.Split('\n');

            cboPartidas.Items.Clear();
            
            foreach (string partida in partidas) {
                cboPartidas.Items.Add(partida);
            }
            
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            if (txtIdPartida.Text == "") { 
               MessageBox.Show("ERRO: Campo ID está vazio", "ERRO");
            }
            if (txtNomePartida.Text == "") { 
               MessageBox.Show("ERRO: Campo NOME está vazio", "ERRO");
            }
            if (txtSenhaPartida.Text == "")
            {
                MessageBox.Show("ERRO: Campo SENHA está vazio", "ERRO");
            }

            if (txtStatusPartida.Text == "Jogando") { 
                MessageBox.Show("ERRO: Partida com o status de JOGANDO, não será possivel conectar", "ERRO");
            }

            Jogo.EntrarPartida(Int32.Parse(txtIdPartida.Text), txtNomePartida.Text, txtSenhaPartida.Text);
        }

        private void cboPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] itens = cboPartidas.SelectedItem.ToString().Split(',');
            txtIdPartida.Text = itens[0];
            txtNomePartida.Text = itens[1];
            txtStatusPartida.Text = (itens[3] == "J") ? "Jogando" : "Aberta";
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            //Jogo.CriarPartida()
        }
    }
}
