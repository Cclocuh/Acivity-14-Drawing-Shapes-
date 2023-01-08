using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Activity_14
{ 
    public partial class Form1 : Form
    {
   

       

        public Form1()
        {
            InitializeComponent();
        }


        private void Drawbutton_Click(object sender, EventArgs e)
        {
            

        }

        private void DrawPolygons_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 3);
            Graphics g = this.CreateGraphics();


            string selected = shapeListBox.SelectedItem.ToString();
            Pen p = new Pen(Color.Black, 2);

            if (selected == "Rectangle")
            {
                Rectangle shape = new Rectangle(500, 100, 200, 100);
                g.DrawRectangle(p, shape);

                if (checkBox1.Checked)
                {
                    MessageBox.Show("Rectangle", "01/08/2023");
                }
            }
            if(selected == "Circle")
            {
                g.DrawEllipse(p, 500, 100, 200, 200);

                if (checkBox1.Checked)
                {
                    MessageBox.Show("Circle", "01/08/2023");
                }
                
            }
            else if (selected == "Triangle")
            {
                Point point1 = new Point(350, 100);
                Point point2 = new Point(300, 200);
                Point point3 = new Point(400, 200);
                Point[] triangle = { point1, point2, point3 };
                g.DrawPolygon(p, triangle);

                if (checkBox1.Checked)
                {
                    MessageBox.Show("Triangle", "01/08/2023");
                }
            } 
            else if (selected == "Pentagon")
            {
                Point point1 = new Point(270, 315);
                Point point2 = new Point(350, 260);
                Point point3 = new Point(425, 315);
                Point point4 = new Point(400, 400);
                Point point5 = new Point(300, 400);
                Point[] pentagon = { point1, point2, point3, point4, point5 };
                g.DrawPolygon(p, pentagon);

                if (checkBox1.Checked)
                {
                    MessageBox.Show("Pentagon", "01/08/2023");
                }
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            Clearbutton.FindForm().Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
