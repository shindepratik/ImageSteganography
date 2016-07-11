using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;


namespace Steganography
{
    public partial class TextStegano : Form
    {
        public TextStegano()
        {
            InitializeComponent();
        }

    Bitmap bmp = null;

        string extractedText = string.Empty;

        private void hideButton_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            string text = textBox1.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("The text you want to hide can't be empty", "Warning");

                return;
            }

            if (checkBox1.Checked)
            {
                if (textBox2.Text.Length < 6)
                {
                    MessageBox.Show("Please enter a password with at least 6 characters", "Warning");

                    return;
                }
                else
                {
                    text = Crypto.EncryptStringAES(text, textBox2.Text);
                }
            }

            bmp = SteganographyHelper.embedText(text, bmp);

            MessageBox.Show("Your text was hidden in the image successfully!", "Done");

            
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            string extractedText = SteganographyHelper.extractText(bmp);

            if (checkBox1.Checked)
            {
                try
                {
                    extractedText = Crypto.DecryptStringAES(extractedText, textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong password", "Error");

                    return;
                }
            }

            textBox1.Text = extractedText;
        }

        private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(open_dialog.FileName);
            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        }break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        } break;
                }

                
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text Files|*.txt";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save_dialog.FileName, textBox1.Text);
            }
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text Files|*.txt";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(open_dialog.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(open_dialog.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text Files|*.txt";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(open_dialog.FileName);
            }
        }

        private void hideButton_Click_1(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            string text = textBox1.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("The text you want to hide can't be empty", "Warning");

                return;
            }

            if (checkBox1.Checked)
            {
                if (textBox2.Text.Length < 4)
                {
                    MessageBox.Show("Please enter a password with at least 4 characters", "Warning");

                    return;
                }
                else
                {
                    text = Crypto.EncryptStringAES(text, textBox2.Text);
                }
            }

            bmp = SteganographyHelper.embedText(text, bmp);

            MessageBox.Show("Your text was hidden in the image successfully!", "Done");

            
        }

        private void extractButton_Click_1(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            string extractedText = SteganographyHelper.extractText(bmp);

            if (checkBox1.Checked)
            {
                try
                {
                    extractedText = Crypto.DecryptStringAES(extractedText, textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong password", "Error");

                    return;
                }
            }

            textBox1.Text = extractedText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        } break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        } break;
                }

                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void encryptCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void notesLabel_Click(object sender, EventArgs e)
        {

        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hideButton_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.Maroon;
        }

        private void hideButton_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Transparent; 
        }

        private void extractButton_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.Maroon;
        }

        private void extractButton_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.Transparent; 
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Maroon; 
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent; 
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Maroon;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Maroon; 
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.IndianRed;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.IndianRed;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
        }

        private void encryptCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox1.BackColor = Color.Black; 
        }

        private void encryptCheckBox_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.BackColor = Color.Transparent;
        }

        private void encryptCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            checkBox1.BackColor = Color.Black;
        }

        private void encryptCheckBox_MouseEnter(object sender, EventArgs e)
        {
            checkBox1.BackColor = Color.Black;
        }

        private void encryptCheckBox_MouseLeave_1(object sender, EventArgs e)
        {
            checkBox1.BackColor = Color.Transparent;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(open_dialog.FileName);
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text Files|*.txt";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(open_dialog.FileName);
            }
        }

        private void encryptCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            string text = textBox1.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("The text you want to hide can't be empty", "Warning");

                return;
            }

            if (checkBox1.Checked)
            {
                if (textBox2.Text.Length < 4)
                {
                    MessageBox.Show("Please enter a password with at least 4 characters", "Warning");

                    return;
                }
                else
                {
                    text = Crypto.EncryptStringAES(text, textBox2.Text);
                }
            }

            bmp = SteganographyHelper.embedText(text, bmp);

            MessageBox.Show("Your text was hidden in the image successfully!", "Done");

            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(open_dialog.FileName);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            string extractedText = SteganographyHelper.extractText(bmp);

            if (checkBox2.Checked)
            {
                try
                {
                    extractedText = Crypto.DecryptStringAES(extractedText, textBox4.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong password", "Error");

                    return;
                }
            }

            textBox3.Text = extractedText;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        } break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        } break;
                }


            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Maroon;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Maroon;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.Maroon;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Transparent;
        }

        private void button3_MouseEnter_1(object sender, EventArgs e)
        {
            button3.BackColor = Color.Maroon;
        }

        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.Maroon;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.Transparent;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.Maroon;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.Transparent;
        }

       
    }
}