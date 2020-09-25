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
    public partial class FrmCadastro : Form
    {
        List<Jogador> J = new List<Jogador>();
        Jogador JJ;

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void cmdCadastro_Click(object sender, EventArgs e)
        {
            JJ = new Jogador();
            if (txtCadastro.Text == "")
                MessageBox.Show("Erro! Nome não inserido");
            else
            {
                JJ.name = txtCadastro.Text;
                J.Add(JJ);
                txtCadastro.Text = "";
                MessageBox.Show("Jogador cadastrado!");
            }
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            FrmMenu F = new FrmMenu();
            F.J = J;
            this.Hide();
            F.ShowDialog();
        }
    }
}
