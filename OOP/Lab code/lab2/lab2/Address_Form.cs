using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Address_Form : Form
    {
        private bool _country_changed = false;
        public Address_Form()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Main.instance.Close();
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void has_sub_CheckedChanged(object sender, EventArgs e)
        {
            this.sub_getter.Enabled = true;
        }

        private void no_sub_CheckedChanged(object sender, EventArgs e)
        {
            this.sub_getter.Enabled = false;
        }

        private void country_getter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.instance.FLAT.Address
            if (_country_changed == false)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _country_changed = true;
            }
        }
    }
}
