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
    public partial class Error : Form
    {
        public Error(string message,string addition)
        {
            InitializeComponent();
            this.error_text_field.Text = message+addition;
            
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Main.instance.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
