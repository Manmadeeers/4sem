using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
   
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            double oboi = Calculator.CalculateOboiMetres(Convert.ToDouble(width_getter.Text), Convert.ToDouble(length_getter.Text), Convert.ToDouble(height_getter.Text));
            diplay_box.Text = oboi.ToString();

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
            Form1.Instance.Close();
        }
    }
}
