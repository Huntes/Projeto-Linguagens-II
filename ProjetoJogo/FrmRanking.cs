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
    public partial class FrmRanking : Form
    {
        public List<Jogador> J = new List<Jogador>();
        public FrmRanking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu FF = new FrmMenu();
            this.Hide();
            FF.ShowDialog();
        }

        private void FrmRanking_Load(object sender, EventArgs e)
        {
            foreach (var item in J)
            {
                lbRanking.Items.Add($"Nome: {item.name} Quantidade de Movimentos: {item.pontos} Tempo: {item.tempo}");
            }
        }
    }
}
