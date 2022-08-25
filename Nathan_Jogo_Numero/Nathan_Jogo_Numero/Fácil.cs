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
    public partial class Fácil : Form
    {
        //Criando uma variavel global
        int contador;

        public Fácil()
        {
            InitializeComponent();
        }
        //Funções
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
               button16.Text == "")
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

            int[] bnum = new int[16];
            int i, j, verificalinha;
            Boolean flag = false;

            i = 1;
            do
            {
                Random rnd = new Random(); //é um programa que coloca as coias de forma randomica na tela

                verificalinha = Convert.ToInt32((rnd.Next(0, 15)) + 1);

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

            } while (i <= 15);

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
            button16.Text = "";

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
            var inicio = new Form1();
            inicio.Show();
        }

        private void Fácil_Load(object sender, EventArgs e)
        {
            Misturar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Troca com 2 e 5
            VerificarVazio(button1, button2);
            VerificarVazio(button1, button5);
            VerificarNum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Troca com 1, 3 e 6
            VerificarVazio(button2, button1);
            VerificarVazio(button2, button3);
            VerificarVazio(button2, button6);
            VerificarNum();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Troca com 2, 4 e 7
            VerificarVazio(button3, button2);
            VerificarVazio(button3, button4);
            VerificarVazio(button3, button7);
            VerificarNum();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Troca com 3 e 8
            VerificarVazio(button4, button3);
            VerificarVazio(button4, button8);
            VerificarNum();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Troca com 1, 6 e 9
            VerificarVazio(button5, button1);
            VerificarVazio(button5, button6);
            VerificarVazio(button5, button9);
            VerificarNum();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Troca com 2, 5, 7 e 10
            VerificarVazio(button6, button2);
            VerificarVazio(button6, button5);
            VerificarVazio(button6, button7);
            VerificarVazio(button6, button10);
            VerificarNum();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Troca com 3, 6, 8 e 11
            VerificarVazio(button7, button3);
            VerificarVazio(button7, button6);
            VerificarVazio(button7, button8);
            VerificarVazio(button7, button11);
            VerificarNum();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Troca com 4, 7 e 12
            VerificarVazio(button8, button4);
            VerificarVazio(button8, button7);
            VerificarVazio(button8, button12);
            VerificarNum();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Troca com 5, 10 e 13
            VerificarVazio(button9, button5);
            VerificarVazio(button9, button10);
            VerificarVazio(button9, button13);
            VerificarNum();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Troca com 6, 9, 11 e 14
            VerificarVazio(button10, button6);
            VerificarVazio(button10, button9);
            VerificarVazio(button10, button11);
            VerificarVazio(button10, button14);
            VerificarNum();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Troca com 7, 10, 12 e 15
            VerificarVazio(button11, button7);
            VerificarVazio(button11, button10);
            VerificarVazio(button11, button12);
            VerificarVazio(button11, button15);
            VerificarNum();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Troca com 8, 11 e vazio
            VerificarVazio(button12, button8);
            VerificarVazio(button12, button11);
            VerificarVazio(button12, button16);
            VerificarNum();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Troca com 9 e 14
            VerificarVazio(button13, button9);
            VerificarVazio(button13, button14);
            VerificarNum();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Troca com 10, 13 e 15
            VerificarVazio(button14, button10);
            VerificarVazio(button14, button13);
            VerificarVazio(button14, button15);
            VerificarNum();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Troca com 11, 14 e vazio
            VerificarVazio(button15, button11);
            VerificarVazio(button15, button14);
            VerificarVazio(button15, button16);
            VerificarNum();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Troca com 12 e 15
            VerificarVazio(button16, button12);
            VerificarVazio(button16, button15);
            VerificarNum();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Misturar();
            label1.Text = "Clicks: ";

            this.Refresh();
            this.Hide();
            var NovoJogo = new Fácil();
            NovoJogo.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Misturar();
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
            button16.Text = "";

        }
    }
}
