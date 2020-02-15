using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminario1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (comboBox1.Text == ""))
            {
                MessageBox.Show("Ha de rellenar el formulario.");
            } 
            else
            {
                MessageBox.Show("Los datos se han rellenado correctamente.");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            comboBox1.Text = null;
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(ofdfoto.ShowDialog() == DialogResult.OK)
            {
                //Cargar la imagen. Picfoto es el PictureBox.                
                pictureBox1.Image = Image.FromFile(ofdfoto.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) 
            { 
                textBox2.Focus(); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close()
        }
    }
}
