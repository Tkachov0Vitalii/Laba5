using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5_bloak_b
{
    public partial class Form1 : Form
    {
        
        Random random = new Random();
        SolidBrush brush;
        public   SolidBrush Brush()
        {
            brush = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            return brush;
        }
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics art = Graphics.FromImage(img);
            Pen pen = new Pen(Color.Black, 5); 
            Point a1 = new Point(200, 10);
            Point a2 = new Point(200, 510);
            Point a3 = new Point(500, 510);
            Point a4 = new Point(500, 10);
            Point[] rectangle = { a1, a2, a3, a4 };
            art.DrawLine(pen, 200, 50, 500, 50);
            art.DrawLine(pen, 200, 450, 500, 450);
            art.DrawPolygon(pen, rectangle);
            art.DrawEllipse(pen,340,15,20,20);
            art.DrawEllipse(pen, 330, 455, 50, 50);     
            art.FillEllipse(Brush(), 330, 455, 50, 50);
            art.FillEllipse(Brush(), 220, 100, 40, 40);
            art.FillEllipse(Brush(), 220, 150, 40, 40);
            art.FillEllipse(Brush(), 220, 200, 40, 40);
            art.FillEllipse(Brush(), 220, 250, 40, 40);
            art.FillEllipse(Brush(), 270, 200, 40, 40);
            art.FillEllipse(Brush(), 320, 100, 40, 40);
            art.FillEllipse(Brush(), 270, 100, 40, 40);
            art.FillEllipse(Brush(), 220, 300, 40, 40);
            art.FillEllipse(Brush(), 320, 200, 40, 40);
            pictureBox1.Image = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
