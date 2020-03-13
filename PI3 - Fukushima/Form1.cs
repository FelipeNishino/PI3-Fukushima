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
    }
}
