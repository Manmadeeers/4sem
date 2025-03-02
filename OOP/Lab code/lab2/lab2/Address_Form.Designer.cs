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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.done_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 567);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(252, 23);
            this.progressBar1.TabIndex = 1;
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
            // Address_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 602);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.form_name);
            this.Name = "Address_Form";
            this.Text = "Address_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form_name;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Button exit_button;
    }
}