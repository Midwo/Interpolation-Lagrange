using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Interpolation_Lagrange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        public float x1, x2, x3;
        public float y1, y2, y3;
        public float wyza;
        public float wyzb;
        public float wyzc;
        ArrayList listx = new ArrayList();
        ArrayList listy = new ArrayList();
        private void button3_Click(object sender, EventArgs e)
        {
            // listx.Add(2);
            // listy.Add(3);
            float poziomszczegółów = float.Parse(textBox1.Text);
            //   groupBox4.Text = listx[0].ToString();
            float x1n = x1;
            float x3n = x3;

            if (x1n > x3n)
            {

            }
            if (x1n < x3n)
            {

                for (float i = x1n; i <= x3n; i = i + poziomszczegółów)
                {
                    listx.Add(i);
                    listy.Add(wyza * (i * i) + ((wyzb) * i) + wyzc);
                }
             
                 
                chart2.Series["Funkcja"].ChartType = SeriesChartType.Point;
               int ilosc = listx.Count;
                for (int i = 0 ; i <= ilosc-1; i++)
                {
                    chart2.Series["Funkcja"].Points.AddXY(listx[i], listy[i]);
                }
                //for (int i = 0; i == listx.Count; i++)
                //{
                //    chart2.Series["Funkcja"].Points.AddXY(listx[i], listy[i]);
                //    groupBox4.Text = listx[4].ToString();
                //}
                //do
                //{
                //    chart2.Series["Funkcja"].Points.AddXY(listx[hmm], listy[hmm]);
                //    hmm += 1;
                //} while (hmm == ilosc);

            }

            //chart2.Series["Funkcja"].Points.AddXY(x1, y1);
            //chart2.Series["Funkcja"].Points.AddXY(x2, y2);
            //chart2.Series["Funkcja"].Points.AddXY(x3, y3);
            //chart2.Series["Funkcja"].ChartType = SeriesChartType.Point;
            }
        


        private void button1_Click(object sender, EventArgs e)
        {
            x1 = float.Parse(tx1.Text);
             x2 = float.Parse(tx2.Text);
             x3 = float.Parse(tx3.Text);
             y1 = float.Parse(ty1.Text);
             y2 = float.Parse(ty2.Text);
             y3 = float.Parse(ty3.Text);

            wyza = ((y1 / ((x1-x2)*(x1-x3))) + 
                (y2 / ((x2 - x1) * (x2 - x3))) 
                + (y3 / ((x3 - x1) * (x3 - x2))));

             wyzb = (
                ((y1 * (x2 + x3)) / ((x1 - x2) * (x1 - x3))) -
                ((y2 * (x1 + x3)) / ((x2 - x1) * (x2 - x3))) +
                 ((y3 * (x1 + x2)) / ((x3 - x1) * (x3 - x2))));

             wyzc = (
                ((y1 * x2 * x3) / ((x1 - x2) * (x1 - x3))) +
                ((y2 * x1 * x3) / ((x2 - x1) * (x2 - x3))) +
               ((y3 * x1 * x2) / ((x3 - x1) * (x3 - x2)))
                );
            la.Text = wyza.ToString();
            lb.Text = wyzb.ToString();
            lc.Text = wyzc.ToString();
            labelwzor.Text = "f(x) = "+la.Text+"(x * x) + ("+lb.Text+")x + "+lc.Text+"";
            // wzór  f(x)=ax2+bx+c  czyli a*(x1*x1)+((b)*x1) + c
            float licz1 = wyza * (x1 * x1) + ((wyzb) * x1) + wyzc;
            float licz2 = wyza * (x2 * x2) + ((wyzb) * x2) + wyzc;
            float licz3 = wyza * (x3 * x3) + ((wyzb) * x3) + wyzc;
            fx1y.Text = tx1.Text;
            fx2y.Text = tx2.Text;
            fx3y.Text = tx3.Text;
            fx1.Text = licz1.ToString();
            fx2.Text = licz2.ToString();
            fx3.Text = licz3.ToString();
          

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            chart1.Series["Funkcja"].Points.AddXY(x1, y1);
            chart1.Series["Funkcja"].Points.AddXY(x2, y2);
            chart1.Series["Funkcja"].Points.AddXY(x3, y3);
            chart1.Series["Funkcja"].ChartType = SeriesChartType.Spline;
        }
    }
}
