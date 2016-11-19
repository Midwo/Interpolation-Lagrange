using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpolation_Lagrange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x1 = float.Parse(tx1.Text);
            float x2 = float.Parse(tx2.Text);
            float x3 = float.Parse(tx3.Text);
            float y1 = float.Parse(ty1.Text);
            float y2 = float.Parse(ty2.Text);
            float y3 = float.Parse(ty3.Text);

           float wyza = ((y1 / ((x1-x2)*(x1-x3))) + 
                (y2 / ((x2 - x1) * (x2 - x3))) 
                + (y3 / ((x3 - x1) * (x3 - x2))));

            float wyzb = (
                ((y1 * (x2 + x3)) / ((x1 - x2) * (x1 - x3))) -
                ((y2 * (x1 + x3)) / ((x2 - x1) * (x2 - x3))) +
                 ((y3 * (x1 + x2)) / ((x3 - x1) * (x3 - x2))));

            float wyzc = (
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
    }
}
