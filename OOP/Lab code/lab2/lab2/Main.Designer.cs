namespace lab2
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Form_name_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.total_name = new System.Windows.Forms.Label();
            this.metres_name = new System.Windows.Forms.Label();
            this.square_getter = new System.Windows.Forms.TextBox();
            this.rooms_name = new System.Windows.Forms.Label();
            this.rooms_getter = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.calculate_button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.date_name = new System.Windows.Forms.Label();
            this.material_name = new System.Windows.Forms.Label();
            this.brick_checker = new System.Windows.Forms.RadioButton();
            this.concrete_checker = new System.Windows.Forms.RadioButton();
            this.additionals_checker = new System.Windows.Forms.CheckedListBox();
            this.additionals_name = new System.Windows.Forms.Label();
            this.floor_name = new System.Windows.Forms.Label();
            this.floor_getter = new System.Windows.Forms.NumericUpDown();
            this.address_transfer_button = new System.Windows.Forms.Button();
            this.company_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_getter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor_getter)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_name_label
            // 
            this.Form_name_label.AutoSize = true;
            this.Form_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form_name_label.Location = new System.Drawing.Point(249, 18);
            this.Form_name_label.Name = "Form_name_label";
            this.Form_name_label.Size = new System.Drawing.Size(461, 32);
            this.Form_name_label.TabIndex = 0;
            this.Form_name_label.Text = "Welcome to Real Estate Calculator!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.showAllToolStripMenuItem,
            this.eraseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.showAllToolStripMenuItem.Text = "Show All";
            // 
            // eraseToolStripMenuItem
            // 
            this.eraseToolStripMenuItem.Name = "eraseToolStripMenuItem";
            this.eraseToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.eraseToolStripMenuItem.Text = "Erase";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.eraseToolStripMenuItem1});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // eraseToolStripMenuItem1
            // 
            this.eraseToolStripMenuItem1.Name = "eraseToolStripMenuItem1";
            this.eraseToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.eraseToolStripMenuItem1.Text = "Erase";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(616, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(363, 587);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // total_name
            // 
            this.total_name.AutoSize = true;
            this.total_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total_name.Location = new System.Drawing.Point(753, 75);
            this.total_name.Name = "total_name";
            this.total_name.Size = new System.Drawing.Size(118, 29);
            this.total_name.TabIndex = 3;
            this.total_name.Text = "Total cost";
            // 
            // metres_name
            // 
            this.metres_name.AutoSize = true;
            this.metres_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metres_name.Location = new System.Drawing.Point(12, 107);
            this.metres_name.Name = "metres_name";
            this.metres_name.Size = new System.Drawing.Size(177, 29);
            this.metres_name.TabIndex = 4;
            this.metres_name.Text = "Square metres:";
            // 
            // square_getter
            // 
            this.square_getter.Location = new System.Drawing.Point(12, 144);
            this.square_getter.Name = "square_getter";
            this.square_getter.Size = new System.Drawing.Size(172, 22);
            this.square_getter.TabIndex = 5;
            this.square_getter.TextChanged += new System.EventHandler(this.square_getter_TextChanged);
            // 
            // rooms_name
            // 
            this.rooms_name.AutoSize = true;
            this.rooms_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rooms_name.Location = new System.Drawing.Point(303, 107);
            this.rooms_name.Name = "rooms_name";
            this.rooms_name.Size = new System.Drawing.Size(200, 29);
            this.rooms_name.TabIndex = 7;
            this.rooms_name.Text = "Amount of rooms:";
            // 
            // rooms_getter
            // 
            this.rooms_getter.Location = new System.Drawing.Point(344, 144);
            this.rooms_getter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rooms_getter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rooms_getter.Name = "rooms_getter";
            this.rooms_getter.Size = new System.Drawing.Size(120, 22);
            this.rooms_getter.TabIndex = 8;
            this.rooms_getter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rooms_getter.ValueChanged += new System.EventHandler(this.rooms_getter_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 671);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // calculate_button
            // 
            this.calculate_button.Enabled = false;
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate_button.Location = new System.Drawing.Point(398, 639);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(148, 55);
            this.calculate_button.TabIndex = 10;
            this.calculate_button.Text = "Calculate!";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // date_name
            // 
            this.date_name.AutoSize = true;
            this.date_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_name.Location = new System.Drawing.Point(12, 204);
            this.date_name.Name = "date_name";
            this.date_name.Size = new System.Drawing.Size(127, 29);
            this.date_name.TabIndex = 12;
            this.date_name.Text = "Build date:";
            // 
            // material_name
            // 
            this.material_name.AutoSize = true;
            this.material_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.material_name.Location = new System.Drawing.Point(303, 197);
            this.material_name.Name = "material_name";
            this.material_name.Size = new System.Drawing.Size(245, 29);
            this.material_name.TabIndex = 14;
            this.material_name.Text = "Construction material:";
            // 
            // brick_checker
            // 
            this.brick_checker.AutoSize = true;
            this.brick_checker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brick_checker.Location = new System.Drawing.Point(299, 229);
            this.brick_checker.Name = "brick_checker";
            this.brick_checker.Size = new System.Drawing.Size(88, 33);
            this.brick_checker.TabIndex = 15;
            this.brick_checker.TabStop = true;
            this.brick_checker.Text = "Brick";
            this.brick_checker.UseVisualStyleBackColor = true;
            this.brick_checker.CheckedChanged += new System.EventHandler(this.brick_checker_CheckedChanged);
            // 
            // concrete_checker
            // 
            this.concrete_checker.AutoSize = true;
            this.concrete_checker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.concrete_checker.Location = new System.Drawing.Point(442, 229);
            this.concrete_checker.Name = "concrete_checker";
            this.concrete_checker.Size = new System.Drawing.Size(132, 33);
            this.concrete_checker.TabIndex = 16;
            this.concrete_checker.TabStop = true;
            this.concrete_checker.Text = "Concrete";
            this.concrete_checker.UseVisualStyleBackColor = true;
            this.concrete_checker.CheckedChanged += new System.EventHandler(this.concrete_checker_CheckedChanged);
            // 
            // additionals_checker
            // 
            this.additionals_checker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionals_checker.FormattingEnabled = true;
            this.additionals_checker.Items.AddRange(new object[] {
            "Bathroom",
            "Living Room",
            "Toilet",
            "Home office",
            "Kitchen",
            "Balcony"});
            this.additionals_checker.Location = new System.Drawing.Point(12, 368);
            this.additionals_checker.Name = "additionals_checker";
            this.additionals_checker.Size = new System.Drawing.Size(190, 114);
            this.additionals_checker.TabIndex = 17;
            this.additionals_checker.SelectedIndexChanged += new System.EventHandler(this.additionals_checker_SelectedIndexChanged);
            // 
            // additionals_name
            // 
            this.additionals_name.AutoSize = true;
            this.additionals_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionals_name.Location = new System.Drawing.Point(7, 325);
            this.additionals_name.Name = "additionals_name";
            this.additionals_name.Size = new System.Drawing.Size(210, 29);
            this.additionals_name.TabIndex = 18;
            this.additionals_name.Text = "Select additionals:";
            // 
            // floor_name
            // 
            this.floor_name.AutoSize = true;
            this.floor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floor_name.Location = new System.Drawing.Point(366, 325);
            this.floor_name.Name = "floor_name";
            this.floor_name.Size = new System.Drawing.Size(76, 29);
            this.floor_name.TabIndex = 19;
            this.floor_name.Text = "Floor:";
            // 
            // floor_getter
            // 
            this.floor_getter.Location = new System.Drawing.Point(344, 368);
            this.floor_getter.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.floor_getter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floor_getter.Name = "floor_getter";
            this.floor_getter.Size = new System.Drawing.Size(120, 22);
            this.floor_getter.TabIndex = 20;
            this.floor_getter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floor_getter.ValueChanged += new System.EventHandler(this.floor_getter_ValueChanged);
            // 
            // address_transfer_button
            // 
            this.address_transfer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_transfer_button.Location = new System.Drawing.Point(331, 417);
            this.address_transfer_button.Name = "address_transfer_button";
            this.address_transfer_button.Size = new System.Drawing.Size(156, 55);
            this.address_transfer_button.TabIndex = 21;
            this.address_transfer_button.Text = "Fill in the address";
            this.address_transfer_button.UseVisualStyleBackColor = true;
            this.address_transfer_button.Click += new System.EventHandler(this.address_transfer_button_Click);
            // 
            // company_button
            // 
            this.company_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.company_button.Location = new System.Drawing.Point(331, 505);
            this.company_button.Name = "company_button";
            this.company_button.Size = new System.Drawing.Size(156, 55);
            this.company_button.TabIndex = 22;
            this.company_button.Text = "Fill in the company";
            this.company_button.UseVisualStyleBackColor = true;
            this.company_button.Click += new System.EventHandler(this.company_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 706);
            this.Controls.Add(this.company_button);
            this.Controls.Add(this.address_transfer_button);
            this.Controls.Add(this.floor_getter);
            this.Controls.Add(this.floor_name);
            this.Controls.Add(this.additionals_name);
            this.Controls.Add(this.additionals_checker);
            this.Controls.Add(this.concrete_checker);
            this.Controls.Add(this.brick_checker);
            this.Controls.Add(this.material_name);
            this.Controls.Add(this.date_name);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rooms_getter);
            this.Controls.Add(this.rooms_name);
            this.Controls.Add(this.square_getter);
            this.Controls.Add(this.metres_name);
            this.Controls.Add(this.total_name);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Form_name_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_getter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor_getter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Form_name_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label total_name;
        private System.Windows.Forms.Label metres_name;
        private System.Windows.Forms.TextBox square_getter;
        private System.Windows.Forms.Label rooms_name;
        private System.Windows.Forms.NumericUpDown rooms_getter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label date_name;
        private System.Windows.Forms.Label material_name;
        private System.Windows.Forms.RadioButton brick_checker;
        private System.Windows.Forms.RadioButton concrete_checker;
        private System.Windows.Forms.CheckedListBox additionals_checker;
        private System.Windows.Forms.Label additionals_name;
        private System.Windows.Forms.Label floor_name;
        private System.Windows.Forms.NumericUpDown floor_getter;
        private System.Windows.Forms.Button address_transfer_button;
        private System.Windows.Forms.Button company_button;
    }
}

