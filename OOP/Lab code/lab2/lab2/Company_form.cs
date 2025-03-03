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
        private bool _name_changed = false;
        private bool _type_changed = false;
        private bool _address_changed = false;
        private bool _id_changed = false;
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

            if(!_name_changed)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _name_changed=true;
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
                Error err_form = new Error(ex.Message, "Type getter field");
                err_form.ShowDialog();
                err_form.Dispose(); 
            }
           
            if (!_type_changed)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _type_changed=true;
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
            if (!_address_changed)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _address_changed=true;
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
            if (!_id_changed)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _id_changed=true;
            }
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            try
            {
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
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "Check empty fields");
                err_form.ShowDialog();
                err_form.Dispose();
            }
            this.progressBar1.Value += 100 - this.progressBar1.Value;
            this.info_box.Text = Main.instance.FLAT.Company.ToString();
            this.continue_button.Visible = true;
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
