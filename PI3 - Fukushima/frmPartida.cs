using AzulServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
namespace PI3___Fukushima
{
    public partial class FrmPartida : Form
    {
        string[] dadosJogador;
        int idPartida, nFabricas;
        public Tabuleiro tabuleiro;
        public List<Fabrica> fabricas;
        public FrmTabuleiro frmTabuleiro;
        private Centro centro;
        BackgroundWorker workerThread = null;

        bool keepRunning = false;
        bool isBuying = false;

        public FrmPartida(string[] _dadosJogador, string _idPartida, int nJogadores)
        {
            dadosJogador = _dadosJogador;
            idPartida = Convert.ToInt32(_idPartida);
            nFabricas = nJogadores;

            InitializeComponent();

            InstantiateWorkerThread();

        }
        private void InstantiateWorkerThread()
        {
            workerThread = new BackgroundWorker();
            workerThread.ProgressChanged += WorkerThreadTick;
            workerThread.DoWork += WorkerThread_DoWork;
            workerThread.RunWorkerCompleted += WorkerThread_RunWorkerCompleted;
            workerThread.WorkerReportsProgress = true;
            workerThread.WorkerSupportsCancellation = true;
        }

        private void WorkerThreadTick(object sender, ProgressChangedEventArgs e)
        {

        }
        private void WorkerThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStopWatch.Text = "Cancelled";
            }
            else
            {
                lblStopWatch.Text = "isBuying false";
                isBuying = false;
            }
        }

        private void WorkerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime startTime = DateTime.Now;
            String vez;
            keepRunning = true;

            while (keepRunning)
            {
                Thread.Sleep(1000);
                string timeElapsedInstring = (DateTime.Now - startTime).ToString(@"hh\:mm\:ss");

                if (!isBuying)
                {
                    vez = Jogo.VerificarVez(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);

                    Action atualizaVez = () => lblVez.Text = "Vez: " + vez;
                    lblVez.Invoke(atualizaVez);

                    if (vez.Substring(vez.IndexOf(",") + 1, vez.LastIndexOf(",") - (vez.IndexOf(",") + 1)) == dadosJogador[0] && chkBot.Checked)
                    {
                        isBuying = true;
                        frmTabuleiro.lerTabuleiro();
                        btnListarFabricas_Click(null, null);
                        btnListarCentro_Click(null, null);
                        BotCompra();
                    }
                }

                workerThread.ReportProgress(0, timeElapsedInstring);

                if (workerThread.CancellationPending)
                {
                    // this is important as it set the cancelled property of RunWorkerCompletedEventArgs to true
                    e.Cancel = true;
                    break;
                }
            }
        }
        private void FrmPartida_Load(object sender, EventArgs e)
        {
            lblFeedback.Text = "";
            lblDadosJogador.Text = dadosJogador[0] + "," + dadosJogador[1];

            nFabricas = 2 * nFabricas + 1;

            for (int i = 1; i <= nFabricas; i++)
            {
                cboFabricasCompra.Items.Add(i.ToString());
            }
            cboFabricasCompra.Items.Add("Centro");

            

            tabuleiro = new Tabuleiro();
            frmTabuleiro = new FrmTabuleiro(dadosJogador, tabuleiro, nFabricas);

            this.Location = this.Owner.Location;

            Owner.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;

            this.AddOwnedForm(frmTabuleiro);

            frmTabuleiro.Show();
            workerThread.RunWorkerAsync();

        }


        private void btnListarFabricas_Click(object sender, EventArgs e)
        {

            string[] retorno;
            retorno = Jogo.LerFabricas(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]).Replace("\r", "").Split('\n');

            lstAzulejosFabricas.Invoke((MethodInvoker)delegate
            {
                lstAzulejosFabricas.Items.Clear();
            });
            if (retorno[0] == "" && fabricas != null)
            {
                fabricas.RemoveRange(0, fabricas.Count);
                return;
            }


            int i = Convert.ToInt32(retorno[0].Substring(0, 1));
            int j = 0;

            fabricas = new List<Fabrica>();
            List<Azulejo>[] azulejos = new List<Azulejo>[nFabricas];

            for (int x = 0; x < nFabricas; x++)
            {
                azulejos[x] = new List<Azulejo>();
            }

            while (i <= nFabricas && retorno[j] != "")
            {

                Azulejo azulejo = new Azulejo();

                azulejo.id = Convert.ToInt32(retorno[j].Substring(2, 1));
                azulejo.quantidade = Convert.ToInt32(retorno[j].Substring(retorno[j].LastIndexOf(",") + 1, 1));
                azulejo.carregarImagem();
                azulejos[i - 1].Add(azulejo);

                j++;

                lstAzulejosFabricas.Invoke((MethodInvoker)delegate
                {
                    lstAzulejosFabricas.Items.Add(i + "," + azulejo.id + "," + azulejo.quantidade);
                });

                if (retorno[j] != "" && i != Convert.ToInt32(retorno[j].Substring(0, 1)))
                {
                    Fabrica fabrica = new Fabrica();
                    fabrica.id = i;
                    fabrica.azulejos = azulejos[i - 1];
                    fabricas.Add(fabrica);
                    i = Convert.ToInt32(retorno[j].Substring(0, 1));
                }
                else if (retorno[j] == "")
                {
                    Fabrica fabrica = new Fabrica();
                    fabrica.id = i;
                    fabrica.azulejos = azulejos[i - 1];
                    fabricas.Add(fabrica);
                }
            }

            frmTabuleiro.lerFabricas(fabricas);

        }

        private void btnListarCentro_Click(object sender, EventArgs e)
        {
            string[] retorno;
            string[] itensRetorno;
            centro = new Centro();
            List<Azulejo> azulejos = new List<Azulejo>();

            retorno = Jogo.LerCentro(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]).Replace("\r", "").Split('\n');

            //verificarErro(retorno);

            lstAzulejosCentro.Invoke((MethodInvoker)delegate
            {
                lstAzulejosCentro.Items.Clear();
            });

            for (int i = 0; i < retorno.Length - 1; i++)
            {
                Azulejo azulejo = new Azulejo();
                itensRetorno = retorno[i].Split(',');

                azulejo.id = Convert.ToInt32(itensRetorno[0]);

                azulejo.quantidade = Convert.ToInt32(itensRetorno[2]);

                azulejos.Add(azulejo);


                lstAzulejosCentro.Invoke((MethodInvoker)delegate
                {
                    lstAzulejosCentro.Items.Add((azulejo.id, itensRetorno[1], azulejo.quantidade, itensRetorno[3]));
                });
            }

            centro.azulejos = azulejos;
            centro.marca1 = retorno[0].Substring(retorno[0].LastIndexOf(',') + 1, 1) == "1";
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

            retorno = Jogo.Jogar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], centro, (cboFabricasCompra.SelectedItem.ToString() == "Centro") ? 0 : Convert.ToInt32(cboFabricasCompra.SelectedItem), Convert.ToInt32(cboAzulejoCompra.SelectedItem), Convert.ToInt32(cboModeloCompra.SelectedItem));
            VerificarErro(retorno);

        }

        public bool VerificarErro(string retorno)
        {
            lblFeedback.Invoke((MethodInvoker)delegate
            {
                lblFeedback.Text = retorno;
            });
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
                if (line.Length > 2)
                {
                    if (line.Substring(0, line.IndexOf(" ")) == idPartida.ToString())
                    {
                        cboUsers.Items.Add(line.Substring(line.IndexOf("-") + 2));
                    }
                }
            }
        }

        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdJogador.Text = dadosJogador[0] = lblDadosJogador.Text = cboUsers.SelectedItem.ToString().Substring(0, cboUsers.SelectedItem.ToString().IndexOf(","));
            txtSenhaJogador.Text = dadosJogador[1] = cboUsers.SelectedItem.ToString().Substring(cboUsers.SelectedItem.ToString().IndexOf(",") + 1);
            lblDadosJogador.Text = lblDadosJogador.Text.Insert(lblDadosJogador.Text.Length, "," + dadosJogador[1]);
        }

        private void FrmPartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            workerThread.CancelAsync();
            keepRunning = false;
            Owner.WindowState = FormWindowState.Normal;
        }

        private void FrmPartida_LocationChanged(object sender, EventArgs e)
        {
            frmTabuleiro.Location = new System.Drawing.Point
            {
                X = this.Location.X + this.Width,
                Y = this.Location.Y
            };
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            keepRunning = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }
        private void BotCompra()
        {
            int idFabricaComprada = -1;
            linha linhaComprada = new linha(-1, null);

            String local = "";
            bool comprou = false;

            Azulejo azulejo = new Azulejo
            {
                id = 0,
                quantidade = 0
            };

            tabuleiro = frmTabuleiro.retornaTabuleiro();

            linha[] linhasPreenchidas = Array.FindAll(tabuleiro.modelo.linhas, linha => linha.azulejo.id != -1 || linha.azulejo.quantidade != -1);

            if (linhasPreenchidas.Length > 0)
            {
                foreach (linha linha in linhasPreenchidas)
                {
                    if (linha.azulejo.quantidade < linha.posicao + 1 && !tabuleiro.verificarAzulejoParede(linha.azulejo.id, linha.posicao, tabuleiro))
                    {
                        if (fabricas != null)
                        {
                            foreach (Fabrica fabrica in fabricas)
                            {
                                azulejo = fabrica.azulejos.Find(azulejoFind => azulejoFind.id == linha.azulejo.id);
                                if (azulejo != null)
                                {
                                    local = "F";
                                    idFabricaComprada = fabrica.id;
                                    linhaComprada.azulejo = azulejo;
                                    linhaComprada.posicao = linha.posicao;
                                    comprou = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            azulejo = centro.azulejos.Find(azulejoFind => azulejoFind.id == linha.azulejo.id);
                            if (azulejo != null)
                            {
                                local = "C";
                                linhaComprada.azulejo = azulejo;
                                linhaComprada.posicao = linha.posicao;
                                comprou = true;
                            }
                        }
                    }
                }

                if (comprou)
                {
                    Jogo.Jogar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], local, idFabricaComprada, linhaComprada.azulejo.id, linhaComprada.posicao + 1);
                }
            }

            if (!comprou)
            {
                if (!jogarPadrao(azulejo, idFabricaComprada))
                {
                    int menorQuantidade = 5;
                    if (fabricas != null)
                    {
                        foreach (Fabrica fabrica in fabricas)
                        {
                            foreach (Azulejo azulejo1 in fabrica.azulejos)
                            {
                                if (azulejo1.quantidade < menorQuantidade)
                                {
                                    menorQuantidade = azulejo1.quantidade;
                                    azulejo.id = azulejo1.id;
                                    idFabricaComprada = fabrica.id;
                                }
                            }
                        }
                        local = "F";
                    }
                    else
                    {
                        foreach (Azulejo azulejo1 in centro.azulejos)
                        {
                            if (azulejo1.quantidade < menorQuantidade)
                            {
                                menorQuantidade = azulejo1.quantidade;
                                azulejo.id = azulejo1.id;
                            }
                        }
                        local = "C";
                    }

                    Jogo.Jogar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], local, 0, linhaComprada.azulejo.id, linhaComprada.posicao + 1);
                }
            }


            frmTabuleiro.limparFabricas(idFabricaComprada);
            frmTabuleiro.lerTabuleiro();
            btnListarFabricas_Click(null, null);
            btnListarCentro_Click(null, null);
            isBuying = false;
        }


        public bool jogarPadrao(Azulejo azulejo, int idFabricaComprada)
        {
            int i = 0;
            while (tabuleiro.modelo.linhas[i].azulejo.id != -1 && i < 4)
            {
                i++;
            }
            if (fabricas.Count != 0)
            {
                foreach (Fabrica fabrica in fabricas)
                {
                    azulejo = fabrica.azulejos.Find(azulejoFind => azulejoFind.quantidade <= i + 1 && !tabuleiro.verificarAzulejoParede(azulejoFind.id, i, tabuleiro));
                    if (azulejo != null)
                    {
                        Jogo.Jogar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], "F", fabrica.id, azulejo.id, i + 1);
                        idFabricaComprada = fabrica.id;
                        return true;
                    }
                }
            }
            else
            {
                foreach (Azulejo azulejo1 in centro.azulejos)
                {
                    if ((azulejo1.quantidade > azulejo.quantidade && azulejo1.quantidade <= i + 1) || azulejo1.quantidade > i + 1)
                    {
                        azulejo = azulejo1;
                        idFabricaComprada = 0;
                        Jogo.Jogar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], "C", 0, azulejo.id, i + 1);
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
