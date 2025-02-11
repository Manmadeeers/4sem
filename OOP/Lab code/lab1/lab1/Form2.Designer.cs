namespace lab1
{
    partial class Form2
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
            this.length_label = new System.Windows.Forms.Label();
            this.width_label = new System.Windows.Forms.Label();
            this.height_label = new System.Windows.Forms.Label();
            this.length_getter = new System.Windows.Forms.TextBox();
            this.width_getter = new System.Windows.Forms.TextBox();
            this.height_getter = new System.Windows.Forms.TextBox();
            this.metres_check = new System.Windows.Forms.RadioButton();
            this.feet_check = new System.Windows.Forms.RadioButton();
            this.calculate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // length_label
            // 
            this.length_label.AutoSize = true;
            this.length_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.length_label.Location = new System.Drawing.Point(12, 29);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(154, 29);
            this.length_label.TabIndex = 0;
            this.length_label.Text = "Enter length: ";
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width_label.Location = new System.Drawing.Point(12, 87);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(145, 29);
            this.width_label.TabIndex = 1;
            this.width_label.Text = "Enter width: ";
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height_label.Location = new System.Drawing.Point(12, 143);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(154, 29);
            this.height_label.TabIndex = 2;
            this.height_label.Text = "Enter height: ";
            // 
            // length_getter
            // 
            this.length_getter.Location = new System.Drawing.Point(263, 36);
            this.length_getter.Name = "length_getter";
            this.length_getter.Size = new System.Drawing.Size(100, 22);
            this.length_getter.TabIndex = 3;
            // 
            // width_getter
            // 
            this.width_getter.Location = new System.Drawing.Point(263, 94);
            this.width_getter.Name = "width_getter";
            this.width_getter.Size = new System.Drawing.Size(100, 22);
            this.width_getter.TabIndex = 4;
            // 
            // height_getter
            // 
            this.height_getter.Location = new System.Drawing.Point(263, 150);
            this.height_getter.Name = "height_getter";
            this.height_getter.Size = new System.Drawing.Size(100, 22);
            this.height_getter.TabIndex = 5;
            // 
            // metres_check
            // 
            this.metres_check.AutoSize = true;
            this.metres_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metres_check.Location = new System.Drawing.Point(535, 70);
            this.metres_check.Name = "metres_check";
            this.metres_check.Size = new System.Drawing.Size(117, 24);
            this.metres_check.TabIndex = 6;
            this.metres_check.TabStop = true;
            this.metres_check.Text = "Use metres";
            this.metres_check.UseVisualStyleBackColor = true;
            // 
            // feet_check
            // 
            this.feet_check.AutoSize = true;
            this.feet_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feet_check.Location = new System.Drawing.Point(535, 129);
            this.feet_check.Name = "feet_check";
            this.feet_check.Size = new System.Drawing.Size(93, 24);
            this.feet_check.TabIndex = 7;
            this.feet_check.TabStop = true;
            this.feet_check.Text = "Use feet";
            this.feet_check.UseVisualStyleBackColor = true;
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate_button.Location = new System.Drawing.Point(494, 190);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(158, 58);
            this.calculate_button.TabIndex = 8;
            this.calculate_button.Text = "Calculate!";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.feet_check);
            this.Controls.Add(this.metres_check);
            this.Controls.Add(this.height_getter);
            this.Controls.Add(this.width_getter);
            this.Controls.Add(this.length_getter);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.length_label);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.TextBox length_getter;
        private System.Windows.Forms.TextBox width_getter;
        private System.Windows.Forms.TextBox height_getter;
        private System.Windows.Forms.RadioButton metres_check;
        private System.Windows.Forms.RadioButton feet_check;
        private System.Windows.Forms.Button calculate_button;
    }
}