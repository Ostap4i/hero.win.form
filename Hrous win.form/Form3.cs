using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hrous_win.form
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string player1, string player2)
        {
            InitializeComponent();
            textBox1.Text = player1;
            textBox2.Text = player2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
