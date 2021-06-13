using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5_block_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics art = Graphics.FromImage(img);
            Pen pen = new Pen(Color.Black,5);
            art.DrawPie(pen,10,10,200,300,-135,90);
            art.DrawArc(pen,10,150,200,200,45,90);
            art.DrawLine(pen,40,320,180,320);
            Point a1 = new Point(300,10);
            Point a2 = new Point(300, 210);
            Point a3 = new Point(500, 210);
            Point a4 = new Point(500, 10);
            Point[] square = { a1, a2, a3, a4 };
            art.DrawPolygon(pen,square);
            Point q1 = new Point(300, 300);
            Point q2 = new Point(300, 350);
            Point q3 = new Point(500, 350);
            Point[] triangle = { q1, q2, q3 };
            SolidBrush brush = new SolidBrush(Color.Red);
            art.FillPolygon(brush, triangle);
            art.DrawPolygon(pen,triangle);
            pictureBox1.Image = img;



        }
    }
}
