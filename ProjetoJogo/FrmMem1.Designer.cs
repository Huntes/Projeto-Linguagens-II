namespace ProjetoJogo
{
    partial class FrmMem1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMem1));
            this.lblMovimentos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.cbJogadores = new System.Windows.Forms.ComboBox();
            this.cmdJogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovimentos
            // 
            this.lblMovimentos.AutoSize = true;
            this.lblMovimentos.BackColor = System.Drawing.Color.Transparent;
            this.lblMovimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimentos.Location = new System.Drawing.Point(87, 610);
            this.lblMovimentos.Name = "lblMovimentos";
            this.lblMovimentos.Size = new System.Drawing.Size(256, 20);
            this.lblMovimentos.TabIndex = 18;
            this.lblMovimentos.Text = "Quantidade de Movimentações";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(974, 610);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(0, 16);
            this.lblTempo.TabIndex = 19;
            // 
            // cbJogadores
            // 
            this.cbJogadores.FormattingEnabled = true;
            this.cbJogadores.Location = new System.Drawing.Point(91, 52);
            this.cbJogadores.Name = "cbJogadores";
            this.cbJogadores.Size = new System.Drawing.Size(169, 21);
            this.cbJogadores.TabIndex = 20;
            // 
            // cmdJogar
            // 
            this.cmdJogar.Location = new System.Drawing.Point(275, 44);
            this.cmdJogar.Name = "cmdJogar";
            this.cmdJogar.Size = new System.Drawing.Size(104, 34);
            this.cmdJogar.TabIndex = 21;
            this.cmdJogar.Text = "Jogar";
            this.cmdJogar.UseVisualStyleBackColor = true;
            this.cmdJogar.Click += new System.EventHandler(this.cmdJogar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(88, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "SELECIONE O JOGADOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoJogo.Properties.Resources.C;
            this.pictureBox1.Location = new System.Drawing.Point(91, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "0";
            this.pictureBox1.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoJogo.Properties.Resources.C;
            this.pictureBox2.Location = new System.Drawing.Point(266, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "0";
            this.pictureBox2.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjetoJogo.Properties.Resources.C_;
            this.pictureBox3.Location = new System.Drawing.Point(441, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 142);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "1";
            this.pictureBox3.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjetoJogo.Properties.Resources.C_;
            this.pictureBox4.Location = new System.Drawing.Point(616, 97);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(169, 142);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "1";
            this.pictureBox4.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProjetoJogo.Properties.Resources.Python;
            this.pictureBox5.Location = new System.Drawing.Point(791, 97);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(169, 142);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "2";
            this.pictureBox5.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProjetoJogo.Properties.Resources.Python;
            this.pictureBox6.Location = new System.Drawing.Point(966, 97);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(169, 142);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "2";
            this.pictureBox6.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ProjetoJogo.Properties.Resources.Swift;
            this.pictureBox7.Location = new System.Drawing.Point(91, 255);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(169, 142);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "3";
            this.pictureBox7.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::ProjetoJogo.Properties.Resources.Swift;
            this.pictureBox8.Location = new System.Drawing.Point(266, 255);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(169, 142);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "3";
            this.pictureBox8.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::ProjetoJogo.Properties.Resources.Flutter;
            this.pictureBox9.Location = new System.Drawing.Point(441, 255);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(169, 142);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "4";
            this.pictureBox9.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::ProjetoJogo.Properties.Resources.Flutter;
            this.pictureBox10.Location = new System.Drawing.Point(616, 255);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(169, 142);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "4";
            this.pictureBox10.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::ProjetoJogo.Properties.Resources._1200px_React_icon_svg;
            this.pictureBox11.Location = new System.Drawing.Point(791, 255);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(169, 142);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "5";
            this.pictureBox11.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::ProjetoJogo.Properties.Resources._1200px_React_icon_svg;
            this.pictureBox12.Location = new System.Drawing.Point(966, 255);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(169, 142);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "5";
            this.pictureBox12.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::ProjetoJogo.Properties.Resources._1200px_Ruby_logo_svg;
            this.pictureBox13.Location = new System.Drawing.Point(91, 412);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(169, 142);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "6";
            this.pictureBox13.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::ProjetoJogo.Properties.Resources._1200px_Ruby_logo_svg;
            this.pictureBox14.Location = new System.Drawing.Point(266, 412);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(169, 142);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "6";
            this.pictureBox14.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::ProjetoJogo.Properties.Resources.Javascript_shield;
            this.pictureBox15.Location = new System.Drawing.Point(441, 412);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(169, 142);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "7";
            this.pictureBox15.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::ProjetoJogo.Properties.Resources.Javascript_shield;
            this.pictureBox16.Location = new System.Drawing.Point(616, 412);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(169, 142);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 15;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "7";
            this.pictureBox16.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::ProjetoJogo.Properties.Resources._107F40E0_2305_435F_B280_E05E05042F4C__java_logo_500x307;
            this.pictureBox17.Location = new System.Drawing.Point(791, 412);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(169, 142);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 16;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "8";
            this.pictureBox17.Click += new System.EventHandler(this.imageClick);
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::ProjetoJogo.Properties.Resources._107F40E0_2305_435F_B280_E05E05042F4C__java_logo_500x307;
            this.pictureBox18.Location = new System.Drawing.Point(966, 412);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(169, 142);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 17;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "8";
            this.pictureBox18.Click += new System.EventHandler(this.imageClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Jogo da Memória";
            this.notifyIcon1.Visible = true;
            // 
            // FrmMem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoJogo.Properties.Resources.Background2;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdJogar);
            this.Controls.Add(this.cbJogadores);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblMovimentos);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMem1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.Load += new System.EventHandler(this.FrmMem1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMovimentos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.ComboBox cbJogadores;
        private System.Windows.Forms.Button cmdJogar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

