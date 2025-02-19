using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        private int city_counter = 0;
        private int numeric_counter = 0;
        private int square_counter = 0;
        private int height_counter = 0;
        private int material_counter = 0;
        private List<int>counters = new List<int>();
      

        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
        
      
        private void clacl_button_Click(object sender, EventArgs e)
        {
            try
            {
                Flat flat = new Flat();
                Address address = new Address();

                if (this.city_getter.SelectedItem == null)
                {
                    throw new ArgumentNullException("Argument was null: City wasn't chosen");
                }
                
                string chosen_city = this.city_getter.SelectedItem.ToString();
                
               
               
                Cities city_enm = (Cities)Enum.Parse(typeof(Cities), chosen_city, true);
                address.City = city_enm;
                flat.Address = address;


                
                flat.Rooms = Convert.ToInt32(this.numericUpDown1.Value);

                if (this.square_getter.Text.ToString() == null)
                {
                    throw new ArgumentNullException("Argiment was null: Square metres field is empty");
                }
                flat.Square = Convert.ToDouble(this.square_getter.Text.ToString());

                if (this.brick_checker.Checked)
                {
                    flat.MaterialType = Materials.Brick;
                }
                else if (this.concrete_checker.Checked)
                {
                    flat.MaterialType = Materials.Concrete;
                }
                else
                {
                    throw new ArgumentNullException("Aegument was null: Material checker wasn't checked");
                }

                if (this.celing_getter.Text.ToString() == null)
                {
                    throw new ArgumentNullException("Celing height wasn't inputed");
                }
                try
                {
                    flat.Height = Convert.ToDouble(celing_getter.Text.ToString());

                }
                catch(Exception ex)
                {

                }



                BuildingCompany company = new BuildingCompany();

  

                this.result_box.Text = flat.CalculateCost().ToString();
            }
            catch (Exception ex)
            {
                this.progressBar1.Value = 0;
                for(int i = 0; i < counters.Count; i++)
                {
                    counters[i] = 0;
                }
                Error err_form = new Error(ex.Message);
                err_form.ShowDialog();
                err_form.Dispose();
            }

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //methods for progress bar
        private void city_getter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (city_counter == 0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }

            city_counter++;

        }

        private void square_getter_TextChanged(object sender, EventArgs e)
        {
          
            if(square_counter==0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }
            square_counter++;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numeric_counter == 0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }
            numeric_counter++;
        }

        private void celing_getter_TextChanged(object sender, EventArgs e)
        {
            if (height_counter == 0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }
            height_counter++;
        }

        private void brick_checker_CheckedChanged(object sender, EventArgs e)
        {
            if (material_counter == 0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }
            material_counter++;
        }

        private void concrete_checker_CheckedChanged(object sender, EventArgs e)
        {
            if (material_counter == 0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }
            material_counter++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            counters.Add(city_counter);
            counters.Add(height_counter);
            counters.Add(numeric_counter);
            counters.Add(square_counter);
            counters.Add(material_counter);
        }
    }
}
