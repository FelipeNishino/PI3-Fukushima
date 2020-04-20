﻿using System;
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
    public partial class frmPartida : Form
    {
        private static System.Timers.Timer timer;
        string[] dadosJogador;
        int idPartida, nFabricas;
        string statusPartida;

        public frmPartida(string[] _dadosJogador, string _idPartida, string _statusPartida, int nJogadores) 
        {
            dadosJogador = _dadosJogador;
            idPartida = Convert.ToInt32(_idPartida);
            statusPartida = _statusPartida;
            nFabricas = nJogadores;

            InitializeComponent();
        } 

        private void frmPartida_Load(object sender, EventArgs e)
        {
            //this.Location = this.Owner.
            //Form1 frm1 = (Form1)Owner;
            //frm1 = Owner as frmPartida;

            this.Location = this.Owner.Location;

            txtStatusPartida.Text = statusPartida;
            lblFeedback.Text = "";
            lblTabuleiro.Text = "";
            lblDadosJogador.Text = dadosJogador[0] + "," + dadosJogador[1];

            nFabricas = 2 * nFabricas + 1;

            for (int i = 1; i <= nFabricas; i++)
            {
                cboFabricasCompra.Items.Add(i.ToString());
            }
            cboFabricasCompra.Items.Add("Centro");

            timer = new System.Timers.Timer(2000);
            timer.Elapsed += timerTick;
            timer.AutoReset = true;
            timer.Start();

            Owner.WindowState = FormWindowState.Minimized;

            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;

            frmTabuleiro frmTabuleiro = new frmTabuleiro(dadosJogador);
            this.AddOwnedForm(frmTabuleiro);
            frmTabuleiro.ControlBox = false;
            frmTabuleiro.Show();
        }

        delegate void timerTickCallback(Object source, ElapsedEventArgs e);
        
        private void timerTick(Object source, ElapsedEventArgs e) {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblVez.InvokeRequired)
            {
                timerTickCallback d = new timerTickCallback(timerTick);
                this.Invoke(d, new object[] { source, e });
            }
            else
            {
                lblVez.Text = "Vez: " + Jogo.VerificarVez(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);
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

        private void btnDebugAtualizaDadosJogador_Click(object sender, EventArgs e)
        {
            lblDadosJogador.Text = dadosJogador[0] = txtIdJogador.Text;
            dadosJogador[1] = txtSenhaJogador.Text;
            lblDadosJogador.Text = lblDadosJogador.Text.Insert(lblDadosJogador.Text.Length, "," + dadosJogador[1]);

            string text = System.IO.File.ReadAllText(@"Users.txt");
            if (!text.Contains(lblDadosJogador.Text))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Users.txt", true))
                {
                    file.WriteLine(idPartida.ToString() + " " + "x" + " - " + lblDadosJogador.Text);
                }
            }           
        }

        private void cboUsers_DropDown(object sender, EventArgs e)
        {
            cboUsers.Items.Clear();
            string[] lines = System.IO.File.ReadAllLines(@"Users.txt");

            foreach (string line in lines)
            {
                if (line.Length > 2) {
                    if (line.Substring(0, line.IndexOf(" ")) == idPartida.ToString()) {
                        cboUsers.Items.Add(line.Substring(line.IndexOf("-") + 2));
                    }
                }
            }
        }

        private void frmPartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Owner.WindowState = FormWindowState.Normal;
        }

        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdJogador.Text = dadosJogador[0] = lblDadosJogador.Text = cboUsers.SelectedItem.ToString().Substring(0, cboUsers.SelectedItem.ToString().IndexOf(","));
            txtSenhaJogador.Text = dadosJogador[1]  = cboUsers.SelectedItem.ToString().Substring(cboUsers.SelectedItem.ToString().IndexOf(",") + 1);
            lblDadosJogador.Text = lblDadosJogador.Text.Insert(lblDadosJogador.Text.Length, "," + dadosJogador[1]);
        }
    }
}

/*
sala id 42
senha 1234

jogador id 83
jogador senha 15E1B6   
*/
