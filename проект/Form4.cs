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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label4.Text = Class2.text;
            label5.Text = Class1.Text1;
            label7.Text = Class1.Text2;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.Text1 = " ";
            MENU1 f2 = new MENU1();
            f2.Show();
            Hide();
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog(); //Создание переменной и вызов диалога сохранения файла

            if (label5.Text != "" && label4.Text != "" && label7.Text != "" )                 // Проверка на пустые поля
            {
                if (f.ShowDialog() == DialogResult.OK)  //При нажатии на ОК выполняется код
                {
                    string[] saveArray = new string[9]; //Создаём массив
                    saveArray[0] = label5.Text;   //Вносим в массив данные из полей
                    saveArray[1] = label4.Text;
                    saveArray[2] = label7.Text;
                    System.IO.File.WriteAllLines(f.FileName.ToString(), saveArray, Encoding.GetEncoding(1251));     //Запись в файл
                    MessageBox.Show("Файл сохранен");   //Сообщение о сохранении
                }


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
            Hide();
        }
    }

}
