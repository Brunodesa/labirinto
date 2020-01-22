using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirinto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label36_Click(object sender, EventArgs e)
        {

        }

        private void Label48_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox1.Left -= 8;
                    break;
                case Keys.Right:
                    pictureBox1.Left += 8;
                    break;
                case Keys.Up:
                    pictureBox1.Top -= 8;
                    break;
                case Keys.Down:
                    pictureBox1.Top += 8;
                    break;
            }


        private void loose_Tick(object sender, EventArgs e)
            {
                if (pictureBox1.Bounds.IntersectsWith(label1.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy_2.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy_3.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy_4.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy_5.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy_6.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy_7.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy_8.Bounds) || pictureBox1.Bounds.IntersectsWith(enemy_9.Bounds))
                {


                }
            }
        }
    }
}
