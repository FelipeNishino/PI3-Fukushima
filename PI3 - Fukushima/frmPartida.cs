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
        public frmPartida()
        {
            InitializeComponent();
        }

        private void btnListarJogadoresPartida_Click(object sender, EventArgs e)
        {
            foreach (Jogador jogador in Partida.listarJogadores(68))
            {
                lstListaJogadores.Items.Add(jogador.id + ", " + jogador.nome + ", " + jogador.score);
            }
        }

        private void btnListarFabricas_Click(object sender, EventArgs e)
        {

        }
    }
}
