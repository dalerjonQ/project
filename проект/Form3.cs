using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проект
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Multiline = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox1.Multiline = true;
            textBox1.Height = 250;


            int gavai = 439;
            int karbonara = 489;
            int klassich = 299;
            int margarita = 389;
            int myasnaya = 489;
            int pepperoni = 439;
            int pesto = 489;
            int sirnaya = 299;
            int chetsira = 489;
            int bomboni = 489;
            int b = 0;

            Random rnd = new Random();

            int value0 = rnd.Next(100, 200);  
            int value1 = rnd.Next(100, 200); 
            int value2 = rnd.Next(110, 165);
            int value3 = rnd.Next(120, 175);
            int value4 = rnd.Next(33, 200);
            int value5 = rnd.Next(150, 300);
            int value6 = rnd.Next(142, 200);
            int value7 = rnd.Next(112, 298);
            int value8 = rnd.Next(66, 266);
            int value9 = rnd.Next(142, 200);
            int sum0 = value0 * gavai;
            int sum1 = value1 * karbonara;
            int sum2 = value2 * klassich;
            int sum3 = value3 * margarita;
            int sum4 = value4 * myasnaya;
            int sum5 = value5 * pepperoni;
            int sum6 = value6 * pesto;
            int sum7 = value7 * sirnaya;
            int sum8 = value8 * chetsira;
            int sum9 = value9 * bomboni;

            textBox1.Text = value0.ToString() + "  Гавайских пицц - " + sum0.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox1.Text += value1.ToString() + "  пицц Карбонара - " + sum1.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox1.Text += value2.ToString() + "  Классических пицц - " + sum2.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox1.Text += value3.ToString() + "  пицц Маргарита - " + sum3.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox1.Text += value4.ToString() + "  Мясных пицц - " + sum4.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox1.Text += value5.ToString() + "  пицц Пепперони - " + sum5.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox1.Text += value6.ToString() + "  пицц Песто - " + sum6.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox1.Text += value7.ToString() + "  Сырных пицц - " + sum7.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox1.Text += value8.ToString() + "  пицц 4 сыра - " + sum8.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox1.Text += value9.ToString() + "  пицц Бомбони - " + sum9.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Multiline = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox2.Multiline = true;
            textBox2.Height = 235;
           
           


            int gavai = 439;
            int karbonara = 489;
            int klassich = 299;
            int margarita = 389;
            int myasnaya = 489;
            int pepperoni = 439;
            int pesto = 489;
            int sirnaya = 299;
            int chetsira = 489;
            int bomboni = 489;
            int b = 0;

            Random rnd = new Random();

            int value0 = rnd.Next(400, 998);
            int value1 = rnd.Next(400, 884);
            int value2 = rnd.Next(440, 1000);
            int value3 = rnd.Next(480, 1001);
            int value4 = rnd.Next(356, 1221);
            int value5 = rnd.Next(433, 1100);
            int value6 = rnd.Next(388, 1111);
            int value7 = rnd.Next(500, 866);
            int value8 = rnd.Next(432, 987);
            int value9 = rnd.Next(505, 999);
            int sum0 = value0 * gavai;
            int sum1 = value1 * karbonara;
            int sum2 = value2 * klassich;
            int sum3 = value3 * margarita;
            int sum4 = value4 * myasnaya;
            int sum5 = value5 * pepperoni;
            int sum6 = value6 * pesto;
            int sum7 = value7 * sirnaya;
            int sum8 = value8 * chetsira;
            int sum9 = value9 * bomboni;

            textBox2.Text = value0.ToString() + "  Гавайских пицц - " + sum0.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox2.Text += value1.ToString() + "  пицц Карбонара - " + sum1.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox2.Text += value2.ToString() + "  Классических пицц - " + sum2.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox2.Text += value3.ToString() + "  пицц Маргарита - " + sum3.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox2.Text += value4.ToString() + "  Мясных пицц - " + sum4.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox2.Text += value5.ToString() + "  пицц Пепперони - " + sum5.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox2.Text += value6.ToString() + "  пицц Песто - " + sum6.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox2.Text += value7.ToString() + "  Сырных пицц - " + sum7.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox2.Text += value8.ToString() + "  пицц 4 сыра - " + sum8.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox2.Text += value9.ToString() + "  пицц Бомбони - " + sum9.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox3.AcceptsReturn = true;
            this.textBox3.Multiline = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox3.Multiline = true;
            textBox3.Height = 250;


            int gavai = 439;
            int karbonara = 489;
            int klassich = 299;
            int margarita = 389;
            int myasnaya = 489;
            int pepperoni = 439;
            int pesto = 489;
            int sirnaya = 299;
            int chetsira = 489;
            int bomboni = 489;
            int b = 0;

            Random rnd = new Random();

            int value0 = rnd.Next(4800, 13304);
            int value1 = rnd.Next(4800, 13304);
            int value2 = rnd.Next(4800, 13304);
            int value3 = rnd.Next(4800, 13304);
            int value4 = rnd.Next(4800, 13304);
            int value5 = rnd.Next(4800, 13304);
            int value6 = rnd.Next(4800, 13304);
            int value7 = rnd.Next(4800, 13304);
            int value8 = rnd.Next(4800, 13304);
            int value9 = rnd.Next(4800, 13304);
            
            int sum0 = value0 * gavai; 
            int sum1 = value1 * karbonara;
            int sum2 = value2 * klassich;
            int sum3 = value3 * margarita;
            int sum4 = value4 * myasnaya;
            int sum5 = value5 * pepperoni;
            int sum6 = value6 * pesto;
            int sum7 = value7 * sirnaya;
            int sum8 = value8 * chetsira;
            int sum9 = value9 * bomboni;

            textBox3.Text = value0.ToString() + "  Гавайских пицц - " + sum0.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox3.Text += value1.ToString() + "  пицц Карбонара - " + sum1.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox3.Text += value2.ToString() + "  Классических пицц - " + sum2.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox3.Text += value3.ToString() + "  пицц Маргарита - " + sum3.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox3.Text += value4.ToString() + "  Мясных пицц - " + sum4.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox3.Text += value5.ToString() + "  пицц Пепперони - " + sum5.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox3.Text += value6.ToString() + "  пицц Песто - " + sum6.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox3.Text += value7.ToString() + "  Сырных пицц - " + sum7.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox3.Text += value8.ToString() + "  пицц 4 сыра - " + sum8.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;
            textBox3.Text += value9.ToString() + "  пицц Бомбони - " + sum9.ToString() + " руб. общая сумма проданных пицц данного образца" + Environment.NewLine;


        }
    }
}
