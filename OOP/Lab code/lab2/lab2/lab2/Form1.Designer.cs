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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Government Buildings LLC.");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Soviet Stroy GP.");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Belarusian Shit Building Company");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Government company", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("MAPID");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Build For Money Inc.");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Minsk Mir Shit Stroy Corp.");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Private Company", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            this.greeting_label = new System.Windows.Forms.Label();
            this.city_getter = new System.Windows.Forms.ComboBox();
            this.city_name = new System.Windows.Forms.Label();
            this.brick_checker = new System.Windows.Forms.RadioButton();
            this.concrete_checker = new System.Windows.Forms.RadioButton();
            this.material_name = new System.Windows.Forms.Label();
            this.rooms_name = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.square_getter = new System.Windows.Forms.TextBox();
            this.square_name = new System.Windows.Forms.Label();
            this.result_box = new System.Windows.Forms.RichTextBox();
            this.cost_name = new System.Windows.Forms.Label();
            this.clacl_button = new System.Windows.Forms.Button();
            this.date_label = new System.Windows.Forms.Label();
            this.celing_getter = new System.Windows.Forms.TextBox();
            this.celing_name = new System.Windows.Forms.Label();
            this.rooms_specifier = new System.Windows.Forms.CheckedListBox();
            this.other_rooms_name = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.builder_getter = new System.Windows.Forms.TreeView();
            this.builder_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.street_name = new System.Windows.Forms.Label();
            this.street_getter = new System.Windows.Forms.TextBox();
            this.house_name = new System.Windows.Forms.Label();
            this.house_getter = new System.Windows.Forms.TextBox();
            this.sub_getter = new System.Windows.Forms.NumericUpDown();
            this.sub_name = new System.Windows.Forms.Label();
            this.flat_getter = new System.Windows.Forms.NumericUpDown();
            this.flat_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_getter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flat_getter)).BeginInit();
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
            this.city_getter.SelectedIndexChanged += new System.EventHandler(this.city_getter_SelectedIndexChanged);
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
            this.brick_checker.CheckedChanged += new System.EventHandler(this.brick_checker_CheckedChanged);
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
            this.concrete_checker.CheckedChanged += new System.EventHandler(this.concrete_checker_CheckedChanged);
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
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // square_getter
            // 
            this.square_getter.Location = new System.Drawing.Point(699, 79);
            this.square_getter.Name = "square_getter";
            this.square_getter.Size = new System.Drawing.Size(100, 22);
            this.square_getter.TabIndex = 10;
            this.square_getter.TextChanged += new System.EventHandler(this.square_getter_TextChanged);
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
            // result_box
            // 
            this.result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_box.Location = new System.Drawing.Point(681, 361);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(383, 339);
            this.result_box.TabIndex = 12;
            this.result_box.Text = "";
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
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_label.Location = new System.Drawing.Point(21, 333);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(190, 25);
            this.date_label.TabIndex = 16;
            this.date_label.Text = "Date of construction:";
            // 
            // celing_getter
            // 
            this.celing_getter.Location = new System.Drawing.Point(699, 164);
            this.celing_getter.Name = "celing_getter";
            this.celing_getter.Size = new System.Drawing.Size(100, 22);
            this.celing_getter.TabIndex = 17;
            this.celing_getter.TextChanged += new System.EventHandler(this.celing_getter_TextChanged);
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
            this.rooms_specifier.Size = new System.Drawing.Size(169, 136);
            this.rooms_specifier.TabIndex = 20;
            this.rooms_specifier.SelectedIndexChanged += new System.EventHandler(this.rooms_specifier_SelectedIndexChanged);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 667);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(484, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // builder_getter
            // 
            this.builder_getter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.builder_getter.Location = new System.Drawing.Point(305, 361);
            this.builder_getter.Name = "builder_getter";
            treeNode17.Name = "Gov_1";
            treeNode17.Text = "Government Buildings LLC.";
            treeNode18.Name = "Gov_2";
            treeNode18.Text = "Soviet Stroy GP.";
            treeNode19.Name = "Gov_3";
            treeNode19.Text = "Belarusian Shit Building Company";
            treeNode20.Name = "Gov_node";
            treeNode20.Text = "Government company";
            treeNode21.Name = "Priv_1";
            treeNode21.Text = "MAPID";
            treeNode22.Name = "Priv_2";
            treeNode22.Text = "Build For Money Inc.";
            treeNode23.Name = "Priv_3";
            treeNode23.Text = "Minsk Mir Shit Stroy Corp.";
            treeNode24.Name = "Private_node";
            treeNode24.Text = "Private Company";
            this.builder_getter.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode24});
            this.builder_getter.Size = new System.Drawing.Size(325, 124);
            this.builder_getter.TabIndex = 24;
            // 
            // builder_label
            // 
            this.builder_label.AutoSize = true;
            this.builder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.builder_label.Location = new System.Drawing.Point(397, 333);
            this.builder_label.Name = "builder_label";
            this.builder_label.Size = new System.Drawing.Size(157, 25);
            this.builder_label.TabIndex = 25;
            this.builder_label.Text = "Who had built it?";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 361);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // street_name
            // 
            this.street_name.AutoSize = true;
            this.street_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.street_name.Location = new System.Drawing.Point(12, 130);
            this.street_name.Name = "street_name";
            this.street_name.Size = new System.Drawing.Size(64, 25);
            this.street_name.TabIndex = 27;
            this.street_name.Text = "Street";
            // 
            // street_getter
            // 
            this.street_getter.Location = new System.Drawing.Point(12, 158);
            this.street_getter.Name = "street_getter";
            this.street_getter.Size = new System.Drawing.Size(226, 22);
            this.street_getter.TabIndex = 28;
            this.street_getter.TextChanged += new System.EventHandler(this.street_getter_TextChanged);
            // 
            // house_name
            // 
            this.house_name.AutoSize = true;
            this.house_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.house_name.Location = new System.Drawing.Point(12, 204);
            this.house_name.Name = "house_name";
            this.house_name.Size = new System.Drawing.Size(69, 25);
            this.house_name.TabIndex = 29;
            this.house_name.Text = "House";
            // 
            // house_getter
            // 
            this.house_getter.Location = new System.Drawing.Point(15, 232);
            this.house_getter.Name = "house_getter";
            this.house_getter.Size = new System.Drawing.Size(223, 22);
            this.house_getter.TabIndex = 30;
            this.house_getter.TextChanged += new System.EventHandler(this.house_getter_TextChanged);
            // 
            // sub_getter
            // 
            this.sub_getter.Location = new System.Drawing.Point(17, 303);
            this.sub_getter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sub_getter.Name = "sub_getter";
            this.sub_getter.Size = new System.Drawing.Size(108, 22);
            this.sub_getter.TabIndex = 31;
            this.sub_getter.ValueChanged += new System.EventHandler(this.sub_getter_ValueChanged);
            // 
            // sub_name
            // 
            this.sub_name.AutoSize = true;
            this.sub_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sub_name.Location = new System.Drawing.Point(12, 275);
            this.sub_name.Name = "sub_name";
            this.sub_name.Size = new System.Drawing.Size(122, 25);
            this.sub_name.TabIndex = 32;
            this.sub_name.Text = "Sub Building";
            // 
            // flat_getter
            // 
            this.flat_getter.Location = new System.Drawing.Point(230, 303);
            this.flat_getter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.flat_getter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.flat_getter.Name = "flat_getter";
            this.flat_getter.Size = new System.Drawing.Size(120, 22);
            this.flat_getter.TabIndex = 33;
            this.flat_getter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.flat_getter.ValueChanged += new System.EventHandler(this.flat_getter_ValueChanged);
            // 
            // flat_name
            // 
            this.flat_name.AutoSize = true;
            this.flat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flat_name.Location = new System.Drawing.Point(225, 275);
            this.flat_name.Name = "flat_name";
            this.flat_name.Size = new System.Drawing.Size(115, 25);
            this.flat_name.TabIndex = 34;
            this.flat_name.Text = "Flat number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 702);
            this.Controls.Add(this.flat_name);
            this.Controls.Add(this.flat_getter);
            this.Controls.Add(this.sub_name);
            this.Controls.Add(this.sub_getter);
            this.Controls.Add(this.house_getter);
            this.Controls.Add(this.house_name);
            this.Controls.Add(this.street_getter);
            this.Controls.Add(this.street_name);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.builder_label);
            this.Controls.Add(this.builder_getter);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.other_rooms_name);
            this.Controls.Add(this.rooms_specifier);
            this.Controls.Add(this.celing_name);
            this.Controls.Add(this.celing_getter);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.clacl_button);
            this.Controls.Add(this.cost_name);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.square_name);
            this.Controls.Add(this.square_getter);
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
            ((System.ComponentModel.ISupportInitialize)(this.sub_getter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flat_getter)).EndInit();
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
        private System.Windows.Forms.TextBox square_getter;
        private System.Windows.Forms.Label square_name;
        private System.Windows.Forms.RichTextBox result_box;
        private System.Windows.Forms.Label cost_name;
        private System.Windows.Forms.Button clacl_button;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox celing_getter;
        private System.Windows.Forms.Label celing_name;
        private System.Windows.Forms.CheckedListBox rooms_specifier;
        private System.Windows.Forms.Label other_rooms_name;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TreeView builder_getter;
        private System.Windows.Forms.Label builder_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label street_name;
        private System.Windows.Forms.TextBox street_getter;
        private System.Windows.Forms.Label house_name;
        private System.Windows.Forms.TextBox house_getter;
        private System.Windows.Forms.NumericUpDown sub_getter;
        private System.Windows.Forms.Label sub_name;
        private System.Windows.Forms.NumericUpDown flat_getter;
        private System.Windows.Forms.Label flat_name;
    }
}

