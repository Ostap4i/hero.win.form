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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Warrior");
            comboBox1.Items.Add("Mage");
            comboBox1.Items.Add("Archer");


            comboBox2.Items.Add("Warrior");
            comboBox2.Items.Add("Mage");
            comboBox2.Items.Add("Archer");

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form3(comboBox1.Text, comboBox2.Text);
            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }
    }
}
