using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nathan_Jogo_Numero
{
    public partial class medio : Form
    {
        int contador;
        public medio()
        {
            InitializeComponent();
        }
        public void VerificarVazio(Button Botão1, Button Botão2) //Segundo valor é o nome
        {
            if (Botão2.Text == "")
            {
                Botão2.Text = Botão1.Text;
                Botão1.Text = "";
            }
        }
        public void VerificarNum()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" &&
               button4.Text == "4" && button5.Text == "5" && button6.Text == "6" &&
               button7.Text == "7" && button8.Text == "8" && button9.Text == "9" &&
               button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
               button13.Text == "13" && button14.Text == "14" && button15.Text == "15" &&
               button16.Text == "16" && button17.Text == "17" && button18.Text == "18" && 
               button19.Text == "19" && button20.Text == "20" && button21.Text == "21" && 
               button22.Text == "22" && button23.Text == "23" && button24.Text == "24" && 
               button25.Text == "") 
            {
                this.Hide();
                var fim = new fim();
                fim.Show();
            }

            contador = contador + 1;
            label1.Text = "Clicks: " + contador;
        }
        public void Misturar()
        {
            //vetor com varios valores dentro de uma variavel 

            int[] bnum = new int[25];
            int i, j, verificalinha;
            Boolean flag = false;

            i = 1;
            do
            {
                Random rnd = new Random(); //é um programa que coloca as coias de forma randomica na tela

                verificalinha = Convert.ToInt32((rnd.Next(0, 24)) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == verificalinha)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = verificalinha;
                    i++;
                }

            } while (i <= 24);

            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            button9.Text = Convert.ToString(bnum[9]);
            button10.Text = Convert.ToString(bnum[10]);
            button11.Text = Convert.ToString(bnum[11]);
            button12.Text = Convert.ToString(bnum[12]);
            button13.Text = Convert.ToString(bnum[13]);
            button14.Text = Convert.ToString(bnum[14]);
            button15.Text = Convert.ToString(bnum[15]);
            button16.Text = Convert.ToString(bnum[16]);
            button17.Text = Convert.ToString(bnum[17]);
            button18.Text = Convert.ToString(bnum[18]);
            button19.Text = Convert.ToString(bnum[19]);
            button20.Text = Convert.ToString(bnum[20]);
            button21.Text = Convert.ToString(bnum[21]);
            button22.Text = Convert.ToString(bnum[22]);
            button23.Text = Convert.ToString(bnum[23]);
            button24.Text = Convert.ToString(bnum[24]);
            button25.Text = "";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void medio_Load(object sender, EventArgs e)
        {
            Misturar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificarVazio(button1, button2);
            VerificarVazio(button1, button6);
            VerificarNum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificarVazio(button2, button1);
            VerificarVazio(button2, button3);
            VerificarVazio(button2, button7);
            VerificarNum();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerificarVazio(button3, button2);
            VerificarVazio(button3, button4);
            VerificarVazio(button3, button8);
            VerificarNum();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerificarVazio(button4, button3);
            VerificarVazio(button4, button5);
            VerificarVazio(button4, button9);
            VerificarNum();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerificarVazio(button5, button4);
            VerificarVazio(button5, button10);
            VerificarNum();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerificarVazio(button6, button1);
            VerificarVazio(button6, button7);
            VerificarVazio(button6, button11);
            VerificarNum();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VerificarVazio(button7, button2);
            VerificarVazio(button7, button6);
            VerificarVazio(button7, button8);
            VerificarVazio(button7, button12);
            VerificarNum();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VerificarVazio(button8, button3);
            VerificarVazio(button8, button7);
            VerificarVazio(button8, button9);
            VerificarVazio(button8, button13);
            VerificarNum();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VerificarVazio(button9, button4);
            VerificarVazio(button9, button8);
            VerificarVazio(button9, button10);
            VerificarVazio(button9, button14);
            VerificarNum();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VerificarVazio(button10, button5);
            VerificarVazio(button10, button9);
            VerificarNum();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VerificarVazio(button11, button6);
            VerificarVazio(button11, button12);
            VerificarVazio(button11, button16);
            VerificarNum();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VerificarVazio(button12, button7);
            VerificarVazio(button12, button11);
            VerificarVazio(button12, button13);
            VerificarVazio(button12, button17);
            VerificarNum();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            VerificarVazio(button13, button8);
            VerificarVazio(button13, button12);
            VerificarVazio(button13, button14);
            VerificarVazio(button13, button18);
            VerificarNum();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VerificarVazio(button14, button9);
            VerificarVazio(button14, button13);
            VerificarVazio(button14, button15);
            VerificarVazio(button14, button19);
            VerificarNum();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            VerificarVazio(button15, button10);
            VerificarVazio(button15, button14);
            VerificarVazio(button15, button20);
            VerificarNum();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VerificarVazio(button16, button11);
            VerificarVazio(button16, button17);
            VerificarVazio(button16, button21);
            VerificarNum();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            VerificarVazio(button17, button12);
            VerificarVazio(button17, button16);
            VerificarVazio(button17, button18);
            VerificarVazio(button17, button22);
            VerificarNum();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            VerificarVazio(button18, button13);
            VerificarVazio(button18, button17);
            VerificarVazio(button18, button19);
            VerificarVazio(button18, button23);
            VerificarNum();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            VerificarVazio(button19, button14);
            VerificarVazio(button19, button18);
            VerificarVazio(button19, button20);
            VerificarVazio(button19, button24);
            VerificarNum();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            VerificarVazio(button20, button15);
            VerificarVazio(button20, button19);
            VerificarVazio(button20, button25);
            VerificarNum();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            VerificarVazio(button21, button16);
            VerificarVazio(button21, button22);
            VerificarNum();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            VerificarVazio(button22, button17);
            VerificarVazio(button22, button21);
            VerificarVazio(button22, button23);
            VerificarNum();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            VerificarVazio(button23, button18);
            VerificarVazio(button23, button22);
            VerificarVazio(button23, button24);
            VerificarNum();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            VerificarVazio(button24, button19);
            VerificarVazio(button24, button23);
            VerificarVazio(button24, button25);
            VerificarNum();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            VerificarVazio(button25, button20);
            VerificarVazio(button25, button24);
            VerificarNum();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
            var inicio = new Form1();
            inicio.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Misturar();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Misturar();
            label1.Text = "Clicks: ";

            this.Refresh();
            this.Hide();
            var NovoJogo = new medio();
            NovoJogo.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = Convert.ToString(16);
            button17.Text = Convert.ToString(17);
            button18.Text = Convert.ToString(18);
            button19.Text = Convert.ToString(19);
            button20.Text = Convert.ToString(20);
            button21.Text = Convert.ToString(21);
            button22.Text = Convert.ToString(22);
            button23.Text = Convert.ToString(23);
            button24.Text = Convert.ToString(24);
            button25.Text = "";
        }
    }
}
