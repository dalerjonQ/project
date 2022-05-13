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
    public partial class MENU1 : Form
    {
        public MENU1()
        {
            InitializeComponent();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
            Class2.text = label21.Text;
            if (checkBox1.Checked == true)
            {
                
                Class1.Text1 = gavai.Text;
                
            }
            if (checkBox2.Checked == true)
            {
                Class1.Text1 +="  " + karbonara.Text;

            }
            if (checkBox3.Checked == true)
            {
                Class1.Text1 += "  " + klassich.Text;

            }
            if (checkBox4.Checked == true)
            {
                Class1.Text1 += "  " + margarita.Text;

            }
            if (checkBox5.Checked == true)
            {
                Class1.Text1 += "  " + myasnaya.Text;

            }
            if (checkBox6.Checked == true)
            {
                Class1.Text1 += "  " + pepperoni.Text;

            }
            if (checkBox7.Checked == true)
            {
                Class1.Text1 += "  " + pesto.Text;

            }
            if (checkBox8.Checked == true)
            {

                Class1.Text1 += "  " + sirnaya.Text;
            }
            if (checkBox9.Checked == true)
            {
                Class1.Text1 += "  " + chetsira.Text;
            }
            if (checkBox11.Checked == true)
            {
                Class1.Text1 += "  " + bomboni.Text;

            }
            Class1.Text2 = dateTimePicker1.Text;
            Form4 f2 = new Form4();
            f2.Show();
            Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void MENU1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
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


            if (checkBox1.Checked == true)
            {
                b = b + gavai;
                Class1.Text = checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                b = b + karbonara;
                Class1.Text = checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                b = b + klassich;
                Class1.Text = checkBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                b = b + margarita;
                Class1.Text = checkBox4.Text;
            }
            if (checkBox5.Checked == true)
            {
                b = b + myasnaya;
                Class1.Text = checkBox5.Text;
            }
            if (checkBox6.Checked == true)
            {
                b = b + pepperoni;
                Class1.Text = checkBox6.Text;
            }
            if (checkBox7.Checked == true)
            {
                b = b + pesto;
                Class1.Text = checkBox7.Text;
            }
            if (checkBox8.Checked == true)
            {
                b = b + sirnaya;
                Class1.Text = checkBox8.Text;
            }
            if (checkBox9.Checked == true)
            {
                b = b + chetsira;
                Class1.Text = checkBox9.Text;
            }
            if (checkBox11.Checked == true)
            {
                b = b + bomboni;
                Class1.Text = checkBox11.Text;
            }
            label21.Text = Convert.ToString(b+ " ₽");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
            Hide();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
