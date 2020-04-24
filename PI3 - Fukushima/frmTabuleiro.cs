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
    public partial class frmTabuleiro : Form
    {
        string[] dadosJogador;
        public Tabuleiro tabuleiro { get; set; }
        public frmTabuleiro(string[] _dadosJogador, Tabuleiro _tabuleiro)
        {
            tabuleiro = _tabuleiro;
            dadosJogador = _dadosJogador;
            InitializeComponent();
        }

        private void btnLerTabuleiro_Click(object sender, EventArgs e)
        {
            lerTabuleiro();
        }

        private void frmTabuleiro_Load(object sender, EventArgs e)
        {
            Point startPosition = new Point();
            startPosition.X = Owner.Location.X + Owner.Width;
            startPosition.Y = Owner.Location.Y;
            Location = startPosition;
        }

        public Tabuleiro retornaTabuleiro() {
            return tabuleiro;
        }

        public void lerTabuleiro(){
             List<PictureBox> pictureBoxes = Controls.OfType<PictureBox>().ToList();
       

            tabuleiro.Listar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], tabuleiro);

            for (int i = 0; i<tabuleiro.modelo.arrayAzulejos.Length; i++) {
                for (int j = 1; j <= i + 1; j++) {
                    foreach (PictureBox pbo in pictureBoxes) {
                        if (pbo.Name == "pboModelo" + (i + 1) + j) {
                            if (tabuleiro.modelo.arrayAzulejos[i] != null) {
                                if (j <= tabuleiro.modelo.arrayAzulejos[i].quantidade) {
                                    pbo.Image = tabuleiro.modelo.arrayAzulejos[i].imagem;
                                    pbo.Visible = true;
                                }
                                else {
                                    pbo.Visible = false;
                                }
                            }
                            else {
                                pbo.Visible = false;
                            }
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i< 5; i++) {
                for (int j = 0; j< 5; j++) {
                    foreach (PictureBox pbo in pictureBoxes) {
                        if (pbo.Name == "pboParede" + (i + 1) + (j + 1)) {
                            if (tabuleiro.parede[i, j]) {
                                pbo.Visible = true;
                            }
                            else {
                                pbo.Visible = false;
                            }
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i< 7; i++)
            {
                foreach (PictureBox pbo in pictureBoxes)
                {
                    if (pbo.Name == "pboChao" + (i + 1))
                    {
                        switch (tabuleiro.chao[i])
                        {
                            case 0:
                                pbo.Image = Properties.Resources.pCentro;
                                pbo.Visible = true;
                                break;

                            case 1:
                                pbo.Image = Properties.Resources.Azul;
                                pbo.Visible = true;
                                break;

                            case 2:
                                pbo.Image = Properties.Resources.Amarelo;
                                pbo.Visible = true;
                                break;

                            case 3:
                                pbo.Image = Properties.Resources.Vermelho;
                                pbo.Visible = true;
                                break;

                            case 4:
                                pbo.Image = Properties.Resources.Preto;
                                pbo.Visible = true;
                                break;

                            case 5:
                                pbo.Image = Properties.Resources.Branco;
                                pbo.Visible = true;
                                break;

                            default:
                                pbo.Visible = false;
                                break;
                        }
                    }
                }
            }
            tabuleiro.chao = new[] { -1, -1, -1, -1, -1, -1, -1 };    
        }
    }
}
