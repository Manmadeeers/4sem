namespace lab2
{
    partial class Search
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.result_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form_name
            // 
            this.form_name.AutoSize = true;
            this.form_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.form_name.Location = new System.Drawing.Point(283, 9);
            this.form_name.Name = "form_name";
            this.form_name.Size = new System.Drawing.Size(346, 32);
            this.form_name.TabIndex = 0;
            this.form_name.Text = "Search prompt constructor";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(590, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 408);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // result_name
            // 
            this.result_name.AutoSize = true;
            this.result_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_name.Location = new System.Drawing.Point(697, 54);
            this.result_name.Name = "result_name";
            this.result_name.Size = new System.Drawing.Size(81, 29);
            this.result_name.TabIndex = 2;
            this.result_name.Text = "Result";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 544);
            this.Controls.Add(this.result_name);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.form_name);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form_name;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label result_name;
    }
}