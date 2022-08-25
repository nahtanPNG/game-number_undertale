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
    public partial class dificil : Form
    {
        int contador;
        public dificil()
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
               button25.Text == "25" && button26.Text == "26" && button27.Text == "27" && 
               button28.Text == "28" && button29.Text == "29" && button30.Text == "30" && 
               button31.Text == "31" && button32.Text == "32" && button33.Text == "33" &&
               button34.Text == "34" && button35.Text == "35" && button36.Text == "")
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

            int[] bnum = new int[36];
            int i, j, verificalinha;
            Boolean flag = false;

            i = 1;
            do
            {
                Random rnd = new Random(); //é um programa que coloca as coias de forma randomica na tela

                verificalinha = Convert.ToInt32((rnd.Next(0, 35)) + 1);

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

            } while (i <= 35);

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
            button25.Text = Convert.ToString(bnum[25]);
            button26.Text = Convert.ToString(bnum[26]);
            button27.Text = Convert.ToString(bnum[27]);
            button28.Text = Convert.ToString(bnum[28]);
            button29.Text = Convert.ToString(bnum[29]);
            button30.Text = Convert.ToString(bnum[30]);
            button31.Text = Convert.ToString(bnum[31]);
            button32.Text = Convert.ToString(bnum[32]);
            button33.Text = Convert.ToString(bnum[33]);
            button34.Text = Convert.ToString(bnum[34]);
            button35.Text = Convert.ToString(bnum[35]);
            button36.Text = "";

        }

        private void dificil_Load(object sender, EventArgs e)
        {
            Misturar();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            VerificarVazio(button33, button27);
            VerificarVazio(button33, button32);
            VerificarVazio(button33, button34);
            VerificarNum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerificarVazio(button1, button2);
            VerificarVazio(button1, button7);
            VerificarNum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificarVazio(button2, button1);
            VerificarVazio(button2, button3);
            VerificarVazio(button2, button8);
            VerificarNum();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerificarVazio(button3, button2);
            VerificarVazio(button3, button4);
            VerificarVazio(button3, button9);
            VerificarNum();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerificarVazio(button4, button3);
            VerificarVazio(button4, button5);
            VerificarVazio(button4, button10);
            VerificarNum();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerificarVazio(button5, button4);
            VerificarVazio(button5, button6);
            VerificarVazio(button5, button11);
            VerificarNum();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerificarVazio(button6, button5);
            VerificarVazio(button6, button12);
            VerificarNum();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VerificarVazio(button7, button1);
            VerificarVazio(button7, button8);
            VerificarVazio(button7, button13);
            VerificarNum();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VerificarVazio(button8, button2);
            VerificarVazio(button8, button7);
            VerificarVazio(button8, button9);
            VerificarVazio(button8, button14);
            VerificarNum();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VerificarVazio(button9, button3);
            VerificarVazio(button9, button8);
            VerificarVazio(button9, button10);
            VerificarVazio(button9, button15);
            VerificarNum();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VerificarVazio(button10, button4);
            VerificarVazio(button10, button9);
            VerificarVazio(button10, button11);
            VerificarVazio(button10, button16);
            VerificarNum();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VerificarVazio(button11, button5);
            VerificarVazio(button11, button10);
            VerificarVazio(button11, button12);
            VerificarVazio(button11, button17);
            VerificarNum();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VerificarVazio(button12, button6);
            VerificarVazio(button12, button11);
            VerificarVazio(button12, button18);
            VerificarNum();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            VerificarVazio(button13, button7);
            VerificarVazio(button13, button14);
            VerificarVazio(button13, button19);
            VerificarNum();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VerificarVazio(button14, button8);
            VerificarVazio(button14, button13);
            VerificarVazio(button14, button15);
            VerificarVazio(button14, button20);
            VerificarNum();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            VerificarVazio(button15, button9);
            VerificarVazio(button15, button14);
            VerificarVazio(button15, button16);
            VerificarVazio(button15, button21);
            VerificarNum();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VerificarVazio(button16, button10);
            VerificarVazio(button16, button15);
            VerificarVazio(button16, button17);
            VerificarVazio(button16, button22);
            VerificarNum();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            VerificarVazio(button17, button11);
            VerificarVazio(button17, button16);
            VerificarVazio(button17, button18);
            VerificarVazio(button17, button23);
            VerificarNum();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            VerificarVazio(button18, button12);
            VerificarVazio(button18, button17);
            VerificarVazio(button18, button24);
            VerificarNum();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            VerificarVazio(button19, button13);
            VerificarVazio(button19, button20);
            VerificarVazio(button19, button25);
            VerificarNum();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            VerificarVazio(button20, button14);
            VerificarVazio(button20, button19);
            VerificarVazio(button20, button21);
            VerificarVazio(button20, button26);
            VerificarNum();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            VerificarVazio(button21, button15);
            VerificarVazio(button21, button20);
            VerificarVazio(button21, button22);
            VerificarVazio(button21, button27);
            VerificarNum();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            VerificarVazio(button22, button16);
            VerificarVazio(button22, button21);
            VerificarVazio(button22, button23);
            VerificarVazio(button22, button28);
            VerificarNum();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            VerificarVazio(button23, button17);
            VerificarVazio(button23, button22);
            VerificarVazio(button23, button24);
            VerificarVazio(button23, button29);
            VerificarNum();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            VerificarVazio(button24, button18);
            VerificarVazio(button24, button23);
            VerificarVazio(button24, button30);
            VerificarNum();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            VerificarVazio(button25, button19);
            VerificarVazio(button25, button26);
            VerificarVazio(button25, button31);
            VerificarNum();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            VerificarVazio(button26, button20);
            VerificarVazio(button26, button25);
            VerificarVazio(button26, button27);
            VerificarVazio(button26, button32);
            VerificarNum();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            VerificarVazio(button27, button21);
            VerificarVazio(button27, button26);
            VerificarVazio(button27, button28);
            VerificarVazio(button27, button33);
            VerificarNum();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            VerificarVazio(button28, button22);
            VerificarVazio(button28, button27);
            VerificarVazio(button28, button29);
            VerificarVazio(button28, button34);
            VerificarNum();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            VerificarVazio(button29, button23);
            VerificarVazio(button29, button28);
            VerificarVazio(button29, button30);
            VerificarVazio(button29, button35);
            VerificarNum();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            VerificarVazio(button30, button24);
            VerificarVazio(button30, button29);
            VerificarVazio(button30, button36);
            VerificarNum();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            VerificarVazio(button31, button25);
            VerificarVazio(button31, button32);
            VerificarNum();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            VerificarVazio(button32, button26);
            VerificarVazio(button32, button31);
            VerificarVazio(button32, button33);
            VerificarNum();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            VerificarVazio(button34, button28);
            VerificarVazio(button34, button33);
            VerificarVazio(button34, button35);
            VerificarNum();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            VerificarVazio(button35, button29);
            VerificarVazio(button35, button34);
            VerificarVazio(button35, button36);
            VerificarNum();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            VerificarVazio(button36, button30);
            VerificarVazio(button36, button35);
            VerificarNum();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Misturar();
            label1.Text = "Clicks: ";

            this.Refresh();
            this.Hide();
            var NovoJogo = new dificil();
            NovoJogo.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Misturar();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
            var inicio = new Form1();
            inicio.Show();
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
            button25.Text = Convert.ToString(25);
            button26.Text = Convert.ToString(26);
            button27.Text = Convert.ToString(27);
            button28.Text = Convert.ToString(28);
            button29.Text = Convert.ToString(29);
            button30.Text = Convert.ToString(30);
            button31.Text = Convert.ToString(31);
            button32.Text = Convert.ToString(32);
            button33.Text = Convert.ToString(33);
            button34.Text = Convert.ToString(34);
            button35.Text = Convert.ToString(35);
            button36.Text = "";
        }
    }
}
