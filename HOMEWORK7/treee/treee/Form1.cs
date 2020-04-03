using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;

        double th1;
        double th2;
        double per1;
        double per2;
        int n;
        double leng;
        /*private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
        }*/
        private void tB_th1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void tB_th2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void cB_Color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void tB_per1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tB_per2_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void tB_leng_TextChanged(object sender, EventArgs e)
        {
            leng = double.Parse(tB_leng.Text);
        }
        void drawCayleyTree(int n0, double x0, double y0, double leng0, double th)
        {
            if (n0 == 0) return;
            double x1 = x0 + leng0 * Math.Cos(th);
            double y1 = y0 + leng0 * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n0 - 1, x1, y1, per1 * leng0, th + th1);
            drawCayleyTree(n0 - 1, x1, y1, per2 * leng0, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            switch (cB_Color.SelectedIndex)
            {
                case 0:
                    graphics.DrawLine(
               Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case 1:
                    graphics.DrawLine(
               Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case 2:
                    graphics.DrawLine(
               Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case 3:
                    graphics.DrawLine(
               Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case 4:
                    graphics.DrawLine(
               Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                default:
                    break;
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(n, 300, 310, leng, -Math.PI / 2);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            n = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
           tB_th1.Text = trackBar2.Value.ToString();
            th1 = trackBar1.Value*Math.PI/180; 
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            tB_th2.Text = trackBar3.Value.ToString();
            th2 = trackBar3.Value * Math.PI / 180;
        }

        private void trackBarper1_Scroll(object sender, EventArgs e)
        {
            tB_per1.Text = trackBarper1.Value.ToString();
            per1 = trackBarper1.Value *0.1;
        }

        private void trackBarper2_Scroll(object sender, EventArgs e)
        {
            tB_per2.Text = trackBarper2.Value.ToString();
            per2 = trackBarper2.Value *0.1;
        }

        private void trackBarleng_Scroll(object sender, EventArgs e)
        {
            tB_leng .Text= trackBarleng.Value.ToString();
            leng = trackBarleng.Value;
        }
    }
}

