namespace ProjetoJogo
{
    partial class FrmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.cmdCadastro = new System.Windows.Forms.Button();
            this.cmdVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSIRA O NOME DO JOGADOR ";
            // 
            // txtCadastro
            // 
            this.txtCadastro.Location = new System.Drawing.Point(119, 122);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(309, 20);
            this.txtCadastro.TabIndex = 1;
            // 
            // cmdCadastro
            // 
            this.cmdCadastro.Location = new System.Drawing.Point(231, 175);
            this.cmdCadastro.Name = "cmdCadastro";
            this.cmdCadastro.Size = new System.Drawing.Size(75, 23);
            this.cmdCadastro.TabIndex = 2;
            this.cmdCadastro.Text = "Cadastrar";
            this.cmdCadastro.UseVisualStyleBackColor = true;
            this.cmdCadastro.Click += new System.EventHandler(this.cmdCadastro_Click);
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.Location = new System.Drawing.Point(423, 257);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(75, 23);
            this.cmdVoltar.TabIndex = 3;
            this.cmdVoltar.Text = "Menu";
            this.cmdVoltar.UseVisualStyleBackColor = true;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(546, 292);
            this.Controls.Add(this.cmdVoltar);
            this.Controls.Add(this.cmdCadastro);
            this.Controls.Add(this.txtCadastro);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.Button cmdCadastro;
        private System.Windows.Forms.Button cmdVoltar;
    }
}