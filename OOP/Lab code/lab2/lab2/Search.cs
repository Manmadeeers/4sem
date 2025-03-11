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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enable_street_search_Click(object sender, EventArgs e)
        {
            if (this.enable_street_search.Text == "Enable")
            {
                this.street_searcher.Enabled = true;
                this.enable_street_search.Text = "Disable";
            }
            else if (this.enable_street_search.Text == "Disable")
            {
                this.street_searcher.Enabled= false;
                this.enable_street_search.Text= "Enable";
            }
        }
    }
}
