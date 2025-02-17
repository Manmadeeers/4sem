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
            double oboiAmount;
            int parketAmount;
            int lominatAmount;
            int plitkaAmount;
            try
            {
                if (metres_check.Checked)
                {
                    oboiAmount = Calculator.CalculateOboiMetres(Convert.ToDouble(width_getter.Text), Convert.ToDouble(length_getter.Text), Convert.ToDouble(height_getter.Text));
                    parketAmount = Calculator.CalculateParketMetres(Convert.ToDouble(width_getter.Text), Convert.ToDouble(length_getter.Text));
                    lominatAmount = Calculator.CalculateLominatMetres(Convert.ToDouble(length_getter.Text), Convert.ToDouble(width_getter.Text));
                    plitkaAmount = Calculator.CalculatePlitkaMetres(Convert.ToDouble(width_getter.Text), Convert.ToDouble(length_getter.Text));
                }
                else if (feet_check.Checked)
                {
                    oboiAmount = Calculator.CalculateOboiFeet(Convert.ToDouble(width_getter.Text), Convert.ToDouble(length_getter.Text), Convert.ToDouble(height_getter.Text));
                    parketAmount = Calculator.CalculateParketFeet(Convert.ToDouble(width_getter.Text), Convert.ToDouble(length_getter.Text));
                    lominatAmount = Calculator.CalculateLominatFeet(Convert.ToDouble(length_getter.Text), Convert.ToDouble(width_getter.Text));
                    plitkaAmount = Calculator.CalculatePlitkaFeet(Convert.ToDouble(width_getter.Text), Convert.ToDouble(length_getter.Text));
                }
                else
                {
                    throw new ArgumentException("Invalid arguments:Checkbox wasn't selected");
                }

                display_box.Text = $"You need: {oboiAmount} oboi roulets, {parketAmount} parket peaces or {lominatAmount} lominat peaces or {plitkaAmount} plitka peaces";
            }
            catch(Exception ex)
            {
                Form4 errForm = new Form4(ex.Message);
                errForm.ShowDialog();
                errForm.Dispose();
            }
           

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
            Form1.Instance.Close();
        }
    }
}
