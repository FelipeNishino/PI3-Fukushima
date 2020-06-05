using AzulServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.CodeDom;
using System.Diagnostics;
using System.Linq;

namespace PI3___Fukushima
{
    public partial class FrmPartida : Form
    {
        string[] dadosJogador;
        string lastPlay;
        int idPartida, nFabricas, tickCounter, sleepTime, round, menorQuantidadeFabrica, menorQuantidadeCentro, maiorQuantidadeFabrica, maiorQuantidadeCentro, maiorPrioridade, menorPrioridade;
        public Tabuleiro tabuleiro;
        public List<Fabrica> fabricas;
        public FrmTabuleiro frmTabuleiro;
        private Centro centro;
        BackgroundWorker workerThread = null;
        List<Jogada> jogadas;
        List<Jogada> jogadasBoas;

        private enum Flags
        {
            Fabrica,
            Centro,
            Prioridade
        }

        bool keepRunning = false;
        bool isBuying = false;
        bool bot = true;

        public FrmPartida(string[] _dadosJogador, string _idPartida, int nJogadores, bool _bot)
        {
            dadosJogador = _dadosJogador;
            idPartida = Convert.ToInt32(_idPartida);
            nFabricas = nJogadores;
            tickCounter = 0;
            round = 0;
            sleepTime = 1000;
            bot = _bot;

            InitializeComponent();

            InstantiateWorkerThread();
        }

        private void FrmPartida_Load(object sender, EventArgs e)
        {
            lblDadosJogador.Text = dadosJogador[0] + "," + dadosJogador[1];
            resetFlags(Flags.Fabrica);
            resetFlags(Flags.Centro);
            resetFlags(Flags.Prioridade);
            jogadasBoas = new List<Jogada>();

            nFabricas = 2 * nFabricas + 1;

            for (int i = 1; i <= nFabricas; i++)
            {
                cboFabricasCompra.Items.Add(i.ToString());
            }
            cboFabricasCompra.Items.Add("Centro");

            if (bot)
            {
                chkBot.Checked = true;
            }
            else
            {
                chkBot.Checked = false;
            }
            jogadas = new List<Jogada>();

            tabuleiro = new Tabuleiro();
            frmTabuleiro = new FrmTabuleiro(dadosJogador, tabuleiro, nFabricas, idPartida);

            this.Location = this.Owner.Location;

            Owner.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;

            this.AddOwnedForm(frmTabuleiro);

            frmTabuleiro.Show();
            workerThread.RunWorkerAsync();
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
            tickCounter++;
        }
        private void WorkerThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStopWatch.Text = "Cancelled";
            }
            else
            {
                lblStopWatch.Text = "Jogo pausado/encerrado!";
            }
        }

        private void WorkerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime startTime = DateTime.Now;
            string vez, historico, retorno;
            int queuedRead = 1;

            keepRunning = true;
            Invoke((MethodInvoker)delegate
            {
                lblStopWatch.Text = "Timer ativado";
                lblTick.Text = "Timer ticks: " + tickCounter;
            });

            while (keepRunning)
            {
                Debug.Print("comeca timer");
                Thread.Sleep(sleepTime);
                sleepTime = 2000;
                string timeElapsedInstring = (DateTime.Now - startTime).ToString(@"hh\:mm\:ss");

                Action finaliza = () => final();
                if (!isBuying)
                {
                    vez = Jogo.VerificarVez(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);
                    retorno = Jogo.LerNarracao(idPartida);

                    if (vez.Substring(0, 1) == "E")
                    {
                        keepRunning = false;
                        Invoke(finaliza);
                    }
                    else
                    {
                        if (vez.Substring(vez.IndexOf(",") + 1, vez.LastIndexOf(",") - (vez.IndexOf(",") + 1)) == dadosJogador[0])
                        {
                            queuedRead += 2;
                        }
                        //J,41,1

                        if (round < ((retorno.Length - retorno.Replace("Fábricas preenchidas!\r\n", "").Length) / "Fábricas preenchidas!\r\n".Length))
                        {
                            round++;
                            frmTabuleiro.limparCentro();                            
                            frmTabuleiro.setPlacar();
                            queuedRead++;
                        }

                        if (retorno.Contains("comprou"))
                        {
                            retorno = retorno.Substring(0, retorno.IndexOf("\r"));

                            if (!retorno.Contains("preenchidas"))
                            {
                                historico = retorno.Substring(0, retorno.IndexOf(" ")) + ",";
                                if (retorno.Contains("centro"))
                                {
                                    historico += "C,";
                                    historico += "0,";                                    
                                }
                                else
                                {
                                    historico += "F,";
                                    historico += retorno.Substring(retorno.IndexOf("fábrica") + "fábrica ".Length, 1) + ",";                                    
                                }
                                resetFlags(Flags.Centro);
                                resetFlags(Flags.Fabrica);
                                resetFlags(Flags.Prioridade);

                                // Isso aqui tá feio hein
                                if (retorno.Contains("Azul")) historico += 1 + ",";
                                else if (retorno.Contains("Amarelo")) historico += 2 + ",";
                                else if (retorno.Contains("Vermelho")) historico += 3 + ",";
                                else if (retorno.Contains("Preto")) historico += 4 + ",";
                                else if (retorno.Contains("Branco")) historico += 5 + ",";

                                if (retorno.Contains("mas"))
                                {
                                    historico += retorno.Substring(retorno.IndexOf("chão com isso foram ") + "chão com isso foram ".Length, 1);
                                }
                                else
                                {
                                    historico += retorno.Substring(retorno.IndexOf("linha") + "linha ".Length, 1);
                                }

                                if (historico != lastPlay)
                                {                                    
                                    lastPlay = historico;

                                    frmTabuleiro.limparFabricas(Convert.ToInt32(lastPlay.Substring(lastPlay.IndexOf(",") + 3, 1)));

                                    btnListarCentro_Click(null, null);
                                }
                            }
                        }
                        Debug.Print("antes do if: " + queuedRead);
                        if (queuedRead > 0)
                        {
                            Debug.Print("entrou");
                            frmTabuleiro.lerTabuleiro();
                            queuedRead--;
                        }
                        Debug.Print("Depois do if: " + queuedRead);
                        Invoke((MethodInvoker)delegate
                        {
                            lblVez.Text = "Vez: " + vez;
                            lblTick.Text = "Timer ticks: " + tickCounter;
                        });
                    }

                    if (vez.Substring(vez.IndexOf(",") + 1, vez.LastIndexOf(",") - (vez.IndexOf(",") + 1)) == dadosJogador[0] && chkBot.Checked && keepRunning)
                    {
                        isBuying = true;
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
                Debug.Print("Termina timer");
            }

        }

        private void final()
        {
            btnComprarAzulejo.Enabled = false;
            MessageBox.Show("Jogo Encerrado!", "Azul - Fukushima");
        }

        private void resetFlags(Flags local)
        {
            switch (local)
            {
                case Flags.Fabrica:
                    menorQuantidadeFabrica = 5;                    
                    maiorQuantidadeFabrica = -1;
                    break;
                case Flags.Centro:
                    menorQuantidadeCentro = 30;                    
                    maiorQuantidadeCentro = -1;
                    break;
                case Flags.Prioridade:
                    maiorPrioridade = -100;
                    menorPrioridade = 100;
                    break;
                default:
                    break;
            }
        }
        private void limparJogadas(Flags local)
        {
            List<Jogada> jogadasRemovidas = new List<Jogada>();

            switch (local)
            {
                case Flags.Fabrica:
                    jogadasRemovidas = jogadas.FindAll(jogada => jogada.IdFabrica != 0);
                    break;
                case Flags.Centro:
                    jogadasRemovidas = jogadas.FindAll(jogada => jogada.IdFabrica == 0);
                    break;
                default:
                    break;
            }

            for (int i = 0; i < jogadasRemovidas.Count; i++)
            {
                jogadas.Remove(jogadasRemovidas[i]);
            }
        }

        private void btnListarFabricas_Click(object sender, EventArgs e)
        {
            string[] retorno;
            retorno = Jogo.LerFabricas(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]).Replace("\r", "").Split('\n');

            fabricas = new List<Fabrica>();
            List<Azulejo>[] azulejos = new List<Azulejo>[nFabricas];

            if (jogadas != null) limparJogadas(Flags.Fabrica); 

            if (retorno[0] == "" && fabricas != null)
            {
                fabricas.RemoveRange(0, fabricas.Count);
                return;
            }
            int i = Convert.ToInt32(retorno[0].Substring(0, 1));
            int j = 0;


            for (int x = 0; x < nFabricas; x++)
            {
                azulejos[x] = new List<Azulejo>();
            }

            while (i <= nFabricas && retorno[j] != "")
            {
                Jogada novaJogada = new Jogada();
                Azulejo azulejo = new Azulejo();
                
                novaJogada.IdFabrica = i;

                novaJogada.id = azulejo.id = Convert.ToInt32(retorno[j].Substring(2, 1));
                novaJogada.quantidade = azulejo.quantidade = Convert.ToInt32(retorno[j].Substring(retorno[j].LastIndexOf(",") + 1, 1));
                azulejo.carregarImagem();
                azulejos[i - 1].Add(azulejo);

                if (maiorQuantidadeFabrica <= azulejo.quantidade) maiorQuantidadeFabrica = azulejo.quantidade;
                if (menorQuantidadeFabrica >= azulejo.quantidade && azulejo.quantidade > 0) menorQuantidadeFabrica = azulejo.quantidade;

                j++;

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
                jogadas.Add(novaJogada);
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
            if (jogadas != null) limparJogadas(Flags.Centro);

            for (int i = 0; i < retorno.Length - 1; i++)
            {
                Jogada novaJogada = new Jogada();
                Azulejo azulejo = new Azulejo();
                itensRetorno = retorno[i].Split(',');

                novaJogada.id = azulejo.id = Convert.ToInt32(itensRetorno[0]);
                novaJogada.quantidade = azulejo.quantidade = Convert.ToInt32(itensRetorno[2]);
                novaJogada.IdFabrica = 0;

                if (maiorQuantidadeCentro < azulejo.quantidade) maiorQuantidadeCentro = azulejo.quantidade;
                if (menorQuantidadeCentro > azulejo.quantidade && azulejo.quantidade > 0) menorQuantidadeCentro = azulejo.quantidade;

                azulejos.Add(azulejo);
                jogadas.Add(novaJogada);
                frmTabuleiro.setCentro(i, azulejo.quantidade);
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
            frmTabuleiro.Location = new Point
            {
                X = this.Location.X + this.Width,
                Y = this.Location.Y
            };
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isBuying = false;
            workerThread.RunWorkerAsync();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            keepRunning = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            workerThread.CancelAsync();
        }
        private void BotCompra()
        {
            Debug.Print("Comeca compra");
            List<Compra> compras = new List<Compra>();

            Azulejo azulejo = new Azulejo
            {
                id = 0,
                quantidade = 0
            };

            tabuleiro = frmTabuleiro.retornaTabuleiro();

            linha[] linhasPreenchidas = Array.FindAll(tabuleiro.modelo.linhas, linha => linha.azulejo.id != -1 || linha.azulejo.quantidade != -1);
            List<linha> linhasVazias = new List<linha>();            

            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                linha linhaVazia = new linha();

                if (k < linhasPreenchidas.Length)
                {
                    if (linhasPreenchidas[k].posicao == i)
                    {
                        k++;
                        continue;
                    }
                }

                linhaVazia.posicao = i;
                linhasVazias.Add(linhaVazia);
            }

            
            //cadeia de manipulação das estrategias
            if (linhasPreenchidas.Length > 0)
            {
                if (fabricas.Count > 0)
                {
                    compras.AddRange(Estrategia.PreencheComFabrica(jogadas, linhasPreenchidas, tabuleiro, false));
                    compras.AddRange(Estrategia.PreencheComFabrica(jogadas, linhasPreenchidas, tabuleiro, true));
                }
                compras.AddRange(Estrategia.PreencheComCentro(jogadas, linhasPreenchidas, tabuleiro, false));
                compras.AddRange(Estrategia.PreencheComCentro(jogadas, linhasPreenchidas, tabuleiro, true));
            }

            if (linhasVazias.Count > 0)
            {
                if (fabricas.Count > 0)
                {
                    compras.AddRange(Estrategia.MaiorModelo(linhasVazias, jogadas, jogadasBoas, maiorQuantidadeFabrica, maiorQuantidadeCentro, tabuleiro));
                    compras.AddRange(Estrategia.MenorModelo(linhasVazias, jogadas, jogadasBoas, menorQuantidadeFabrica, menorQuantidadeCentro, tabuleiro));
                }
                compras.AddRange(Estrategia.MaiorCentro(linhasVazias, jogadas, maiorQuantidadeCentro, tabuleiro));
                compras.AddRange(Estrategia.MenorCentro(linhasVazias, jogadas, menorQuantidadeCentro, tabuleiro));
            }

            if (compras.Count == 0)
            {
                compras.AddRange(Estrategia.MenorChao(jogadas, menorQuantidadeFabrica, menorQuantidadeCentro, tabuleiro));
            }
            else
            {

                //foreach para controle de prioridades, assim o find achando todas as compras com o valor igual a maiorPrioridade
                foreach (Compra compra in compras)
                {
                    compra.Prioridade += tabuleiro.verificarPrioridades(compra.id, compra.LinhaModelo, tabuleiro);
                    if (maiorPrioridade < compra.Prioridade) maiorPrioridade = compra.Prioridade;
                    if (menorPrioridade > compra.Prioridade) menorPrioridade = compra.Prioridade;
                }
                compras = compras.FindAll(compra => compra.Prioridade == maiorPrioridade);
            }


            Random rand = new Random();
            k = rand.Next(0, compras.Count - 1);
            Debug.Print(compras[k].Fonte + ": Local " + compras[k].Local + ", IdF " + compras[k].IdFabrica + ", Id" + compras[k].id + ", quantidade " + compras[k].quantidade + ",linha " + compras[k].LinhaModelo);
            Jogo.Jogar(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], compras[k].Local, compras[k].IdFabrica, compras[k].id, compras[k].LinhaModelo);

            isBuying = false;


            //verifica se a apartidad foi finalizada depois de uma jogada
            Action finaliza = () => final();
            string vez = Jogo.VerificarVez(Convert.ToInt32(dadosJogador[0]), dadosJogador[1]);
            if (vez.Substring(0, 1) == "E") {
                Invoke(finaliza);
                keepRunning = false;
            }
            else
            {
                frmTabuleiro.limparFabricas(compras[k].IdFabrica);
                btnListarCentro_Click(null, null);
                Debug.Print("termina compra");
            }
        }
    }
}
