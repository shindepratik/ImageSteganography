using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steganography
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

      
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Pwd_embed_files_ form = new Pwd_embed_files_();
            form.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pwd_embed_message_ form = new Pwd_embed_message_();
            form.Show();
            
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.IndianRed;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Transparent;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.IndianRed;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
