using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Main : Form
    {
        private bool _square_changed = false;
        private bool _rooms_changed = false;
        private bool _date_changed = false;
        private bool _materials_changed = false;
        private bool _additionals_changed = false;
        private bool _floor_changed = false;

        private Flat flat = new Flat();
        public static Main instance;


        public Main()
        {
            InitializeComponent();
            instance = this;
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
            if (_materials_changed == false)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _materials_changed = true;
            }
        }

        private void concrete_checker_CheckedChanged(object sender, System.EventArgs e)
        {
            if (_materials_changed == false)
            {
                this.progressBar1.Value += this.progressBar1.Step;
                _materials_changed = true;
            }
        }

        private void additionals_checker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
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
        }

        private void address_transfer_button_Click(object sender, System.EventArgs e)
        {
            Address_Form address_Form = new Address_Form();
            address_Form.ShowDialog();
            address_Form.Dispose();
        }
    }
}
