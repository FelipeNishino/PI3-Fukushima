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
using System.Diagnostics;

namespace PI3___Fukushima
{
    public partial class FrmLobby : Form
    {
        string[] dadosJogador;
        int nJogadores;

        public FrmLobby()
        {            
            InitializeComponent();
        }
        private void FrmLobby_Load(object sender, EventArgs e)
        {
            lblVersaoDll.Text = "Versao DLL: " + Jogo.Versao;
            lblFeedback.Text = "";
            Debug.Print((-1 % 2).ToString() + " " + (1 % 2).ToString());        
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            List<Partida> partidas = Partida.listarPartidas();

            cboPartidas.Items.Clear();
            
            foreach (Partida partida in partidas)
            {
                cboPartidas.Items.Add(partida.id + "," + partida.nome + "," + partida.dataCriacao + "," + partida.status);
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            if (
                isEmpty(txtEntrarId.Name.Replace("txtEntrar", ""), txtEntrarId.Text) ||
                isEmpty(txtEntrarSenha.Name.Replace("txtEntrar", ""), txtEntrarSenha.Text) ||
                isEmpty(txtEntrarNome.Name.Replace("txtEntrar", ""), txtEntrarNome.Text)            
            ) return;

            string retorno = Jogo.EntrarPartida(Convert.ToInt32(txtEntrarId.Text), txtEntrarNome.Text, txtEntrarSenha.Text);

            if (verificarErro(retorno)) {
                return;
            }

            cboDebug.Text = retorno;

            dadosJogador = retorno.Split(',');

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Users.txt", true))
            {
                file.WriteLine(txtEntrarId.Text + " " + txtEntrarSenha.Text + " - " + retorno);
            }
        }

        private void refreshList() {
            if (isEmpty(txtEntrarId.Name.Replace("txtEntrar", ""), txtEntrarId.Text)) return;

            lstSala.Items.Clear();

            foreach (Jogador jogador in Partida.listarJogadores(Convert.ToInt32(txtEntrarId.Text))){
                lstSala.Items.Add(jogador.id + ", " + jogador.nome + ", " + jogador.score);
            }
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            if (isEmpty(txtEntrarId.Name.Replace("txtEntrar", ""), txtEntrarId.Text)) return;

            refreshList();
            if (lstSala.Items.Count > 0) { 
                btnIniciarPartida.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void cboPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] itens = cboPartidas.SelectedItem.ToString().Split(',');
            txtEntrarId.Text = itens[0];
        }

        private bool isEmpty(string sender, string str) {
            if (str.Length == 0) {
                MessageBox.Show("ERRO: Campo " + sender.ToUpper() + " está vazio", "Fukushima - ERRO");
                return true;
            }
            return false;
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            if (
                isEmpty(txtCriarNome.Name.Replace("txtCriar", ""), txtCriarNome.Text) ||
                isEmpty(txtCriarSenha.Name.Replace("txtCriar", ""), txtCriarSenha.Text)          
            ) return;

            string retorno = Jogo.CriarPartida(txtCriarNome.Text, txtCriarSenha.Text);

            if (verificarErro(retorno)) return;

            btnListarPartidas.PerformClick();
            cboPartidas.SelectedIndex = cboPartidas.Items.Count - 1;
            txtEntrarSenha.Text = txtCriarSenha.Text;
        }

        public bool verificarErro(string str) {
            lblFeedback.Text = str;

            if (str.Length > 4) { 
                if (str.Substring(0, 4) == "ERRO") {
                    MessageBox.Show(str);
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (isEmpty("debug", cboDebug.Text)) return;
            
            string[] dados = cboDebug.Text.Split(',');

            if ((nJogadores = lstSala.Items.Count) < 2) nJogadores = 2;

            FrmPartida frmPartida = new FrmPartida(dados, txtEntrarId.Text, nJogadores, chkBot.Checked);
            this.AddOwnedForm(frmPartida);
            
            frmPartida.ShowDialog();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e) {
            btnListarPartidas.PerformClick();
            refreshList();

            string item = cboPartidas.Items[cboPartidas.FindString(txtEntrarId.Text)].ToString();

            if (item.Substring(item.LastIndexOf(",") + 1) == "A") Jogo.IniciarPartida(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);

            if ((nJogadores = lstSala.Items.Count) < 2) nJogadores = 2;

            FrmPartida frmPartida = new FrmPartida(dadosJogador, txtEntrarId.Text, nJogadores, chkBot.Checked);
            this.AddOwnedForm(frmPartida);
            frmPartida.ShowDialog();
        }

        private void cboDebug_DropDown(object sender, EventArgs e)
        {
            if (txtEntrarId.Text != "")
            {
                cboDebug.Items.Clear();
                string[] lines = System.IO.File.ReadAllLines(@"Users.txt");

                foreach (string line in lines)
                {
                    if (line.Length > 2)
                    {
                        if (line.Substring(0, line.IndexOf(" ")) == txtEntrarId.Text)
                        {
                            cboDebug.Items.Add(line.Substring(line.IndexOf("-") + 2));
                        }
                    }
                }
            }
        }

        private void cboDebug_SelectedIndexChanged(object sender, EventArgs e)
        {
            dadosJogador = cboDebug.Text.Split(',');
        }
    }
}
