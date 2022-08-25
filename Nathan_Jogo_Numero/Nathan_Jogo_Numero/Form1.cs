using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nathan_Jogo_Numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nivel = new Fácil();
            nivel.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nivel = new medio();
            nivel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nivel = new dificil();
            nivel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Tem certeza que deseja sair, humano?", "Jogo dos numeros", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
