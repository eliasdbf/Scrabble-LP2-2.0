using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrabble
{
    public partial class Diccionario : Form
    {
        public Diccionario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(@"D:\Scrabble\Scrabble\reursos\Palabras.txt");
            string cadena;
            while ((cadena = streamReader.ReadLine()) != null)
            {
                if (textBox1.Text == cadena)
                {
                    MessageBox.Show("La Palabra buscada es correcta");
                }
                else
                {
                    pictureBox1.Visible = true;
                }
            }

        }

        private void PbCloseWindows_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbMinimizeWindows_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Diccionario_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\Scrabble\Scrabble\reursos\Gif\giphy (1).gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
