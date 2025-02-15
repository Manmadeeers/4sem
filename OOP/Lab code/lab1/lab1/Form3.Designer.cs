namespace lab1
{
    partial class Form3
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
            this.floor_label = new System.Windows.Forms.Label();
            this.coverings_box = new System.Windows.Forms.ComboBox();
            this.coverings_amount_label = new System.Windows.Forms.Label();
            this.coverings_getter = new System.Windows.Forms.TextBox();
            this.using_metres = new System.Windows.Forms.RadioButton();
            this.using_feet = new System.Windows.Forms.RadioButton();
            this.wall_label = new System.Windows.Forms.Label();
            this.wall_getter = new System.Windows.Forms.TextBox();
            this.calc_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.result_box = new System.Windows.Forms.TextBox();
            this.square_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // floor_label
            // 
            this.floor_label.AutoSize = true;
            this.floor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floor_label.Location = new System.Drawing.Point(13, 13);
            this.floor_label.Name = "floor_label";
            this.floor_label.Size = new System.Drawing.Size(145, 25);
            this.floor_label.TabIndex = 0;
            this.floor_label.Text = "Floor coverings";
            // 
            // coverings_box
            // 
            this.coverings_box.FormattingEnabled = true;
            this.coverings_box.ItemHeight = 16;
            this.coverings_box.Items.AddRange(new object[] {
            "Parket",
            "Plitka",
            "Lominat"});
            this.coverings_box.Location = new System.Drawing.Point(12, 41);
            this.coverings_box.Name = "coverings_box";
            this.coverings_box.Size = new System.Drawing.Size(186, 24);
            this.coverings_box.TabIndex = 1;
            // 
            // coverings_amount_label
            // 
            this.coverings_amount_label.AutoSize = true;
            this.coverings_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coverings_amount_label.Location = new System.Drawing.Point(294, 13);
            this.coverings_amount_label.Name = "coverings_amount_label";
            this.coverings_amount_label.Size = new System.Drawing.Size(216, 25);
            this.coverings_amount_label.TabIndex = 2;
            this.coverings_amount_label.Text = "How much do you have";
            // 
            // coverings_getter
            // 
            this.coverings_getter.Location = new System.Drawing.Point(299, 41);
            this.coverings_getter.Name = "coverings_getter";
            this.coverings_getter.Size = new System.Drawing.Size(171, 22);
            this.coverings_getter.TabIndex = 3;
            // 
            // using_metres
            // 
            this.using_metres.AutoSize = true;
            this.using_metres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.using_metres.Location = new System.Drawing.Point(591, 13);
            this.using_metres.Name = "using_metres";
            this.using_metres.Size = new System.Drawing.Size(197, 29);
            this.using_metres.TabIndex = 4;
            this.using_metres.TabStop = true;
            this.using_metres.Text = "Use square metres";
            this.using_metres.UseVisualStyleBackColor = true;
            // 
            // using_feet
            // 
            this.using_feet.AutoSize = true;
            this.using_feet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.using_feet.Location = new System.Drawing.Point(591, 48);
            this.using_feet.Name = "using_feet";
            this.using_feet.Size = new System.Drawing.Size(170, 29);
            this.using_feet.TabIndex = 5;
            this.using_feet.TabStop = true;
            this.using_feet.Text = "Use square feet";
            this.using_feet.UseVisualStyleBackColor = true;
            // 
            // wall_label
            // 
            this.wall_label.AutoSize = true;
            this.wall_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wall_label.Location = new System.Drawing.Point(7, 112);
            this.wall_label.Name = "wall_label";
            this.wall_label.Size = new System.Drawing.Size(236, 50);
            this.wall_label.TabIndex = 6;
            this.wall_label.Text = "How much wall coverings \r\ndo you have:";
            // 
            // wall_getter
            // 
            this.wall_getter.Location = new System.Drawing.Point(299, 112);
            this.wall_getter.Name = "wall_getter";
            this.wall_getter.Size = new System.Drawing.Size(171, 22);
            this.wall_getter.TabIndex = 7;
            // 
            // calc_button
            // 
            this.calc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calc_button.Location = new System.Drawing.Point(591, 112);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(161, 69);
            this.calc_button.TabIndex = 8;
            this.calc_button.Text = "Calculate!";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(591, 225);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(161, 69);
            this.exit_button.TabIndex = 9;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_label.Location = new System.Drawing.Point(7, 234);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(184, 25);
            this.result_label.TabIndex = 10;
            this.result_label.Text = "It will be suitable for ";
            // 
            // result_box
            // 
            this.result_box.Location = new System.Drawing.Point(202, 234);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(135, 22);
            this.result_box.TabIndex = 11;
            // 
            // square_label
            // 
            this.square_label.AutoSize = true;
            this.square_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.square_label.Location = new System.Drawing.Point(371, 234);
            this.square_label.Name = "square_label";
            this.square_label.Size = new System.Drawing.Size(121, 25);
            this.square_label.TabIndex = 12;
            this.square_label.Text = "square room";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.square_label);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.wall_getter);
            this.Controls.Add(this.wall_label);
            this.Controls.Add(this.using_feet);
            this.Controls.Add(this.using_metres);
            this.Controls.Add(this.coverings_getter);
            this.Controls.Add(this.coverings_amount_label);
            this.Controls.Add(this.coverings_box);
            this.Controls.Add(this.floor_label);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label floor_label;
        private System.Windows.Forms.ComboBox coverings_box;
        private System.Windows.Forms.Label coverings_amount_label;
        private System.Windows.Forms.TextBox coverings_getter;
        private System.Windows.Forms.RadioButton using_metres;
        private System.Windows.Forms.RadioButton using_feet;
        private System.Windows.Forms.Label wall_label;
        private System.Windows.Forms.TextBox wall_getter;
        private System.Windows.Forms.Button calc_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.TextBox result_box;
        private System.Windows.Forms.Label square_label;
    }
}