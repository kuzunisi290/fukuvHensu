using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {
        int vx = 0;
        int vy = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left-= vx;
            label1.Top -= vy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vy = 10;
            vx = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vy = -10;
            vx = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = 10;
            vy =0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = -10;
            vy = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("葛西達也");
            timer1.Enabled = false;
        }
    }
}
