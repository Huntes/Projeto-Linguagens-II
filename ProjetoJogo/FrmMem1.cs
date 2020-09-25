using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;

namespace ProjetoJogo
{
    public partial class FrmMem1 : Form
    {
        int mov, click, cardFound, tIndex, Min = 0, Segundo = 0;
        int[] tag = new int[2];
        Image[] saveImage = new Image[9];
        List<string> Conc = new List<string>();
        public List<Jogador> J = new List<Jogador>();
        public Jogador JO = new Jogador();

        public FrmMem1()
        {
            InitializeComponent();
            Init();
        }

        /* Salvando imagens originais e atualizar cardback */
        private void Init()
        {
            foreach(PictureBox item in Controls.OfType<PictureBox>())
            {
                tIndex = int.Parse(String.Format("{0}",item.Tag));
                saveImage[tIndex] = item.Image;
                item.Image = Properties.Resources.back;
                item.Enabled = true;
            }
            embaralharPosicoes();
        }

        /* Embaralhando as posições verificando as tags */
        private void embaralharPosicoes()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>()) {
                Random Aleatorio = new Random();

                int[] PosiX = { 91, 266, 441, 616, 791, 966 };
                int[] PosiY = { 97, 255, 412 };

            Repeat:
                var GuardaX = PosiX[Aleatorio.Next(0, PosiX.Length)];
                var GuardaY = PosiY[Aleatorio.Next(0, PosiY.Length)];

                string verifica = GuardaX.ToString() + GuardaY.ToString();

                if (Conc.Contains(verifica))
                {
                    goto Repeat;
                }
                else
                {
                    item.Location = new Point(GuardaX, GuardaY);
                    Conc.Add(verifica);
                }
            }

        }

        /* Identificação do acerto ou erro */
        private void imageClick(Object sender, EventArgs e)
        {
            bool tagFound = false;
            PictureBox pic = (PictureBox)sender;
            click++;
            tIndex = int.Parse(string.Format("{0}", pic.Tag));
            pic.Image = saveImage[tIndex];
            pic.Refresh();

            if (click == 1)
            {
                tag[0] = int.Parse(string.Format("{0}", pic.Tag));
            } else if (click == 2) {
                mov++;
                lblMovimentos.Text = "Movimentos: " + mov.ToString();
                tag[1] = int.Parse(string.Format("{0}", pic.Tag));
                tagFound = checkPar();
                Desvira(tagFound);
            }           
        }

        /* Verifica se a tag das cartas é igual */
        private bool checkPar()
        {
            click = 0;
            if (tag[0] == tag[1])
                return true;
            return false;
        }

        /* Inicia o jogo */
        private void cmdJogar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            string nome = cbJogadores.Text;
            JO = J.FirstOrDefault(x => x.name == nome);
        }

        /* Registra o tempo e converte */
        private void timer1_Tick(object sender, EventArgs e)
        {
            Segundo++;
            if (Segundo > 59)
            {
                Segundo = 0;
                Min++;
            }
            lblTempo.Text = $"{Convert0(Min)}:{Convert0(Segundo)}";           
        }

        /* Adiciona 0 */
        private string Convert0(int num)
        {
            if (num > 9)
                return num.ToString();
            return $"0{num.ToString()}";
        }

        /* Efetua o processo de virar e desvirar a carta */
        private void Desvira(bool check)
        {
            Thread.Sleep(500);

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(string.Format("{0}", item.Tag)) == tag[0] ||
                    int.Parse(string.Format("{0}", item.Tag)) == tag[1]){
                    
                    if (check == true)
                    {
                        item.Enabled = false;
                        cardFound++;
                    }
                    else
                    {
                        item.Image = Properties.Resources.back;
                        item.Refresh();
                    }
                }
            }
            finalGame();
        }

        /* Finaliza o jogo e limpa as opções */
        private void finalGame()
        {           
            if (cardFound == (saveImage.Length * 2))
            {
                timer1.Enabled = false;
                MessageBox.Show("Você finalizou o jogo com " + mov.ToString() + " movimentos");
                DialogResult mensagem = MessageBox.Show("Deseja jogar novamente ? ", "Caixa de pergunta", MessageBoxButtons.YesNo);           
           
                if (mensagem == DialogResult.Yes)
                {
                    click = 0; mov = 0; cardFound = 0; Min = 0; Segundo = 0;
                    Conc.Clear();
                    Init();
                    timer1.Enabled = true;
                    lblMovimentos.Text = "Movimentos: ";
                } 
                else if (mensagem == DialogResult.No){
                    JO.pontos = mov;
                    JO.tempo = $"{Convert0(Min)}:{Convert0(Segundo)}";
                    foreach (var item in J)
                    {
                        if (item.name == JO.name)
                        {
                            item.pontos = JO.pontos;
                            item.tempo = JO.tempo;
                        }
                    }
                    notifyIcon1.ShowBalloonTip(15,"Parabéns","Pontuação adicionada ao Ranking",ToolTipIcon.Info);
                    MessageBox.Show("Obrigado por jogar o jogo =)");
                    FrmMenu F = new FrmMenu();
                    F.J = J;
                    this.Hide();
                    F.ShowDialog();
                }
            }
        }

        /* Adiciona os dados à lista do combobox*/
        private void FrmMem1_Load(object sender, EventArgs e)
        {
            foreach (var item in J)
            {
                cbJogadores.Items.Add(item.name);
            }
        }
    }
}
