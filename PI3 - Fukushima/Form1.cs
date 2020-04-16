using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;


namespace PI3___Fukushima
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer timer;
        string[] dadosJogador;
        int nJogadores;

        public Form1()
        {            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            lblVersaoDll.Text = "Versao DLL: " + Jogo.Versao;
            lblFeedback.Text = "";
            lblTimer.Text = "Timer ativado";

            timer = new System.Timers.Timer(2000);
            timer.Elapsed += timerTick;
            timer.AutoReset = true;
            timer.Start();
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

            txtDebug.Text = retorno;

            dadosJogador = retorno.Split(',');

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Users.txt", true))
            {
                file.WriteLine(txtIdEntrarPartida.Text + " " + txtSenhaEntrarPartida.Text + " - " + retorno);
            }
        }

        delegate void refreshListCallback();
        private void refreshList()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lstSala.InvokeRequired)
            {
                refreshListCallback d = new refreshListCallback(refreshList);
                this.Invoke(d, new object[] { });
            }
            else
            {
                lstSala.Items.Clear();

                if (!txtIdEntrarPartida.Text.Equals(""))
                {
                    foreach (Jogador jogador in Partida.listarJogadores(Convert.ToInt32(txtIdEntrarPartida.Text)))
                    {
                        lstSala.Items.Add(jogador.id + ", " + jogador.nome + ", " + jogador.score);
                    }
                }

                if (lstSala.Items.Count == 4)
                {
                    timer.Stop();
                    lblTimer.Text = "Timer desativado";
                }
            }
        }

        private void countPlayers() {
            nJogadores = lstSala.Items.Count;
            if (nJogadores < 2) {
                nJogadores = 2;
            }
        }

        private void timerTick(Object source, ElapsedEventArgs e)
        {
            refreshList();
            countPlayers();
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
            string[] dados = txtDebug.Text.Split(',');

            timer.Stop();
            frmPartida frmPartida = new frmPartida(dados, txtIdEntrarPartida.Text, "", nJogadores);
            this.AddOwnedForm(frmPartida);
            
            frmPartida.ShowDialog();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Jogo.IniciarPartida(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);

            timer.Stop();

            frmPartida frmPartida = new frmPartida(dadosJogador, txtIdEntrarPartida.Text, txtStatusEntrarPartida.Text, nJogadores);
            frmPartida.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }

        private void txtIdEntrarPartida_TextChanged(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
