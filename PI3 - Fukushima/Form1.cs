﻿using System;
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
            List<Partida> partidas = Partida.listarPartidas();

            cboPartidas.Items.Clear();
            
            foreach (Partida partida in partidas) {
                cboPartidas.Items.Add(partida.nome);
            }
            
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {

            string retorno = Jogo.EntrarPartida(Int32.Parse(txtIdEntrarPartida.Text), txtNomeJogadorEntrar.Text, txtSenhaEntrarPartida.Text);

            verificarErro(retorno);

            frmPartida frmPartida = new frmPartida();
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
            //if (txtNomeCriarPartida.Text == "") {
            //   MessageBox.Show("ERRO: Campo NOME está vazio", "ERRO");
            //    return;
            //}
            //if (txtSenhaCriarPartida.Text == "") { 
            //   MessageBox.Show("ERRO: Campo SENHA está vazio", "ERRO");
            //    return;
            //}

            //string retorno = Jogo.CriarPartida(txtNomeCriarPartida.Text, txtSenhaCriarPartida.Text);
            //verificarErro(retorno);

            frmPartida frmPartida = new frmPartida();
            frmPartida.ShowDialog();
        }

        private void lblStatusPartida_Click(object sender, EventArgs e)
        {

        }

        public void verificarErro(string retorno) {
            if (retorno.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show(retorno);
            }
            else {
                lblFeedBack.Text += retorno;
            }
        }
    }
}
