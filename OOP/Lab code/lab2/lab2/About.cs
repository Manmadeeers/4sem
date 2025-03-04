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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.version_name.Text += Main.instance.Version.ToString();
            this.developer_name.Text += Main.instance.Developer.ToString();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
