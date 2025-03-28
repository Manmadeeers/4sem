using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class Main : Form
    {
        private string _version = Application.ProductVersion;
        public string Version
        {
            get
            {
                return _version;
            }
        }

        //CHANGE IF NEEDED
        private string _developer = "Ilia Filipiuk";
        //---

        public string Developer
        {
            get
            {
                return _developer;
            }
        }
        private bool _square_changed = false;
        private bool _rooms_changed = false;
        private bool _date_changed = false;
        private bool _materials_changed = false;
        private bool _additionals_changed = false;
        private bool _floor_changed = false;
        private bool _address_pressed = false;
        private bool _company_pressed = false;
        private bool _isValidForm = true;
        private Flat flat = new Flat();
        public Flat FLAT
        {
            get
            {
                return flat;
            }
            set
            {
                flat = value;
            }
        }
        public static Main instance;

        private List<Flat>_history = new List<Flat> ();
        public List<Flat> History
        {
            get
            {
                return _history;
            }
            set
            {
                _history = value;
            }
        }


        public Main()
        {
            InitializeComponent();
            instance = this;
            fillHistoryonStart();
        }

        private void fillHistoryonStart()
        {
            Flat flat1 = new Flat();
            Address adr1 = new Address();
            Company company1 = new Company();

            flat1.Address.Country = "Belarus";
            flat1.Address.City = "Minsk";
            flat1.Address.Street = "Kirova";
            flat1.Address.Building = 15;
            flat1.Address.Sub_building = 1;
            flat1.Address.Apartment_number = 156;
            flat1.Floor = 10;
            flat1.Square = 100;
            flat1.Rooms = 3;
            flat1.RoomOptions = 4;
            flat1.BuildDate = new DateTime(2006,3,20);
            flat1.Material = Materials.Concrete;
            company1.Name = "MAPID";
            company1.Company_number = "JOFFODO1281245";
            company1.Off_address = "Sukharavskaya 38";
            flat1.Company = company1;
            flat1.Price = flat1.CalculateCost();
            History.Add(flat1);

            Flat flat2 = new Flat();
            Address adr2 = new Address();
            Company company2 = new Company();
            flat2.Address.Country = "Poland";
            flat2.Address.City = "Warsaw";
            flat2.Address.Street = "Kastushki";
            flat2.Address.Building = 42;
            flat2.Address.Sub_building = 3;
            flat2.Address.Apartment_number = 234;
            flat2.Floor = 2;
            flat2.Square = 120;
            flat2.Rooms = 4;
            flat2.RoomOptions = 3;
            flat2.BuildDate = new DateTime(2008, 5, 15);
            flat2.Material = Materials.Brick;
            company2.Name = "POLISHSTROY";
            company2.Company_number = "KROFFODO123456";
            company2.Off_address = "Centralna 19";
            flat2.Company = company2;
            flat2.Price = flat2.CalculateCost();
            History.Add(flat2);
        }

        private void square_getter_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (this.square_getter.Text.ToString() != "")
                {
                    flat.Square = Convert.ToDouble(square_getter.Text.ToString());
                }
            }
            catch(Exception ex)
            {
                this.square_getter.Text = "";
                Error err_form = new Error(ex.Message,"Square Getter Field");
                err_form.ShowDialog();
                err_form.Dispose();

            }
            finally
            {
                if (_square_changed == false)
                {
                    this.progressBar1.Value += this.progressBar1.Step;
                    _square_changed = true;
                }

            }

        }

        private void rooms_getter_ValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                flat.Rooms = Convert.ToInt32(this.rooms_getter.Value.ToString());
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "Rooms Getter Field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
           
            if (_rooms_changed == false)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _rooms_changed = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            try
            {

                if (this.dateTimePicker1.Value.Date>=DateTime.Today)
                {
                    throw new ArgumentException("Incorrect date: Date after todays\n");
                }
                flat.BuildDate = this.dateTimePicker1.Value;
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "Date picker field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
            if (_date_changed == false)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _date_changed = true;
            }
        }

        private void brick_checker_CheckedChanged(object sender, System.EventArgs e)
        {
            flat.Material = Materials.Brick;
            if (_materials_changed == false)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _materials_changed = true;
            }
        }

        private void concrete_checker_CheckedChanged(object sender, System.EventArgs e)
        {
            flat.Material = Materials.Concrete;
            if (_materials_changed == false)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _materials_changed = true;
            }
        }

        private void additionals_checker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                flat.RoomOptions = this.additionals_checker.CheckedItems.Count;
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "Additionals checker field");
                err_form.ShowDialog();
                err_form.Dispose();
            }
            if (_additionals_changed == false)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _additionals_changed = true;
            }
        }

        private void floor_getter_ValueChanged(object sender, System.EventArgs e)
        {
            if (_floor_changed == false)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _floor_changed = true;
            }
            this.flat.Floor = Convert.ToInt32(this.floor_getter.Value);
        }

        private void address_transfer_button_Click(object sender, System.EventArgs e)
        {
            if (!_address_pressed)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _address_pressed = true;
            }
            Address_Form address_Form = new Address_Form();
            address_Form.ShowDialog();
            address_Form.Dispose();
        }

        private void company_button_Click(object sender, EventArgs e)
        {
            if (!_company_pressed)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _company_pressed = true;
            }

            Company_form comp_form = new Company_form();
            comp_form.ShowDialog();
            comp_form.Dispose();
            this.calculate_button.Enabled = true;

        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.square_getter.Text.ToString() == "")
                {
                    throw new ArgumentNullException("Square getter field was null");
                }
                if (!this.brick_checker.Checked && !this.concrete_checker.Checked)
                {
                    throw new ArgumentException("Material checker was not checked");
                }
                if (this.additionals_checker.CheckedItems.Count == 0)
                {
                    throw new ArgumentNullException("Additionals were not checked");
                }
                History.Add(flat);


            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "Check null or empty fields");
                err_form.ShowDialog();
                err_form.Dispose();
            }
            this.flat.Price = flat.CalculateCost();
            var validationContext = new ValidationContext(flat);
            var voidationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(flat, validationContext, voidationResults, true);
            if (voidationResults.Count!=0)
            {
                Error err_from = new Error(voidationResults[0].ErrorMessage, "");
                err_from.ShowDialog(); err_from.Dispose();
            }
            else
            {
                this.richTextBox1.Text = flat.ToString();
                this.progressBar1.Value += 100 - this.progressBar1.Value;
            }
           
           

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            foreach(var item in this.History)
            {
                this.richTextBox1.Text+=item.ToString()+'\n';
            }
        }

        private void eraseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.History.Clear();
            this.richTextBox1.Text = "History cleared";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (History.Count == 0)
                {
                    throw new ArgumentNullException("History was null. Could not save to file");
                }
              
                Formatter.ToJsonFile<List<Flat>>(this.History);
            }
            catch(Exception ex)
            {
                Error err_form = new Error(ex.Message, "History save button");
                err_form.ShowDialog();
                err_form.Dispose();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
            about.Dispose();
        }

        private void Form_name_label_Click(object sender, EventArgs e)
        {

        }

        private void clearFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _isValidForm = true;
                if(this._history.Count == 0)
                {
                    throw new Exception("Impossible to search through an empty history");
                }
            }
            catch (Exception ex)
            {
                _isValidForm= false;
                Error err_form = new Error(ex.Message, "History is empty");
                err_form.ShowDialog();
                err_form.Dispose();
            }
            if (_isValidForm)
            {
                Search search_form = new Search();
                search_form.ShowDialog();
                search_form.Dispose();
            }
          
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedByPrice = this.History.OrderBy(h => h.Price);
            this.richTextBox1.Text = "";
            foreach(var elem in sortedByPrice)
            {
                this.richTextBox1.Text+= elem.ToString();
            }
        }

        private void byFloorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedByFloor = this.History.OrderBy(h => h.Floor);
            this.richTextBox1.Text = "";
            foreach (var elem in sortedByFloor)
            {
                this.richTextBox1.Text += elem.ToString();
            }
        }
    }
}
