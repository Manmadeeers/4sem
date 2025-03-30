using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab2
{
    public partial class Address_Form : Form
    {
        private bool _country_changed = false;
        private bool _city_changed = false;
        private bool _street_changed = false;
        private bool _building_changed = false;
        private bool _sub_checker_changed = false;
        private bool _apartment_changed = false;
        public bool _sub_changed = false;

        private bool isValidForm = true;

        public Address_Form()
        {
            InitializeComponent();
            //this.country_getter.
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Main.instance.Close();
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            try
            {
                isValidForm = true;
                if (this.country_getter.SelectedItem==null)
                {
                    throw new ArgumentNullException("Country was not selected");
                }
                //if (this.city_getter.Text.ToString() == "")
                //{
                //    throw new ArgumentNullException("City was not selected");
                //}
                if (this.street_getter.Text.ToString() == "")
                {
                    throw new ArgumentNullException("Street was not selected");
                }
                if (!this.has_sub.Checked && !this.no_sub.Checked)
                {
                    throw new ArgumentNullException("Sub building checkers were not checked");
                }
                var validationContext = new ValidationContext(Main.instance.FLAT.Address);
                var validationResults = new List<ValidationResult>();

                bool isValid = Validator.TryValidateObject(Main.instance.FLAT.Address, validationContext, validationResults);
                if (validationResults.Count != 0)
                {
                    throw new Exception(validationResults[0].ErrorMessage.ToString());
                }


            }
            catch(Exception ex)
            {
                isValidForm = false;
                Error err_form = new Error(ex.Message, "");
                err_form.ShowDialog();
                err_form.Dispose();
            }

            if (isValidForm)
            {
                if (this.sub_getter.Value == null)
                {
                    Main.instance.FLAT.Address.Sub_building = null;
                }
                this.info_box.Text = Main.instance.FLAT.Address.ToString();
                this.continue_button.Visible = true;
            }

        }

        private void has_sub_CheckedChanged(object sender, EventArgs e)
        {
            if (!_sub_checker_changed)
            {
                
                _sub_checker_changed |= true;
            }
            this.sub_getter.Enabled = true;
        }

        private void no_sub_CheckedChanged(object sender, EventArgs e)
        {
            if (!_sub_checker_changed)
            {
               
                _sub_checker_changed |= true;
            }
            this.sub_getter.Enabled = false;
        }

        private void country_getter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bool isValidCountry = false;
                foreach(string country in Enum.GetNames(typeof(Countries)))
                {
                    if (this.country_getter.SelectedItem.ToString() == country)
                    {
                        isValidCountry = true;
                        break;
                    }
                }
                if (!isValidCountry)
                {
                    throw new ArgumentException("Country entered incorrectly.\nCountry Getter Field");
                }
                Main.instance.FLAT.Address.Country = this.country_getter.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                this.country_getter.Text = "";
                Error err_form = new Error(ex.Message, "Country getter field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
          
            if (_country_changed == false)
            {
               
                _country_changed = true;
            }
        }

        private void city_getter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Main.instance.FLAT.Address.City = this.city_getter.Text.ToString();
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "City getter field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
           
           
        }

        private void street_getter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Main.instance.FLAT.Address.Street = this.street_getter.Text.ToString();
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "Street getter field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
           
            if (_street_changed == false)
            {
                
                _street_changed = true;
            }
        }

        private void building_getter_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Main.instance.FLAT.Address.Building = Convert.ToInt32(this.building_getter.Value.ToString());
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "Buildong number filed");
                err_form.ShowDialog();
                err_form.Dispose();
            }
           
            if (!_building_changed)
            {
                
                _building_changed = true;
            }
        }

        private void apartment_getter_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Main.instance.FLAT.Address.Apartment_number = Convert.ToInt32(this.apartment_getter.Value.ToString());
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "Apartment getter field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
            if (!_apartment_changed)
            {
               
                _apartment_changed = true;
            }
        }

        private void sub_getter_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Main.instance.FLAT.Address.Sub_building = Convert.ToInt32(this.sub_getter.Value.ToString());
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message,"Subbuilding getter field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
           
            if (!_sub_changed)
            {
               
                _sub_changed = true;
            }
        }

        private void continue_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
