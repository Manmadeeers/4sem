namespace lab2
{
    partial class Company_form
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
            this.name_label = new System.Windows.Forms.Label();
            this.info_box = new System.Windows.Forms.RichTextBox();
            this.info_name = new System.Windows.Forms.Label();
            this.company_name = new System.Windows.Forms.Label();
            this.name_getter = new System.Windows.Forms.TextBox();
            this.type_name = new System.Windows.Forms.Label();
            this.type_getter = new System.Windows.Forms.ComboBox();
            this.address_name = new System.Windows.Forms.Label();
            this.address_getter = new System.Windows.Forms.RichTextBox();
            this.id_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.done_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.continue_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(306, 9);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(305, 32);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Fill in the company info";
            // 
            // info_box
            // 
            this.info_box.Location = new System.Drawing.Point(604, 122);
            this.info_box.Name = "info_box";
            this.info_box.Size = new System.Drawing.Size(345, 314);
            this.info_box.TabIndex = 1;
            this.info_box.Text = "";
            // 
            // info_name
            // 
            this.info_name.AutoSize = true;
            this.info_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_name.Location = new System.Drawing.Point(693, 90);
            this.info_name.Name = "info_name";
            this.info_name.Size = new System.Drawing.Size(180, 29);
            this.info_name.TabIndex = 2;
            this.info_name.Text = "You\'ve entered:";
            // 
            // company_name
            // 
            this.company_name.AutoSize = true;
            this.company_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.company_name.Location = new System.Drawing.Point(2, 90);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(187, 29);
            this.company_name.TabIndex = 3;
            this.company_name.Text = "Company name:";
            // 
            // name_getter
            // 
            this.name_getter.Location = new System.Drawing.Point(7, 122);
            this.name_getter.Name = "name_getter";
            this.name_getter.Size = new System.Drawing.Size(169, 22);
            this.name_getter.TabIndex = 4;
            this.name_getter.TextChanged += new System.EventHandler(this.name_getter_TextChanged);
            // 
            // type_name
            // 
            this.type_name.AutoSize = true;
            this.type_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_name.Location = new System.Drawing.Point(307, 90);
            this.type_name.Name = "type_name";
            this.type_name.Size = new System.Drawing.Size(172, 29);
            this.type_name.TabIndex = 5;
            this.type_name.Text = "Company type:";
            // 
            // type_getter
            // 
            this.type_getter.FormattingEnabled = true;
            this.type_getter.Items.AddRange(new object[] {
            "Corparation",
            "LTD",
            "LLC",
            "INC"});
            this.type_getter.Location = new System.Drawing.Point(312, 119);
            this.type_getter.Name = "type_getter";
            this.type_getter.Size = new System.Drawing.Size(167, 24);
            this.type_getter.TabIndex = 6;
            this.type_getter.SelectedIndexChanged += new System.EventHandler(this.type_getter_SelectedIndexChanged);
            // 
            // address_name
            // 
            this.address_name.AutoSize = true;
            this.address_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_name.Location = new System.Drawing.Point(2, 192);
            this.address_name.Name = "address_name";
            this.address_name.Size = new System.Drawing.Size(289, 29);
            this.address_name.TabIndex = 7;
            this.address_name.Text = "Company official address:";
            // 
            // address_getter
            // 
            this.address_getter.Location = new System.Drawing.Point(7, 236);
            this.address_getter.Name = "address_getter";
            this.address_getter.Size = new System.Drawing.Size(272, 96);
            this.address_getter.TabIndex = 8;
            this.address_getter.Text = "";
            this.address_getter.TextChanged += new System.EventHandler(this.address_getter_TextChanged);
            // 
            // id_name
            // 
            this.id_name.AutoSize = true;
            this.id_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_name.Location = new System.Drawing.Point(307, 182);
            this.id_name.Name = "id_name";
            this.id_name.Size = new System.Drawing.Size(256, 58);
            this.id_name.TabIndex = 9;
            this.id_name.Text = "Company identification\r\n number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(363, 575);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(157, 51);
            this.done_button.TabIndex = 12;
            this.done_button.Text = "Done!";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(565, 575);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(157, 51);
            this.exit_button.TabIndex = 13;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // continue_button
            // 
            this.continue_button.Location = new System.Drawing.Point(698, 442);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(157, 51);
            this.continue_button.TabIndex = 14;
            this.continue_button.Text = "Continue";
            this.continue_button.UseVisualStyleBackColor = true;
            this.continue_button.Visible = false;
            this.continue_button.Click += new System.EventHandler(this.continue_button_Click);
            // 
            // Company_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 638);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.id_name);
            this.Controls.Add(this.address_getter);
            this.Controls.Add(this.address_name);
            this.Controls.Add(this.type_getter);
            this.Controls.Add(this.type_name);
            this.Controls.Add(this.name_getter);
            this.Controls.Add(this.company_name);
            this.Controls.Add(this.info_name);
            this.Controls.Add(this.info_box);
            this.Controls.Add(this.name_label);
            this.Name = "Company_form";
            this.Text = "Company_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.RichTextBox info_box;
        private System.Windows.Forms.Label info_name;
        private System.Windows.Forms.Label company_name;
        private System.Windows.Forms.TextBox name_getter;
        private System.Windows.Forms.Label type_name;
        private System.Windows.Forms.ComboBox type_getter;
        private System.Windows.Forms.Label address_name;
        private System.Windows.Forms.RichTextBox address_getter;
        private System.Windows.Forms.Label id_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button continue_button;
    }
}