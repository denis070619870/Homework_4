// Написать программу масштабирования фигуры

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace CompGR13
{
    public partial class Form1 : Form
    {
        private Point[] Points = new Point[4];
        public Form1()
        {
            InitializeComponent();
        }
 
       private void Form1_Load(object sender, EventArgs e)
        {
            Points[0] = new Point(50,100);
            Points[1] = new Point(100,50);
            Points[2] = new Point(150,100);
            Points[3] = new Point(100,150);
            
 
            Draw();
 
        }
 
        private void Draw()
        {
            Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            Graphics g = Graphics.FromImage(bmp);
 
            g.DrawPolygon(Pens.Black, Points);
            
 
            pictureBox1.Image = bmp;
        }
 
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    MoveFigure(x: -5);
                    break;
                case Keys.Right:
                    MoveFigure(x: 5);
                    break;
                /*case Keys.Up:
                    MoveFigure(y: -5);
                    break;
                case Keys.Down:
                    MoveFigure(y: 5);
                    break;*/
                default:
                    break;
            }
 
            void MoveFigure(int x = 0, int y = 0)
            {
                for (int i = 0; i < Points.Length; i++)
                {
                    Points[i].X += x;
                    Points[i].Y += y;
                }
 
                Draw();
            }
 
            void ResizeFigure(int x = 0, int y = 0)
            {
                
            }
 
 
        }
 
    }
}
