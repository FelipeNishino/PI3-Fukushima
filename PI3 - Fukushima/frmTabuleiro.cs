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
        int idPartida;
        public Tabuleiro tabuleiro { get; set; }

        public int nFabricas { get; set; }

        private enum Visibility
        {
            show,
            hide
        }
        public FrmTabuleiro(string[] _dadosJogador, Tabuleiro _tabuleiro, int _nFabricas, int _idPartida)
        {
            tabuleiro = _tabuleiro;
            dadosJogador = _dadosJogador;
            nFabricas = _nFabricas;
            idPartida = _idPartida;
            InitializeComponent();
        }

        private void btnLerTabuleiro_Click(object sender, EventArgs e)
        {
            lerTabuleiro();
        }
        private double Mod(double a, double b)
        {
            double m = a % b;
            if (m < 0)
            {
                // m += (b < 0) ? -b : b; // avoid this form: it is UB when b == INT_MIN
                m = (b < 0) ? m - b : m + b;
            }
            return m;
        }
        private int powInt(int x, int y) {
            for (int i = 1; i <= y; i++)
            {
                x *= x;
            }

            return x;
        }
        private void frmTabuleiro_Load(object sender, EventArgs e)
        {
            lblPlayer1.Text = "";
            //lblPlayer1.Text = Jogo.ListarJogadores(idPartida);

            setPlacar();

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

            for (int i = 0; i < nFabricas; i++)
            {
                PictureBox pboFabrica = new PictureBox();
                //angle = Mod(90 - (i * (360 / 4)), 360);
                //radAngle = angle * Math.PI / 180;
                pboFabrica.Image = Properties.Resources.Fabrica;
                pboFabrica.SizeMode = PictureBoxSizeMode.StretchImage;
                pboFabrica.BackColor = Color.Transparent;
                pboFabrica.Width = 100;
                pboFabrica.Height = 100;

                switch (nFabricas)
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

        public void setPlacar()
        {
            List<Jogador> jogadores = Partida.listarJogadores(idPartida);

            lblPlayer1.Invoke((MethodInvoker)delegate{
                lblPlayer1.Text = "";
            });

            for (int i = 0; i < jogadores.Count; i++)
            {
                lblPlayer1.Invoke((MethodInvoker)delegate
                {
                    lblPlayer1.Text += jogadores[i].nome;
                    lblPlayer1.Text += "(" + jogadores[i].id + "): ";
                    lblPlayer1.Text += jogadores[i].score + " ponto" + (jogadores[i].score != 1 ? "s" : "");
                    lblPlayer1.Text += "\n";
                });
            }
        }
        public void setCentro(int index, int quantidade)
        {
            Label lblCentro = new Label();

            lblCentro = Controls.Find("lblCentro" + (index + 1), false)[0] as Label;

            Invoke((MethodInvoker)delegate
            {
                lblCentro.Text = quantidade.ToString();
            });
            
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
                    changeVisibility(pbo, tabuleiro.chao[i] > 0 ? Visibility.show : Visibility.hide);
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
            int i, j, quantidade;
            PictureBox pboReferencia = new PictureBox();
            List<Fabrica> fabricasDesenhar = new List<Fabrica>(fabricas);
            //List<Azulejo>[] azulejos = new List<Azulejo>[nFabricas];
            //fabricas.CopyTo(fabricasDesenhar);
            foreach (Fabrica fabrica1 in fabricasDesenhar)
            {
                i = 0;
                j = 1;

                quantidade = fabrica1.azulejos[i].quantidade;
                while (i < fabrica1.azulejos.Count)
                {
                    if (Controls.Find("pboFabrica" + fabrica1.id + j, false).Length != 0)
                    {
                        pboReferencia = Controls.Find("pboFabrica" + fabrica1.id + j, false)[0] as PictureBox;
                        pboReferencia.Invoke((MethodInvoker)delegate
                        {
                            pboSetImg(pboReferencia, fabrica1.azulejos[i].imagem);
                            changeVisibility(pboReferencia, Visibility.show);
                        });
                    }

                    if (quantidade <= 1) {
                        i++;
                        if (i < fabrica1.azulejos.Count) { 
                            quantidade = fabrica1.azulejos[i].quantidade;
                        }
                    } 
                    else quantidade--;

                    j++;
                }
            }
        }
        public void limparCentro()
        {
            PictureBox pbo = new PictureBox();
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

        public void limparFabricas(int idFabrica)
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
                            changeVisibility(pbo, Visibility.hide);
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
