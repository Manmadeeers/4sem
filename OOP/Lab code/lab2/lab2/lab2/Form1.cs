using System;
using System.CodeDom;
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
        private int specified_counter = 0;
        private int street_counter = 0;
        private int house_counter = 0;
        private int sub_counter = 0;
        private int flat_counter = 0;
      

        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private Cities ConvertToCitiesEnum(string chosen_city)
        {
            Cities city_enm = (Cities)Enum.Parse(typeof(Cities), chosen_city, true);
            return city_enm;
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
                
                address.City = this.ConvertToCitiesEnum(chosen_city);
                if (this.street_getter.Text == null)
                {
                    throw new ArgumentNullException("Street field value was null");
                }
                address.Street = street_getter.Text;

                if (this.house_getter.Text == null)
                {
                    throw new ArgumentNullException("House field value was null");
                }
                address.Building = Convert.ToInt32(this.house_getter.Text.ToString());

                if (sub_getter.Value != 0)
                {
                    address.SubBuilding = sub_getter.Value.ToString();
                }
                address.FlatNumber = Convert.ToInt32(this.flat_getter);


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

                if (this.rooms_specifier.CheckedItems.Count == 0)
                {
                    throw new ArgumentNullException("Additional variants were not checked");
                }
                flat.Additionals = rooms_specifier.CheckedItems.Count;



                BuildingCompany company = new BuildingCompany();

  

                this.result_box.Text = flat.CalculateCost().ToString();
            }
            catch (Exception ex)
            {
                this.progressBar1.Value = 0;
               
                Error err_form = new Error(ex.Message);
                 city_counter = 0;
                 numeric_counter = 0;
                 square_counter = 0;
                 height_counter = 0;
                 material_counter = 0;
                specified_counter = 0;
                street_counter = 0;
                house_counter = 0;
                sub_counter = 0;
                flat_counter = 0;
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

        private void rooms_specifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (specified_counter == 0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }
            specified_counter++;
        }

        private void street_getter_TextChanged(object sender, EventArgs e)
        {
            if (street_counter == 0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }
            street_counter++;
        }

        private void house_getter_TextChanged(object sender, EventArgs e)
        {
            if(house_counter == 0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }
            house_counter++;
        }

        private void sub_getter_ValueChanged(object sender, EventArgs e)
        {
            if(sub_counter == 0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }
            sub_counter++;
        }

        private void flat_getter_ValueChanged(object sender, EventArgs e)
        {
            if(flat_counter == 0)
            {
                this.progressBar1.Value += this.progressBar1.Step;
            }
            flat_counter++;
        }
    }
}
