using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automata
{
    public partial class Form1 : Form
    {
        const int desp = 10;
        int dir = 1;
        int dir2 = 1;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Mover1()
        {

            if (dir == 1)
                pictureBox1.Left += desp;
            else {
                pictureBox1.Left -= desp;
            }
                
            
        }

        private void Mover2()
        {
            if (dir2 == 1)
                pictureBox2.Left -= desp;
            else
                pictureBox2.Left += desp;
            
        }

        private void Chocar()
        {
            if (pictureBox1.Left + pictureBox1.Width == pictureBox2.Left) { 
                dir = 2;
                dir2 = 2;
            }
            else if(pictureBox1.Left<=0)
            {
                dir = 1;
            }
            else if (pictureBox2.Left + pictureBox2.Width >= this.Width) 
                dir2 = 1;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Mover1();
            Mover2();
            Chocar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
