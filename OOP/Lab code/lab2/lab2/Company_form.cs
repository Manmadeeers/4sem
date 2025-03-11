using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab2
{
    public partial class Company_form : Form
    {
       
        private bool isValidForm = true;
        public Company_form()
        {
            InitializeComponent();
        }

        private void name_getter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Main.instance.FLAT.Company.Name = this.name_getter.Text.ToString();
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message,"Name getter field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
        }

        private void type_getter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Main.instance.FLAT.Company.Type = (CompanyType)this.type_getter.SelectedIndex;
            }
            catch(Exception ex)
            {
                this.type_getter.Text = "";
                Error err_form = new Error(ex.Message, "Type getter field");
                err_form.ShowDialog();
                err_form.Dispose(); 
            }
           
        }

        private void address_getter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Main.instance.FLAT.Company.Off_address = this.address_getter.Text.ToString();
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "address getter field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
               Main.instance.FLAT.Company.Company_number = this.textBox1.Text.ToString();

            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "id getter field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            try
            {
                isValidForm = true;
                if (this.name_getter.Text.ToString()=="")
                {
                    throw new ArgumentException("Name getter field was null");
                }
                if(this.type_getter.SelectedItem == null)
                {
                    throw new ArgumentException("Type getter was null");
                }
                if (this.address_getter.Text == null) 
                {
                    throw new ArgumentException("Address getter was null");
                }
                if (this.textBox1.Text == null)
                {
                    throw new ArgumentException("Id getter was null");
                }
                if (this.type_getter.SelectedItem == null)
                {
                    throw new ArgumentNullException("Company type was not selected");
                }
            }
            catch(Exception ex)
            {
                isValidForm = false;                                                                          
                Error err_form = new Error(ex.Message, "Check empty fields");
                err_form.ShowDialog();
                err_form.Dispose();
            }

            if (isValidForm)
            {
                this.info_box.Text = Main.instance.FLAT.Company.ToString();
                this.continue_button.Visible = true;
            }
          
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Main.instance.Close();
        }

        private void continue_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
