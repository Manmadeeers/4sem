namespace lab2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.greeting_label = new System.Windows.Forms.Label();
            this.city_getter = new System.Windows.Forms.ComboBox();
            this.city_name = new System.Windows.Forms.Label();
            this.brick_checker = new System.Windows.Forms.RadioButton();
            this.concrete_checker = new System.Windows.Forms.RadioButton();
            this.material_name = new System.Windows.Forms.Label();
            this.rooms_name = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.square_name = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cost_name = new System.Windows.Forms.Label();
            this.clacl_button = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.date_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.celing_name = new System.Windows.Forms.Label();
            this.rooms_specifier = new System.Windows.Forms.CheckedListBox();
            this.other_rooms_name = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // greeting_label
            // 
            this.greeting_label.AutoSize = true;
            this.greeting_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greeting_label.Location = new System.Drawing.Point(278, 9);
            this.greeting_label.Name = "greeting_label";
            this.greeting_label.Size = new System.Drawing.Size(508, 32);
            this.greeting_label.TabIndex = 0;
            this.greeting_label.Text = "Welcome to the Real Estate Calculator!";
            // 
            // city_getter
            // 
            this.city_getter.FormattingEnabled = true;
            this.city_getter.Items.AddRange(new object[] {
            "Minsk",
            "Brest",
            "Grodno",
            "Gomel",
            "Mohilev",
            "Vitebsk"});
            this.city_getter.Location = new System.Drawing.Point(12, 80);
            this.city_getter.Name = "city_getter";
            this.city_getter.Size = new System.Drawing.Size(226, 24);
            this.city_getter.TabIndex = 1;
            // 
            // city_name
            // 
            this.city_name.AutoSize = true;
            this.city_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_name.Location = new System.Drawing.Point(12, 41);
            this.city_name.Name = "city_name";
            this.city_name.Size = new System.Drawing.Size(153, 25);
            this.city_name.TabIndex = 3;
            this.city_name.Text = "Choose the city:";
            // 
            // brick_checker
            // 
            this.brick_checker.AutoSize = true;
            this.brick_checker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brick_checker.Location = new System.Drawing.Point(928, 83);
            this.brick_checker.Name = "brick_checker";
            this.brick_checker.Size = new System.Drawing.Size(76, 29);
            this.brick_checker.TabIndex = 4;
            this.brick_checker.TabStop = true;
            this.brick_checker.Text = "Brick";
            this.brick_checker.UseVisualStyleBackColor = true;
            // 
            // concrete_checker
            // 
            this.concrete_checker.AutoSize = true;
            this.concrete_checker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.concrete_checker.Location = new System.Drawing.Point(928, 118);
            this.concrete_checker.Name = "concrete_checker";
            this.concrete_checker.Size = new System.Drawing.Size(113, 29);
            this.concrete_checker.TabIndex = 5;
            this.concrete_checker.TabStop = true;
            this.concrete_checker.Text = "Concrete";
            this.concrete_checker.UseVisualStyleBackColor = true;
            // 
            // material_name
            // 
            this.material_name.AutoSize = true;
            this.material_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.material_name.Location = new System.Drawing.Point(923, 27);
            this.material_name.Name = "material_name";
            this.material_name.Size = new System.Drawing.Size(130, 50);
            this.material_name.TabIndex = 6;
            this.material_name.Text = "The house is \r\nmade of:";
            // 
            // rooms_name
            // 
            this.rooms_name.AutoSize = true;
            this.rooms_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rooms_name.Location = new System.Drawing.Point(388, 41);
            this.rooms_name.Name = "rooms_name";
            this.rooms_name.Size = new System.Drawing.Size(166, 25);
            this.rooms_name.TabIndex = 8;
            this.rooms_name.Text = "Amount of rooms:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(411, 80);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(699, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            // 
            // square_name
            // 
            this.square_name.AutoSize = true;
            this.square_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.square_name.Location = new System.Drawing.Point(694, 41);
            this.square_name.Name = "square_name";
            this.square_name.Size = new System.Drawing.Size(175, 25);
            this.square_name.TabIndex = 11;
            this.square_name.Text = "Total square(m^2):";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(681, 361);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(383, 339);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // cost_name
            // 
            this.cost_name.AutoSize = true;
            this.cost_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost_name.Location = new System.Drawing.Point(676, 333);
            this.cost_name.Name = "cost_name";
            this.cost_name.Size = new System.Drawing.Size(100, 25);
            this.cost_name.TabIndex = 13;
            this.cost_name.Text = "It will cost:";
            // 
            // clacl_button
            // 
            this.clacl_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clacl_button.Location = new System.Drawing.Point(855, 280);
            this.clacl_button.Name = "clacl_button";
            this.clacl_button.Size = new System.Drawing.Size(198, 61);
            this.clacl_button.TabIndex = 14;
            this.clacl_button.Text = "Calculate!";
            this.clacl_button.UseVisualStyleBackColor = true;
            this.clacl_button.Click += new System.EventHandler(this.clacl_button_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 174);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_label.Location = new System.Drawing.Point(14, 140);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(190, 25);
            this.date_label.TabIndex = 16;
            this.date_label.Text = "Date of construction:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(699, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 17;
            // 
            // celing_name
            // 
            this.celing_name.AutoSize = true;
            this.celing_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.celing_name.Location = new System.Drawing.Point(694, 122);
            this.celing_name.Name = "celing_name";
            this.celing_name.Size = new System.Drawing.Size(132, 25);
            this.celing_name.TabIndex = 18;
            this.celing_name.Text = "Celing height:";
            // 
            // rooms_specifier
            // 
            this.rooms_specifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rooms_specifier.FormattingEnabled = true;
            this.rooms_specifier.Items.AddRange(new object[] {
            "Bathroom",
            "Toilet",
            "Kitchen,",
            "Living Room",
            "Balcony",
            "Home Office"});
            this.rooms_specifier.Location = new System.Drawing.Point(394, 164);
            this.rooms_specifier.Name = "rooms_specifier";
            this.rooms_specifier.Size = new System.Drawing.Size(169, 114);
            this.rooms_specifier.TabIndex = 20;
            // 
            // other_rooms_name
            // 
            this.other_rooms_name.AutoSize = true;
            this.other_rooms_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.other_rooms_name.Location = new System.Drawing.Point(389, 136);
            this.other_rooms_name.Name = "other_rooms_name";
            this.other_rooms_name.Size = new System.Drawing.Size(174, 25);
            this.other_rooms_name.TabIndex = 21;
            this.other_rooms_name.Text = "What else is there:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(855, 203);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(198, 61);
            this.exit_button.TabIndex = 22;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 702);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.other_rooms_name);
            this.Controls.Add(this.rooms_specifier);
            this.Controls.Add(this.celing_name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.clacl_button);
            this.Controls.Add(this.cost_name);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.square_name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.rooms_name);
            this.Controls.Add(this.material_name);
            this.Controls.Add(this.concrete_checker);
            this.Controls.Add(this.brick_checker);
            this.Controls.Add(this.city_name);
            this.Controls.Add(this.city_getter);
            this.Controls.Add(this.greeting_label);
            this.Name = "Form1";
            this.Text = "Starting page";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greeting_label;
        private System.Windows.Forms.ComboBox city_getter;
        private System.Windows.Forms.Label city_name;
        private System.Windows.Forms.RadioButton brick_checker;
        private System.Windows.Forms.RadioButton concrete_checker;
        private System.Windows.Forms.Label material_name;
        private System.Windows.Forms.Label rooms_name;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label square_name;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label cost_name;
        private System.Windows.Forms.Button clacl_button;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label celing_name;
        private System.Windows.Forms.CheckedListBox rooms_specifier;
        private System.Windows.Forms.Label other_rooms_name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button exit_button;
    }
}

