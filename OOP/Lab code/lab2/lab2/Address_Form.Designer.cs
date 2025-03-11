namespace lab2
{
    partial class Address_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.form_name = new System.Windows.Forms.Label();
            this.done_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.info_box = new System.Windows.Forms.RichTextBox();
            this.info_label = new System.Windows.Forms.Label();
            this.country_getter = new System.Windows.Forms.ComboBox();
            this.country_name = new System.Windows.Forms.Label();
            this.city_name = new System.Windows.Forms.Label();
            this.city_getter = new System.Windows.Forms.TextBox();
            this.street_name = new System.Windows.Forms.Label();
            this.street_getter = new System.Windows.Forms.TextBox();
            this.building_getter = new System.Windows.Forms.NumericUpDown();
            this.building_name = new System.Windows.Forms.Label();
            this.has_sub = new System.Windows.Forms.RadioButton();
            this.no_sub = new System.Windows.Forms.RadioButton();
            this.sub_getter = new System.Windows.Forms.NumericUpDown();
            this.subbuilding_name = new System.Windows.Forms.Label();
            this.apartment_getter = new System.Windows.Forms.NumericUpDown();
            this.apartment_name = new System.Windows.Forms.Label();
            this.continue_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.building_getter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_getter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartment_getter)).BeginInit();
            this.SuspendLayout();
            // 
            // form_name
            // 
            this.form_name.AutoSize = true;
            this.form_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_name.Location = new System.Drawing.Point(268, 9);
            this.form_name.Name = "form_name";
            this.form_name.Size = new System.Drawing.Size(386, 32);
            this.form_name.TabIndex = 0;
            this.form_name.Text = "Fill in the address information";
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(392, 537);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(160, 53);
            this.done_button.TabIndex = 2;
            this.done_button.Text = "Done!";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(669, 537);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(160, 53);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // info_box
            // 
            this.info_box.Location = new System.Drawing.Point(431, 102);
            this.info_box.Name = "info_box";
            this.info_box.Size = new System.Drawing.Size(493, 326);
            this.info_box.TabIndex = 4;
            this.info_box.Text = "";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_label.Location = new System.Drawing.Point(596, 70);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(180, 29);
            this.info_label.TabIndex = 5;
            this.info_label.Text = "You\'ve entered:";
            // 
            // country_getter
            // 
            this.country_getter.FormattingEnabled = true;
            this.country_getter.Items.AddRange(new object[] {
            "Belarus",
            "Poland",
            "Lithuania",
            "Latvia",
            "Estonia",
            "Germany"});
            this.country_getter.Location = new System.Drawing.Point(12, 102);
            this.country_getter.Name = "country_getter";
            this.country_getter.Size = new System.Drawing.Size(121, 24);
            this.country_getter.TabIndex = 6;
            this.country_getter.SelectedIndexChanged += new System.EventHandler(this.country_getter_SelectedIndexChanged);
            // 
            // country_name
            // 
            this.country_name.AutoSize = true;
            this.country_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country_name.Location = new System.Drawing.Point(7, 70);
            this.country_name.Name = "country_name";
            this.country_name.Size = new System.Drawing.Size(101, 29);
            this.country_name.TabIndex = 7;
            this.country_name.Text = "Country:";
            // 
            // city_name
            // 
            this.city_name.AutoSize = true;
            this.city_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_name.Location = new System.Drawing.Point(269, 70);
            this.city_name.Name = "city_name";
            this.city_name.Size = new System.Drawing.Size(59, 29);
            this.city_name.TabIndex = 8;
            this.city_name.Text = "City:";
            // 
            // city_getter
            // 
            this.city_getter.Location = new System.Drawing.Point(221, 102);
            this.city_getter.Name = "city_getter";
            this.city_getter.Size = new System.Drawing.Size(155, 22);
            this.city_getter.TabIndex = 9;
            this.city_getter.TextChanged += new System.EventHandler(this.city_getter_TextChanged);
            // 
            // street_name
            // 
            this.street_name.AutoSize = true;
            this.street_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.street_name.Location = new System.Drawing.Point(12, 163);
            this.street_name.Name = "street_name";
            this.street_name.Size = new System.Drawing.Size(83, 29);
            this.street_name.TabIndex = 10;
            this.street_name.Text = "Street:";
            // 
            // street_getter
            // 
            this.street_getter.Location = new System.Drawing.Point(12, 195);
            this.street_getter.Name = "street_getter";
            this.street_getter.Size = new System.Drawing.Size(163, 22);
            this.street_getter.TabIndex = 11;
            this.street_getter.TextChanged += new System.EventHandler(this.street_getter_TextChanged);
            // 
            // building_getter
            // 
            this.building_getter.Location = new System.Drawing.Point(256, 195);
            this.building_getter.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.building_getter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.building_getter.Name = "building_getter";
            this.building_getter.Size = new System.Drawing.Size(120, 22);
            this.building_getter.TabIndex = 12;
            this.building_getter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.building_getter.ValueChanged += new System.EventHandler(this.building_getter_ValueChanged);
            // 
            // building_name
            // 
            this.building_name.AutoSize = true;
            this.building_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.building_name.Location = new System.Drawing.Point(260, 163);
            this.building_name.Name = "building_name";
            this.building_name.Size = new System.Drawing.Size(107, 29);
            this.building_name.TabIndex = 13;
            this.building_name.Text = "Building:";
            // 
            // has_sub
            // 
            this.has_sub.AutoSize = true;
            this.has_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.has_sub.Location = new System.Drawing.Point(12, 278);
            this.has_sub.Name = "has_sub";
            this.has_sub.Size = new System.Drawing.Size(193, 29);
            this.has_sub.TabIndex = 14;
            this.has_sub.TabStop = true;
            this.has_sub.Text = "Has a sub building";
            this.has_sub.UseVisualStyleBackColor = true;
            this.has_sub.CheckedChanged += new System.EventHandler(this.has_sub_CheckedChanged);
            // 
            // no_sub
            // 
            this.no_sub.AutoSize = true;
            this.no_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.no_sub.Location = new System.Drawing.Point(234, 265);
            this.no_sub.Name = "no_sub";
            this.no_sub.Size = new System.Drawing.Size(163, 54);
            this.no_sub.TabIndex = 15;
            this.no_sub.TabStop = true;
            this.no_sub.Text = "Doesn\'t have a\r\n sub building";
            this.no_sub.UseVisualStyleBackColor = true;
            this.no_sub.CheckedChanged += new System.EventHandler(this.no_sub_CheckedChanged);
            // 
            // sub_getter
            // 
            this.sub_getter.Enabled = false;
            this.sub_getter.Location = new System.Drawing.Point(17, 390);
            this.sub_getter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sub_getter.Name = "sub_getter";
            this.sub_getter.Size = new System.Drawing.Size(120, 22);
            this.sub_getter.TabIndex = 16;
            this.sub_getter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sub_getter.ValueChanged += new System.EventHandler(this.sub_getter_ValueChanged);
            // 
            // subbuilding_name
            // 
            this.subbuilding_name.AutoSize = true;
            this.subbuilding_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subbuilding_name.Location = new System.Drawing.Point(12, 353);
            this.subbuilding_name.Name = "subbuilding_name";
            this.subbuilding_name.Size = new System.Drawing.Size(148, 29);
            this.subbuilding_name.TabIndex = 17;
            this.subbuilding_name.Text = "Sub building";
            // 
            // apartment_getter
            // 
            this.apartment_getter.Location = new System.Drawing.Point(256, 390);
            this.apartment_getter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.apartment_getter.Name = "apartment_getter";
            this.apartment_getter.Size = new System.Drawing.Size(120, 22);
            this.apartment_getter.TabIndex = 18;
            this.apartment_getter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.apartment_getter.ValueChanged += new System.EventHandler(this.apartment_getter_ValueChanged);
            // 
            // apartment_name
            // 
            this.apartment_name.AutoSize = true;
            this.apartment_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apartment_name.Location = new System.Drawing.Point(209, 353);
            this.apartment_name.Name = "apartment_name";
            this.apartment_name.Size = new System.Drawing.Size(216, 29);
            this.apartment_name.TabIndex = 19;
            this.apartment_name.Text = "Apartment number:";
            // 
            // continue_button
            // 
            this.continue_button.Location = new System.Drawing.Point(626, 434);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(138, 51);
            this.continue_button.TabIndex = 20;
            this.continue_button.Text = "Continue";
            this.continue_button.UseVisualStyleBackColor = true;
            this.continue_button.Visible = false;
            this.continue_button.Click += new System.EventHandler(this.continue_button_Click);
            // 
            // Address_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 602);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.apartment_name);
            this.Controls.Add(this.apartment_getter);
            this.Controls.Add(this.subbuilding_name);
            this.Controls.Add(this.sub_getter);
            this.Controls.Add(this.no_sub);
            this.Controls.Add(this.has_sub);
            this.Controls.Add(this.building_name);
            this.Controls.Add(this.building_getter);
            this.Controls.Add(this.street_getter);
            this.Controls.Add(this.street_name);
            this.Controls.Add(this.city_getter);
            this.Controls.Add(this.city_name);
            this.Controls.Add(this.country_name);
            this.Controls.Add(this.country_getter);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.info_box);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.form_name);
            this.Name = "Address_Form";
            this.Text = "Address_Form";
            ((System.ComponentModel.ISupportInitialize)(this.building_getter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_getter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartment_getter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form_name;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.RichTextBox info_box;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.ComboBox country_getter;
        private System.Windows.Forms.Label country_name;
        private System.Windows.Forms.Label city_name;
        private System.Windows.Forms.TextBox city_getter;
        private System.Windows.Forms.Label street_name;
        private System.Windows.Forms.TextBox street_getter;
        private System.Windows.Forms.NumericUpDown building_getter;
        private System.Windows.Forms.Label building_name;
        private System.Windows.Forms.RadioButton has_sub;
        private System.Windows.Forms.RadioButton no_sub;
        private System.Windows.Forms.NumericUpDown sub_getter;
        private System.Windows.Forms.Label subbuilding_name;
        private System.Windows.Forms.NumericUpDown apartment_getter;
        private System.Windows.Forms.Label apartment_name;
        private System.Windows.Forms.Button continue_button;
    }
}