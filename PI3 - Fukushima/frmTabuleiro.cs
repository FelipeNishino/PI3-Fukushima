using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PI3___Fukushima
{
    public partial class FrmTabuleiro : Form
    {
        string[] dadosJogador;
        int idPartida;
        public Tabuleiro Tabuleiro { get; set; }

        public int NFabricas { get; set; }

        private enum Visibility
        {
            show,
            hide
        }
        public FrmTabuleiro(string[] _dadosJogador, Tabuleiro _tabuleiro, int _nFabricas, int _idPartida)
        {
            Tabuleiro = _tabuleiro;
            dadosJogador = _dadosJogador;
            NFabricas = _nFabricas;
            idPartida = _idPartida;
            InitializeComponent();
        }

        private void btnLerTabuleiro_Click(object sender, EventArgs e)
        {
            LerTabuleiro();
        }

        private void FrmTabuleiro_Load(object sender, EventArgs e)
        {
            lblPlayer1.Text = "";
            //lblPlayer1.Text = Jogo.ListarJogadores(idPartida);

            SetPlacar();

            Point[] coords5Fabricas = new Point[] 
            { 
                new Point(210, 52), new Point(355, 170), new Point(318, 342), new Point(94, 342), new Point(55, 170)                      
            };

            Point[] coords7Fabricas = new Point[]
            {
                new Point(210, 52), new Point(344, 110), new Point(360, 248), new Point(278, 364), new Point(134, 364), new Point(50, 248), new Point(66, 110)
            };

            Point[] coords9Fabricas = new Point[]
            {
                 new Point(210, 52),new Point(310, 82),new Point(366, 180),new Point(347, 280),new Point(264, 364),new Point(148, 364),new Point(63, 280),new Point(45, 180),new Point(110, 82)
            };

            lblCentro1.Text = "0";
            lblCentro2.Text = "0";
            lblCentro3.Text = "0";
            lblCentro4.Text = "0";
            lblCentro5.Text = "0";

            //double angle, radAngle, radius = 100;
            Location = new Point
            {
                X = Owner.Location.X + Owner.Width,
                Y = Owner.Location.Y
            };

            //for (int i = 0; i < ((nFabricas - 1) / 2) - 1; i++)
            //{
            //    Label lblNome = new Label();
            //    Label lblPonto = new Label();                               
            //}

            //foreach (Jogador jogador in Partida.listarJogadores(idPartida))
            //{
            //    lstSala.Items.Add(jogador.id + ", " + jogador.nome + ", " + jogador.score);
            //}

            for (int i = 0; i < NFabricas; i++)
            {
                PictureBox pboFabrica = new PictureBox();
                //angle = Mod(90 - (i * (360 / 4)), 360);
                //radAngle = angle * Math.PI / 180;
                pboFabrica.Image = Properties.Resources.Fabrica;
                pboFabrica.SizeMode = PictureBoxSizeMode.StretchImage;
                pboFabrica.BackColor = Color.Transparent;
                pboFabrica.Width = 100;
                pboFabrica.Height = 100;

                switch (NFabricas)
                {
                    case 5:
                        pboFabrica.Location = new Point
                        {
                            X = coords5Fabricas[i].X,
                            Y = coords5Fabricas[i].Y
                        };
                        break;
                    case 7:
                        pboFabrica.Location = new Point
                        {
                            X = coords7Fabricas[i].X,
                            Y = coords7Fabricas[i].Y
                        };
                        break;
                    case 9:
                        pboFabrica.Location = new Point
                        {
                            X = coords9Fabricas[i].X,
                            Y = coords9Fabricas[i].Y
                        };
                        break;
                    default:
                        pboFabrica.Location = new Point
                        {
                            X = coords5Fabricas[i].X,
                            Y = coords5Fabricas[i].Y
                        };
                        break;
                }

                //pboFabrica.Location = new Point
                //{
                //    X = 257 - Convert.ToInt32(Math.Cos(angle) * 110 + 105),
                //    Y = 257 - Convert.ToInt32(Math.Sin(angle) * 110 + 105)
                //};

                //Point coord = new Point();

                //if (Math.Cos(radAngle) >= 0) coord.X = 257 + Convert.ToInt32(Math.Cos(radAngle) * 110);
                //else coord.X = 257 - Convert.ToInt32(Math.Cos(radAngle) * 110 + Math.Cos(radAngle) * 105);

                //if (Math.Sin(radAngle) >= 0) coord.Y = 257 - Convert.ToInt32(Math.Sin(radAngle) * 110);
                //else coord.Y = 257 + Convert.ToInt32(Math.Sin(radAngle) * 110 + Math.Sin(angle) * 105);

                //pboFabrica.Location = coord;

                this.Controls.Add(pboFabrica);

                for (int j = 0; j < 4; j++)
                {
                    PictureBox pbo = new PictureBox();
                    pbo.Name = "pboFabrica" + (i + 1) + (j + 1);
                    //pbo.Image = Properties.Resources.pCentro;
                    pbo.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbo.Visible = false;
                    pbo.Width = 40;
                    pbo.Height = 40;
                    pbo.Location = new Point(pboFabrica.Location.X + 6 + j % 2 * (pbo.Width + 8), pboFabrica.Location.Y + 6 + j / 2 * (pbo.Height + 8));
                    this.Controls.Add(pbo);
                    pbo.BringToFront();
                }
            }                        
        }

        public Tabuleiro RetornaTabuleiro()
        {
            return Tabuleiro;
        }
        private void pboSetImg(PictureBox pbo, Image img)
        {
            pbo.Image = img;
        }
        private void ChangeVisibility(Control control, Visibility visibility)
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

        public void SetPlacar()
        {
            List<Jogador> jogadores = Partida.ListarJogadores(idPartida);

            lblPlayer1.Invoke((MethodInvoker)delegate{
                lblPlayer1.Text = "";
            });

            for (int i = 0; i < jogadores.Count; i++)
            {
                lblPlayer1.Invoke((MethodInvoker)delegate
                {
                    lblPlayer1.Text += jogadores[i].Nome;
                    lblPlayer1.Text += "(" + jogadores[i].Id + "): ";
                    lblPlayer1.Text += jogadores[i].Score + " ponto" + (jogadores[i].Score != 1 ? "s" : "");
                    lblPlayer1.Text += "\n";
                });
            }
        }
        public void SetCentro(int index, int quantidade)
        {
            Label lblCentro = new Label();

            lblCentro = Controls.Find("lblCentro" + (index + 1), false)[0] as Label;

            Invoke((MethodInvoker)delegate
            {
                lblCentro.Text = quantidade.ToString();
            });
            
        }
        public void LerTabuleiro()
        {
            List<PictureBox> pictureBoxes = Controls.OfType<PictureBox>().ToList();

            Tabuleiro.Listar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], Tabuleiro);

            PictureBox pbo = new PictureBox();

            for (int i = 0; i < Tabuleiro.Modelo.linhas.Length; i++)
            {
                for (int j = 1; j <= i + 1; j++)
                {
                    pbo = Controls.Find("pboModelo" + (i + 1) + j, false)[0] as PictureBox;
                    if (Tabuleiro.Modelo.linhas[i].azulejo.Id != -1)
                    {
                        if (j <= Tabuleiro.Modelo.linhas[i].azulejo.Quantidade)
                        {
                            pbo.Invoke((MethodInvoker)delegate
                            {
                                pboSetImg(pbo, Tabuleiro.Modelo.linhas[i].azulejo.Imagem);
                                ChangeVisibility(pbo, Visibility.show);
                            });
                        }
                        else
                        {
                            pbo.Invoke((MethodInvoker)delegate
                            {
                                ChangeVisibility(pbo, Visibility.hide);
                            });
                        }
                    }
                    else
                    {
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            ChangeVisibility(pbo, Visibility.hide);
                        });
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    pbo = Controls.Find("pboParede" + (i + 1) + (j + 1), false)[0] as PictureBox;

                    if (Tabuleiro.Parede[i, j])
                    {
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            ChangeVisibility(pbo, Visibility.show);
                        });
                    }
                    else
                    {
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            ChangeVisibility(pbo, Visibility.hide);
                        });
                    }
                }
            }

            for (int i = 0; i < 7; i++)
            {
                pbo = Controls.Find("pboChao" + (i + 1), false)[0] as PictureBox;
                pbo.Invoke((MethodInvoker)delegate
                {                    
                    ChangeVisibility(pbo, Tabuleiro.chao[i] > 0 ? Visibility.show : Visibility.hide);
                });
                switch (Tabuleiro.chao[i])
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
            Tabuleiro.chao = new[] { -1, -1, -1, -1, -1, -1, -1 };
        }

        public void LerFabricas(List<Fabrica> fabricas)
        {
            int i, j, quantidade;
            PictureBox pboReferencia = new PictureBox();
            List<Fabrica> fabricasDesenhar = new List<Fabrica>(fabricas);
            //List<Azulejo>[] azulejos = new List<Azulejo>[nFabricas];
            //fabricas.CopyTo(fabricasDesenhar);
            foreach (Fabrica fabrica1 in fabricasDesenhar)
            {
                i = 0;
                j = 1;

                quantidade = fabrica1.Azulejos[i].Quantidade;
                while (i < fabrica1.Azulejos.Count)
                {
                    if (Controls.Find("pboFabrica" + fabrica1.Id + j, false).Length != 0)
                    {
                        pboReferencia = Controls.Find("pboFabrica" + fabrica1.Id + j, false)[0] as PictureBox;
                        pboReferencia.Invoke((MethodInvoker)delegate
                        {
                            pboSetImg(pboReferencia, fabrica1.Azulejos[i].Imagem);
                            ChangeVisibility(pboReferencia, Visibility.show);
                        });
                    }

                    if (quantidade <= 1) {
                        i++;
                        if (i < fabrica1.Azulejos.Count) { 
                            quantidade = fabrica1.Azulejos[i].Quantidade;
                        }
                    } 
                    else quantidade--;

                    j++;
                }
            }
        }
        public void LimparCentro()
        {
            PictureBox pbo = new PictureBox();
            for (int i = 0; i < 7; i++)
            {
                pbo = Controls.Find("pboChao" + (i + 1), false)[0] as PictureBox;
                pbo.Invoke((MethodInvoker)delegate
                {
                    ChangeVisibility(pbo, Visibility.show);
                });
                switch (Tabuleiro.chao[i])
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
            Tabuleiro.chao = new[] { -1, -1, -1, -1, -1, -1, -1 };
        }

        public void LimparFabricas(int idFabrica)
        {
            PictureBox pbo;
            if (idFabrica > 0)
            {
                for (int i = 1; i < 5; i++)
                {
                    if (Controls.Find("pboFabrica" + idFabrica + i, false).Length != 0)
                    {
                        pbo = Controls.Find("pboFabrica" + idFabrica + i, false)[0] as PictureBox;
                        pbo.Invoke((MethodInvoker)delegate
                        {
                            ChangeVisibility(pbo, Visibility.hide);
                        });
                    }
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pboModelo55_Click(object sender, EventArgs e)
        {

        }

        private void pboCentro3_Click(object sender, EventArgs e)
        {

        }
    }
}
