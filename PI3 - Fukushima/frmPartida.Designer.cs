namespace PI3___Fukushima
{
    partial class FrmPartida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.btnDebugAtualizaDadosJogador = new System.Windows.Forms.Button();
            this.lblDadosJogador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBot = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboModeloCompra = new System.Windows.Forms.ComboBox();
            this.cboAzulejoCompra = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFabricasCompra = new System.Windows.Forms.ComboBox();
            this.btnComprarAzulejo = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblStopWatch = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTick = new System.Windows.Forms.Label();
            this.lblDadosJogadorAux = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(87, 255);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(100, 20);
            this.txtIdJogador.TabIndex = 6;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(87, 281);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaJogador.TabIndex = 7;
            // 
            // cboUsers
            // 
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(24, 343);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(163, 21);
            this.cboUsers.TabIndex = 13;
            this.cboUsers.DropDown += new System.EventHandler(this.cboUsers_DropDown);
            this.cboUsers.SelectedIndexChanged += new System.EventHandler(this.cboUsers_SelectedIndexChanged);
            // 
            // btnDebugAtualizaDadosJogador
            // 
            this.btnDebugAtualizaDadosJogador.Location = new System.Drawing.Point(24, 310);
            this.btnDebugAtualizaDadosJogador.Name = "btnDebugAtualizaDadosJogador";
            this.btnDebugAtualizaDadosJogador.Size = new System.Drawing.Size(163, 23);
            this.btnDebugAtualizaDadosJogador.TabIndex = 12;
            this.btnDebugAtualizaDadosJogador.Text = "Atualizar dadosJogador";
            this.btnDebugAtualizaDadosJogador.UseVisualStyleBackColor = true;
            this.btnDebugAtualizaDadosJogador.Click += new System.EventHandler(this.btnDebugAtualizaDadosJogador_Click);
            // 
            // lblDadosJogador
            // 
            this.lblDadosJogador.AutoSize = true;
            this.lblDadosJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosJogador.Location = new System.Drawing.Point(73, 189);
            this.lblDadosJogador.Name = "lblDadosJogador";
            this.lblDadosJogador.Size = new System.Drawing.Size(57, 13);
            this.lblDadosJogador.TabIndex = 10;
            this.lblDadosJogador.Text = "x,XXXXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // chkBot
            // 
            this.chkBot.AutoSize = true;
            this.chkBot.BackColor = System.Drawing.Color.Transparent;
            this.chkBot.Location = new System.Drawing.Point(120, 210);
            this.chkBot.Name = "chkBot";
            this.chkBot.Size = new System.Drawing.Size(66, 17);
            this.chkBot.TabIndex = 14;
            this.chkBot.Text = "Usar bot";
            this.chkBot.UseVisualStyleBackColor = false;
            this.chkBot.CheckedChanged += new System.EventHandler(this.chkBot_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(23, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Modelo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboModeloCompra
            // 
            this.cboModeloCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModeloCompra.FormattingEnabled = true;
            this.cboModeloCompra.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboModeloCompra.Location = new System.Drawing.Point(71, 105);
            this.cboModeloCompra.Name = "cboModeloCompra";
            this.cboModeloCompra.Size = new System.Drawing.Size(121, 21);
            this.cboModeloCompra.TabIndex = 5;
            this.cboModeloCompra.SelectedIndexChanged += new System.EventHandler(this.cboModeloCompra_SelectedIndexChanged);
            // 
            // cboAzulejoCompra
            // 
            this.cboAzulejoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAzulejoCompra.FormattingEnabled = true;
            this.cboAzulejoCompra.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboAzulejoCompra.Location = new System.Drawing.Point(71, 72);
            this.cboAzulejoCompra.Name = "cboAzulejoCompra";
            this.cboAzulejoCompra.Size = new System.Drawing.Size(121, 21);
            this.cboAzulejoCompra.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Azulejo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fabrica";
            // 
            // cboFabricasCompra
            // 
            this.cboFabricasCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFabricasCompra.FormattingEnabled = true;
            this.cboFabricasCompra.Location = new System.Drawing.Point(71, 40);
            this.cboFabricasCompra.Name = "cboFabricasCompra";
            this.cboFabricasCompra.Size = new System.Drawing.Size(121, 21);
            this.cboFabricasCompra.TabIndex = 1;
            // 
            // btnComprarAzulejo
            // 
            this.btnComprarAzulejo.Location = new System.Drawing.Point(23, 142);
            this.btnComprarAzulejo.Name = "btnComprarAzulejo";
            this.btnComprarAzulejo.Size = new System.Drawing.Size(169, 23);
            this.btnComprarAzulejo.TabIndex = 0;
            this.btnComprarAzulejo.Text = "Comprar";
            this.btnComprarAzulejo.UseVisualStyleBackColor = true;
            this.btnComprarAzulejo.Click += new System.EventHandler(this.btnComprarAzulejo_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.BackColor = System.Drawing.Color.Transparent;
            this.lblVez.Location = new System.Drawing.Point(25, 210);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(25, 13);
            this.lblVez.TabIndex = 18;
            this.lblVez.Text = "Vez";
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.AutoSize = true;
            this.lblStopWatch.BackColor = System.Drawing.Color.Transparent;
            this.lblStopWatch.Location = new System.Drawing.Point(26, 445);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(58, 13);
            this.lblStopWatch.TabIndex = 19;
            this.lblStopWatch.Text = "Stopwatch";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 390);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 23);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(23, 419);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.BackColor = System.Drawing.Color.Transparent;
            this.lblTick.Location = new System.Drawing.Point(26, 464);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(33, 13);
            this.lblTick.TabIndex = 23;
            this.lblTick.Text = "Ticks";
            // 
            // lblDadosJogadorAux
            // 
            this.lblDadosJogadorAux.AutoSize = true;
            this.lblDadosJogadorAux.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosJogadorAux.Location = new System.Drawing.Point(26, 189);
            this.lblDadosJogadorAux.Name = "lblDadosJogadorAux";
            this.lblDadosJogadorAux.Size = new System.Drawing.Size(41, 13);
            this.lblDadosJogadorAux.TabIndex = 23;
            this.lblDadosJogadorAux.Text = "Dados:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(16, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Comprar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(16, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Debug:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(25, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Alterar dados:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(25, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Timer:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(12, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 5);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(12, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 5);
            this.panel2.TabIndex = 28;
            // 
            // FrmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI3___Fukushima.Properties.Resources.Controles;
            this.ClientSize = new System.Drawing.Size(210, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDadosJogadorAux);
            this.Controls.Add(this.lblDadosJogador);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTick);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblStopWatch);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDebugAtualizaDadosJogador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkBot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboModeloCompra);
            this.Controls.Add(this.cboAzulejoCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnComprarAzulejo);
            this.Controls.Add(this.cboFabricasCompra);
            this.Name = "FrmPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " Fukushima";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPartida_FormClosing);
            this.Load += new System.EventHandler(this.FrmPartida_Load);
            this.LocationChanged += new System.EventHandler(this.FrmPartida_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAzulejoCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFabricasCompra;
        private System.Windows.Forms.Button btnComprarAzulejo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboModeloCompra;
        private System.Windows.Forms.Button btnDebugAtualizaDadosJogador;
        private System.Windows.Forms.Label lblDadosJogador;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.CheckBox chkBot;
        private System.Windows.Forms.Label lblStopWatch;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.Label lblDadosJogadorAux;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}