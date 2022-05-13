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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Hide();
            MENU1 f2 = new MENU1();
            f2.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
