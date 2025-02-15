using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Instance.Close();
        }

        private void calc_button_Click(object sender, EventArgs e)
        {

            double volume = 0;
            volume = Calculator.CalulateRoomSquare(Convert.ToDouble(coverings_getter.Text.ToString()), Convert.ToDouble(wall_getter.Text.ToString()));
            if (using_metres.Checked)
            {
               
                square_label.Text = "cubic metres room";
            }
            else if (using_feet.Checked)
            {
                
                square_label.Text = "cubic feet room";
            }
            else
            {
                throw new ArgumentException("Invalid argument: mesurements weren't selected");
            }
             result_box.Text = volume.ToString();
        }
    }
}
