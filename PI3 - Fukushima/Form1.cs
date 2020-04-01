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
            lblFeedback.Text = "";
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            List<Partida> partidas = Partida.listarPartidas();

            cboPartidas.Items.Clear();
            
            //foreach (Partida partida in partidas) {
            //    cboPartidas.Items.Add(partida.nome);
            //
            //}

            foreach (Partida partida in partidas)
            {
                cboPartidas.Items.Add(partida.id + "," + partida.nome + "," + partida.dataCriacao + "," + partida.status);
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.EntrarPartida(Convert.ToInt32(txtIdEntrarPartida.Text), txtNomeJogadorEntrar.Text, txtSenhaEntrarPartida.Text);

            if (verificarErro(retorno)) {
                return;
            }

            frmPartida frmPartida = new frmPartida(retorno, txtIdEntrarPartida.Text, txtStatusEntrarPartida.Text);
            frmPartida.ShowDialog();
        }

        private void cboPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] itens = cboPartidas.SelectedItem.ToString().Split(',');
            txtIdEntrarPartida.Text = itens[0];
            txtStatusEntrarPartida.Text = (itens[3] == "J") ? "Jogando" : "Aberta";
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            if (txtNomeCriarPartida.Text == "") {
               MessageBox.Show("ERRO: Campo NOME está vazio", "ERRO");
                return;
            }
            if (txtSenhaCriarPartida.Text == "") { 
               MessageBox.Show("ERRO: Campo SENHA está vazio", "ERRO");
                return;
            }
            
            string retorno = Jogo.CriarPartida(txtNomeCriarPartida.Text, txtSenhaCriarPartida.Text);
            verificarErro(retorno);
        }

        public bool verificarErro(string retorno) {
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

        private void button1_Click(object sender, EventArgs e)
        {
            string dados = "100,19422f";
            
            frmPartida frmPartida = new frmPartida(dados, txtIdEntrarPartida.Text, "");
            frmPartida.ShowDialog();
        }
    }
}
