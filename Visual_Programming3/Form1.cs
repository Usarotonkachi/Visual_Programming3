using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Programming3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int weight = int.Parse(textBox1.Text);
                int height = int.Parse(textBox2.Text);

                double bmi = weight / Math.Pow(height, 2) * 703;
                label3.Text = "BMI: " + bmi.ToString();
                if(bmi < 18.5)
                {
                    label4.Text = "Status: underweight";
                }
                else
                {
                    if(bmi > 25)
                    {
                        label4.Text = "Status: overweight";
                    }
                    else
                    {
                        label4.Text = "Status: optimal";
                    }
                }
            }
            catch { }
            
        }
    }
}
