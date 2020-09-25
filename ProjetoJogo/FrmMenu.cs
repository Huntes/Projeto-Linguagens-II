using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJogo
{
    public partial class FrmMenu : Form
    {
        public List<Jogador> J = new List<Jogador>();
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastrarJogadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastro F = new FrmCadastro();
            this.Hide();
            F.ShowDialog();
        }

        private void jogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMem1 Men = new FrmMem1();
            Men.J = J;
            this.Hide();
            Men.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRanking R = new FrmRanking();
            R.J = J;
            this.Hide();
            R.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por jogar!");
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Huntes");
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
