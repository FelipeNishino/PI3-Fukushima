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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAzulejosFabricas = new System.Windows.Forms.ListBox();
            this.btnListarFabricas = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.btnDebugAtualizaDadosJogador = new System.Windows.Forms.Button();
            this.lblDadosJogador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkBot = new System.Windows.Forms.CheckBox();
            this.lstAzulejosCentro = new System.Windows.Forms.ListBox();
            this.btnListarCentro = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAzulejosFabricas);
            this.groupBox2.Controls.Add(this.btnListarFabricas);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fabricas";
            // 
            // lstAzulejosFabricas
            // 
            this.lstAzulejosFabricas.FormattingEnabled = true;
            this.lstAzulejosFabricas.Location = new System.Drawing.Point(6, 19);
            this.lstAzulejosFabricas.Name = "lstAzulejosFabricas";
            this.lstAzulejosFabricas.Size = new System.Drawing.Size(186, 160);
            this.lstAzulejosFabricas.TabIndex = 3;
            // 
            // btnListarFabricas
            // 
            this.btnListarFabricas.Location = new System.Drawing.Point(5, 185);
            this.btnListarFabricas.Name = "btnListarFabricas";
            this.btnListarFabricas.Size = new System.Drawing.Size(187, 23);
            this.btnListarFabricas.TabIndex = 2;
            this.btnListarFabricas.Text = "Listar";
            this.btnListarFabricas.UseVisualStyleBackColor = true;
            this.btnListarFabricas.Click += new System.EventHandler(this.btnListarFabricas_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(14, 454);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(55, 13);
            this.lblFeedback.TabIndex = 4;
            this.lblFeedback.Text = "Feedback";
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(88, 22);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(100, 20);
            this.txtIdJogador.TabIndex = 6;
            this.txtIdJogador.Text = "35";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(88, 46);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaJogador.TabIndex = 7;
            this.txtSenhaJogador.Text = "3D7A8C";
            // 
            // cboUsers
            // 
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(9, 108);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(179, 21);
            this.cboUsers.TabIndex = 13;
            this.cboUsers.DropDown += new System.EventHandler(this.cboUsers_DropDown);
            this.cboUsers.SelectedIndexChanged += new System.EventHandler(this.cboUsers_SelectedIndexChanged);
            // 
            // btnDebugAtualizaDadosJogador
            // 
            this.btnDebugAtualizaDadosJogador.Location = new System.Drawing.Point(9, 150);
            this.btnDebugAtualizaDadosJogador.Name = "btnDebugAtualizaDadosJogador";
            this.btnDebugAtualizaDadosJogador.Size = new System.Drawing.Size(179, 23);
            this.btnDebugAtualizaDadosJogador.TabIndex = 12;
            this.btnDebugAtualizaDadosJogador.Text = "Atualizar dadosJogador";
            this.btnDebugAtualizaDadosJogador.UseVisualStyleBackColor = true;
            this.btnDebugAtualizaDadosJogador.Click += new System.EventHandler(this.btnDebugAtualizaDadosJogador_Click);
            // 
            // lblDadosJogador
            // 
            this.lblDadosJogador.AutoSize = true;
            this.lblDadosJogador.Location = new System.Drawing.Point(85, 83);
            this.lblDadosJogador.Name = "lblDadosJogador";
            this.lblDadosJogador.Size = new System.Drawing.Size(74, 13);
            this.lblDadosJogador.TabIndex = 10;
            this.lblDadosJogador.Text = "dadosJogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkBot);
            this.groupBox5.Controls.Add(this.cboUsers);
            this.groupBox5.Controls.Add(this.txtIdJogador);
            this.groupBox5.Controls.Add(this.btnDebugAtualizaDadosJogador);
            this.groupBox5.Controls.Add(this.txtSenhaJogador);
            this.groupBox5.Controls.Add(this.lblDadosJogador);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(234, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 179);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Debug";
            // 
            // chkBot
            // 
            this.chkBot.AutoSize = true;
            this.chkBot.Location = new System.Drawing.Point(9, 79);
            this.chkBot.Name = "chkBot";
            this.chkBot.Size = new System.Drawing.Size(66, 17);
            this.chkBot.TabIndex = 14;
            this.chkBot.Text = "Usar bot";
            this.chkBot.UseVisualStyleBackColor = true;
            // 
            // lstAzulejosCentro
            // 
            this.lstAzulejosCentro.FormattingEnabled = true;
            this.lstAzulejosCentro.Location = new System.Drawing.Point(7, 19);
            this.lstAzulejosCentro.Name = "lstAzulejosCentro";
            this.lstAzulejosCentro.Size = new System.Drawing.Size(187, 160);
            this.lstAzulejosCentro.TabIndex = 13;
            // 
            // btnListarCentro
            // 
            this.btnListarCentro.Location = new System.Drawing.Point(7, 185);
            this.btnListarCentro.Name = "btnListarCentro";
            this.btnListarCentro.Size = new System.Drawing.Size(187, 23);
            this.btnListarCentro.TabIndex = 14;
            this.btnListarCentro.Text = "Listar";
            this.btnListarCentro.UseVisualStyleBackColor = true;
            this.btnListarCentro.Click += new System.EventHandler(this.btnListarCentro_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstAzulejosCentro);
            this.groupBox6.Controls.Add(this.btnListarCentro);
            this.groupBox6.Location = new System.Drawing.Point(234, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 221);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Centro";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.cboModeloCompra);
            this.groupBox7.Controls.Add(this.cboAzulejoCompra);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.cboFabricasCompra);
            this.groupBox7.Controls.Add(this.btnComprarAzulejo);
            this.groupBox7.Location = new System.Drawing.Point(17, 242);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(193, 179);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Comprar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Modelo";
            // 
            // cboModeloCompra
            // 
            this.cboModeloCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModeloCompra.FormattingEnabled = true;
            this.cboModeloCompra.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboModeloCompra.Location = new System.Drawing.Point(55, 108);
            this.cboModeloCompra.Name = "cboModeloCompra";
            this.cboModeloCompra.Size = new System.Drawing.Size(121, 21);
            this.cboModeloCompra.TabIndex = 5;
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
            this.cboAzulejoCompra.Location = new System.Drawing.Point(55, 62);
            this.cboAzulejoCompra.Name = "cboAzulejoCompra";
            this.cboAzulejoCompra.Size = new System.Drawing.Size(121, 21);
            this.cboAzulejoCompra.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Azulejo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fabrica";
            // 
            // cboFabricasCompra
            // 
            this.cboFabricasCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFabricasCompra.FormattingEnabled = true;
            this.cboFabricasCompra.Location = new System.Drawing.Point(55, 19);
            this.cboFabricasCompra.Name = "cboFabricasCompra";
            this.cboFabricasCompra.Size = new System.Drawing.Size(121, 21);
            this.cboFabricasCompra.TabIndex = 1;
            // 
            // btnComprarAzulejo
            // 
            this.btnComprarAzulejo.Location = new System.Drawing.Point(101, 150);
            this.btnComprarAzulejo.Name = "btnComprarAzulejo";
            this.btnComprarAzulejo.Size = new System.Drawing.Size(75, 23);
            this.btnComprarAzulejo.TabIndex = 0;
            this.btnComprarAzulejo.Text = "Comprar";
            this.btnComprarAzulejo.UseVisualStyleBackColor = true;
            this.btnComprarAzulejo.Click += new System.EventHandler(this.btnComprarAzulejo_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Location = new System.Drawing.Point(15, 434);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(25, 13);
            this.lblVez.TabIndex = 18;
            this.lblVez.Text = "Vez";
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.AutoSize = true;
            this.lblStopWatch.Location = new System.Drawing.Point(158, 455);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(35, 13);
            this.lblStopWatch.TabIndex = 19;
            this.lblStopWatch.Text = "label6";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(155, 429);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(255, 429);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(347, 429);
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
            this.lblTick.Location = new System.Drawing.Point(295, 455);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(35, 13);
            this.lblTick.TabIndex = 23;
            this.lblTick.Text = "label6";
            // 
            // FrmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 476);
            this.Controls.Add(this.lblTick);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStopWatch);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Azul - Fukushima";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPartida_FormClosing);
            this.Load += new System.EventHandler(this.FrmPartida_Load);
            this.LocationChanged += new System.EventHandler(this.FrmPartida_LocationChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListarFabricas;
        private System.Windows.Forms.ListBox lstAzulejosFabricas;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstAzulejosCentro;
        private System.Windows.Forms.Button btnListarCentro;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
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
    }
}