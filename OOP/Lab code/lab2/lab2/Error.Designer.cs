namespace lab2
{
    partial class Error
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
            this.error_text_field = new System.Windows.Forms.RichTextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(268, 9);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(231, 32);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "An error occured!";
            // 
            // error_text_field
            // 
            this.error_text_field.Location = new System.Drawing.Point(226, 79);
            this.error_text_field.Name = "error_text_field";
            this.error_text_field.Size = new System.Drawing.Size(314, 187);
            this.error_text_field.TabIndex = 1;
            this.error_text_field.Text = "";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(307, 272);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(136, 52);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 353);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.error_text_field);
            this.Controls.Add(this.name_label);
            this.Name = "Error";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.RichTextBox error_text_field;
        private System.Windows.Forms.Button back_button;
    }
}