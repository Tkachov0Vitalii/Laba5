using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5_g_
{
    public partial class Form1 : Form
    {
        int x = 1;
        int speed = 15;
        int a = 5;
        int b = 350;
        int c = 125;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Bitmap bitmap = new Bitmap(2000,2000);
            Pen pen = new Pen(Color.Black,10);
            Graphics graphics =  Graphics.FromImage(bitmap);
            graphics.DrawLine(pen,0,620,1500,620);
            pictureBox3.Image = bitmap;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b -= speed - 5;
            a += speed;
            c -= speed-10;
            pictureBox1.Location = new Point(a, 450);

            pictureBox2.Location = new Point(pictureBox1.Location.X+c, b);
            if (b < 50)
            {
                c = 125;
                b = 350;
            }
            

            if (a > 1500)
            {
                a = 0;
                pictureBox1.Location = new Point(x, 450);
            }



        }


        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Location = new Point(x, 450);
            timer1.Interval = 150;


        }
    }
}
