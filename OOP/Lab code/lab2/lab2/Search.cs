using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab2
{
    public partial class Search : Form
    {
        private Regex _city_regex = new Regex(@"^[A-Za-z/s]{2,}$");
        private Regex _street_regex = new Regex(@"^[A-Za-z0-9/s]{2,}$");
        private Regex _range_regex = new Regex(@"^[0-9]{4,10}$");
        private Regex _floor_regex = new Regex(@"^[0-9]{1,2}$");
        //private Regex _first_letter_regex = new Regex(@"^[]")

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
                this.street_searcher.Enabled = false;
                this.enable_street_search.Text = "Enable";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enable_city_search_Click(object sender, EventArgs e)
        {
            if (this.enable_city_search.Text == "Enable")
            {
                this.city_searcher.Enabled = true;
                this.enable_city_search.Text = "Disable";
            }
            else if (this.enable_city_search.Text == "Disable")
            {
                this.city_searcher.Enabled = false;
                this.enable_city_search.Text = "Enable";
            }
        }

        private void enable_floor_search_Click(object sender, EventArgs e)
        {
            if (this.enable_floor_search.Text == "Enable")
            {
                this.floor_searcher.Enabled = true;
                this.enable_floor_search.Text = "Disable";
            }
            else
            {
                this.enable_floor_search.Text = "Enable";
                this.floor_searcher.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enable_price_search_Click(object sender, EventArgs e)
        {
            if (this.enable_price_search.Text == "Enable")
            {
                this.lower_range.Enabled = true;
                this.upper_range.Enabled = true;
                this.enable_price_search.Text = "Disable";
            }
            else
            {
                this.lower_range.Enabled = false;
                this.upper_range.Enabled = false;
                this.enable_price_search.Text = "Enable";
            }
        }

        private void searchProcessor(bool streetEnabled,bool cityEnabled,bool floorEnabled, bool priceEnabled)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            bool regexPassed = true;
            try
            {
                if (this.street_searcher.Text.ToString() == ""&&this.street_searcher.Enabled)
                {
                    isValid = false;
                    throw new ArgumentNullException("Search by street was enabled but did not get the value");
                }
                if (this.floor_searcher.Text.ToString() == "" && this.floor_searcher.Enabled)
                {
                    isValid = false;
                    throw new ArgumentNullException("Search by floor was enabled but did not get the value");
                }
                if(this.city_searcher.Text.ToString() == "" && this.city_searcher.Enabled)
                {
                    isValid = false;
                    throw new ArgumentNullException("Srach by city was enabled but did not get the value");
                }
                if ((this.lower_range.Text.ToString() == "" || this.upper_range.Text.ToString() == "") && (this.lower_range.Enabled && this.upper_range.Enabled))
                {
                    isValid = false;
                    throw new ArgumentNullException("Srach by price range was enabled but did not get the value");
                }
            }
            catch(Exception ex)
            {
                Error err = new Error(ex.Message, "");
                err.ShowDialog();
                err.Dispose();
            }

            if (isValid)
            {
                try
                {

                    if (!_city_regex.IsMatch(this.city_searcher.Text.ToString())&&this.city_searcher.Enabled)
                    {
                        regexPassed = false;
                        throw new ArgumentException("City:Invalid format");
                    }
                    if (!_street_regex.IsMatch(this.street_searcher.Text.ToString())&&this.street_searcher.Enabled)
                    {
                        regexPassed = false;
                        throw new ArgumentException("Street:Invalid format");
                    }
                    if ((!_range_regex.IsMatch(this.lower_range.Text.ToString()) || !_range_regex.IsMatch(this.upper_range.Text.ToString()))&&this.lower_range.Enabled)
                    {
                        regexPassed = false;
                        throw new ArgumentException("Price range: Invalid format");
                    }
                    if (!_floor_regex.IsMatch(this.floor_searcher.Text.ToString()) && this.floor_searcher.Enabled)
                    {
                        regexPassed = false;
                        throw new ArgumentException("Floor:Invalid format");
                    }
                }
                catch(Exception ex)
                {
                    Error err_form = new Error(ex.Message, "");
                    err_form.ShowDialog();
                    err_form.Dispose();
                }
                
            }

            bool found_flat = false;
            if (regexPassed)
            {

                foreach(var flat in Main.instance.History)
                {
                    if (this.street_searcher.Enabled)
                    {
                        if (flat.Address.Street == this.street_searcher.Text.ToString())
                        {
                            found_flat = true;
                            this.richTextBox1.Text += flat.ToString();
                        }
                        if (Regex.IsMatch(this.street_searcher.Text.ToString(), $"{this.street_searcher.Text.ToString()[0]},"))
                    }
                }

                if (!found_flat)
                {
                    this.richTextBox1.Text = "Oops...did not find the match. Sorry";
                }
            }

        }
    }
}
