using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
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
                flat.Height = Convert.ToDouble(celing_getter.Text.ToString());

                BuildingCompany company = new BuildingCompany();

  

                this.result_box.Text = flat.CalculateCost().ToString();
            }
            catch (Exception ex)
            {
                Error err_form = new Error(ex.Message);
                err_form.ShowDialog();
                err_form.Dispose();
            }

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
