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
    }
}
