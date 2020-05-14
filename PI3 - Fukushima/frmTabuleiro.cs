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

        private enum Visibility
        {
            show,
            hide
        }
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

            for (int i = 0; i < nFabricas * 4; i++)
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

        public Tabuleiro retornaTabuleiro()
        {
            return tabuleiro;
        }
        private void pboSetImg(PictureBox pbo, Image img)
        {
            pbo.Image = img;
        }
        private void changeVisibility(Control control, Visibility visibility)
        {
            switch (visibility)
            {
                case Visibility.show:
                    control.Visible = true;
                    break;
                case Visibility.hide:
                    control.Visible = false;
                    break;
                default:
                    break;
            }
        }
        public void lerTabuleiro()
        {
            List<PictureBox> pictureBoxes = Controls.OfType<PictureBox>().ToList();

            tabuleiro.Listar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], tabuleiro);

            PictureBox pbo = new PictureBox();


            for (int i = 0; i < tabuleiro.modelo.linhas.Length; i++)
            {
                for (int j = 1; j <= i + 1; j++)
                {
                    pbo = Controls.Find("pboModelo" + (i + 1) + j, false)[0] as PictureBox;
                    if (tabuleiro.modelo.linhas[i].azulejo.id != -1)
                    {
                        if (j <= tabuleiro.modelo.linhas[i].azulejo.quantidade)
                        {
                            pbo.Invoke((MethodInvoker)delegate
                            {
                                pboSetImg(pbo, tabuleiro.modelo.linhas[i].azulejo.imagem);
                                changeVisibility(pbo, Visibility.show);
                            });
                        }
                        else
                        {
                            pbo.Invoke((MethodInvoker)delegate
                            {
                                changeVisibility(pbo, Visibility.hide);
                            });
                        }
                    }
                    else
                    {
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            changeVisibility(pbo, Visibility.hide);
                        });
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    pbo = Controls.Find("pboParede" + (i + 1) + (j + 1), false)[0] as PictureBox;

                    if (tabuleiro.parede[i, j])
                    {
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            changeVisibility(pbo, Visibility.show);
                        });
                    }
                    else
                    {
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            changeVisibility(pbo, Visibility.hide);
                        });
                    }
                }
            }

            for (int i = 0; i < 7; i++)
            {
                pbo = Controls.Find("pboChao" + (i + 1), false)[0] as PictureBox;
                pbo.Invoke((MethodInvoker)delegate
                {
                    changeVisibility(pbo, Visibility.show);
                });
                switch (tabuleiro.chao[i])
                {
                    case 0:
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            pboSetImg(pbo, Properties.Resources.pCentro);
                        });
                        break;

                    case 1:
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            pboSetImg(pbo, Properties.Resources.Azul);
                        });
                        break;

                    case 2:
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            pboSetImg(pbo, Properties.Resources.Amarelo);
                        });
                        break;

                    case 3:
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            pboSetImg(pbo, Properties.Resources.Vermelho);
                        });
                        break;

                    case 4:
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            pboSetImg(pbo, Properties.Resources.Preto);
                        });
                        break;

                    case 5:
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            pboSetImg(pbo, Properties.Resources.Branco);
                        });
                        break;

                    default:

                        break;
                }


            }
            tabuleiro.chao = new[] { -1, -1, -1, -1, -1, -1, -1 };
        }

        public void lerFabricas(List<Fabrica> fabricas)
        {
            int i, j;
            PictureBox pboReferencia = new PictureBox();

            foreach (Fabrica fabrica in fabricas)
            {
                i = 0;
                j = 1;

                while (i < fabrica.azulejos.Count)
                {


                    if (Controls.Find("pboFabrica" + fabrica.id + j, false).Length != 0)
                    {
                        pboReferencia = Controls.Find("pboFabrica" + fabrica.id + j, false)[0] as PictureBox;
                        pboReferencia.Invoke((MethodInvoker)delegate
                        {
                            pboSetImg(pboReferencia, fabrica.azulejos[i].imagem);
                            changeVisibility(pboReferencia, Visibility.show);
                        });
                    }

                    if (fabrica.azulejos[i].quantidade <= 1) i++;
                    else fabrica.azulejos[i].quantidade--;


                    j++;
                }
            }
        }

        public void limparFabricas()
        {
            PictureBox pbo;

            for (int i = 1; i <= nFabricas; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (Controls.Find("pboFabrica" + i + j, false).Length != 0)
                    {
                        pbo = Controls.Find("pboFabrica" + i + j, false)[0] as PictureBox;
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            changeVisibility(pbo, Visibility.hide);
                        });
                    }
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
