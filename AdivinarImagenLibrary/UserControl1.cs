using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinarImagenLibrary
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private int selecImagen;
        private string pokemon;
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            selecImagen = random.Next(1, 6);

            switch (selecImagen)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    pokemon = "charizard";
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    pokemon = "digglet";
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    pokemon = "lucario";
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    pokemon = "mew";
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    pokemon = "pikachu";
                    break;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == pokemon)
            {
                label3.Text = "Correcto!!";
            }
            else
            {
                label3.Text = "Prueba otra vez...";
            }
        }
    }
}
