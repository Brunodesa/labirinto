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

        }




        private void loose_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Bounds.IntersectsWith(label1.Bounds) || pictureBox1.Bounds.IntersectsWith(label2.Bounds) || pictureBox1.Bounds.IntersectsWith(label3.Bounds) || pictureBox1.Bounds.IntersectsWith(label4.Bounds) || pictureBox1.Bounds.IntersectsWith(label5.Bounds) || pictureBox1.Bounds.IntersectsWith(label6.Bounds) || pictureBox1.Bounds.IntersectsWith(label7.Bounds) || pictureBox1.Bounds.IntersectsWith(label8.Bounds) || pictureBox1.Bounds.IntersectsWith(label9.Bounds) || pictureBox1.Bounds.IntersectsWith(label10.Bounds))
                if (pictureBox1.Bounds.IntersectsWith(label11.Bounds) || pictureBox1.Bounds.IntersectsWith(label12.Bounds) || pictureBox1.Bounds.IntersectsWith(label13.Bounds) || pictureBox1.Bounds.IntersectsWith(label14.Bounds) || pictureBox1.Bounds.IntersectsWith(label15.Bounds) || pictureBox1.Bounds.IntersectsWith(label16.Bounds) || pictureBox1.Bounds.IntersectsWith(label17.Bounds) || pictureBox1.Bounds.IntersectsWith(label18.Bounds) || pictureBox1.Bounds.IntersectsWith(label19.Bounds) || pictureBox1.Bounds.IntersectsWith(label20.Bounds))
                    if (pictureBox1.Bounds.IntersectsWith(label21.Bounds) || pictureBox1.Bounds.IntersectsWith(label22.Bounds) || pictureBox1.Bounds.IntersectsWith(label23.Bounds) || pictureBox1.Bounds.IntersectsWith(label24.Bounds) || pictureBox1.Bounds.IntersectsWith(label25.Bounds) || pictureBox1.Bounds.IntersectsWith(label26.Bounds) || pictureBox1.Bounds.IntersectsWith(label27.Bounds) || pictureBox1.Bounds.IntersectsWith(label28.Bounds) || pictureBox1.Bounds.IntersectsWith(label29.Bounds) || pictureBox1.Bounds.IntersectsWith(label30.Bounds))

                    {

                    }
        }
    }
}

