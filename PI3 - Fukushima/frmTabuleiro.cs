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
    public partial class FrmTabuleiro : Form
    {
        string[] dadosJogador;
        public Tabuleiro tabuleiro { get; set; }

        public int nFabricas { get; set; }
        public FrmTabuleiro(string[] _dadosJogador, Tabuleiro _tabuleiro, int _nFabricas)
        {
            tabuleiro = _tabuleiro;
            dadosJogador = _dadosJogador;
            nFabricas = _nFabricas;
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

            for (int i = 0; i < nFabricas*4; i++)
            {
                PictureBox pbo = new PictureBox();
                pbo.Name = "pboFabrica" + (i / 4 + 1) + (i % 4 + 1);
                //pbo.Image = Properties.Resources.pCentro;
                pbo.SizeMode = PictureBoxSizeMode.StretchImage;
                pbo.Width = 50;
                pbo.Height = 50;
                pbo.Location = new Point(20 + (i % 4) * (pbo.Width + 10), 20 + (i / 4) * (pbo.Height + 10));
                this.Controls.Add(pbo);
            }
            
        }

        public Tabuleiro retornaTabuleiro() {
            return tabuleiro;
        }

        public void lerTabuleiro(){
             List<PictureBox> pictureBoxes = Controls.OfType<PictureBox>().ToList();

            tabuleiro.Listar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], tabuleiro);

            for (int i = 0; i < tabuleiro.modelo.linhas.Length; i++) {
                for (int j = 1; j <= i + 1; j++) {
                    foreach (PictureBox pbo in pictureBoxes) {
                        if (pbo.Name == "pboModelo" + (i + 1) + j) {
                            if (tabuleiro.modelo.linhas[i].azulejo != null) {
                                if (j <= tabuleiro.modelo.linhas[i].azulejo.quantidade) {
                                    pbo.Image = tabuleiro.modelo.linhas[i].azulejo.imagem;
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

        public void lerFabricas(List<Fabrica> fabricas) {
            int i, j;
            PictureBox pboReferencia = new PictureBox();

            foreach (Fabrica fabrica in fabricas)
            {
                i = 0;
                j = 1;
                
                while (i < fabrica.azulejos.Count)
                {
                    

                    if (Controls.Find("pboFabrica" + fabrica.id + j, false).Length !=0)
                    {
                        pboReferencia = Controls.Find("pboFabrica" + fabrica.id + j, false)[0] as PictureBox;
                        pboReferencia.Visible = true;
                        pboReferencia.Image = fabrica.azulejos[i].imagem;
                    }
                    
                    if (fabrica.azulejos[i].quantidade <= 1) i++;
                    else fabrica.azulejos[i].quantidade--;


                    j++;
                }
            }
        }

        public void limparFabricas(int idFabrica) {

            if (idFabrica > 0) { 
                for (int i = 1; i < 5; i++)
                {
                    if (Controls.Find("pboFabrica" + idFabrica + i, false).Length != 0)
                    {
                        Controls.Find("pboFabrica" + idFabrica + i, false)[0].Visible = false;
                    }
                }
            }
        }
    }
}
