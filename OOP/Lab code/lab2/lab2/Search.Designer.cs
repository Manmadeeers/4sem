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
            this.search_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.street_search_name = new System.Windows.Forms.Label();
            this.enable_street_search = new System.Windows.Forms.Button();
            this.street_searcher = new System.Windows.Forms.TextBox();
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
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(23, 477);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(148, 55);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(272, 477);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(148, 55);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // street_search_name
            // 
            this.street_search_name.AutoSize = true;
            this.street_search_name.Location = new System.Drawing.Point(160, 62);
            this.street_search_name.Name = "street_search_name";
            this.street_search_name.Size = new System.Drawing.Size(104, 16);
            this.street_search_name.TabIndex = 5;
            this.street_search_name.Text = "Search by street";
            // 
            // enable_street_search
            // 
            this.enable_street_search.Location = new System.Drawing.Point(12, 81);
            this.enable_street_search.Name = "enable_street_search";
            this.enable_street_search.Size = new System.Drawing.Size(75, 23);
            this.enable_street_search.TabIndex = 6;
            this.enable_street_search.Text = "Enable";
            this.enable_street_search.UseVisualStyleBackColor = true;
            this.enable_street_search.Click += new System.EventHandler(this.enable_street_search_Click);
            // 
            // street_searcher
            // 
            this.street_searcher.Enabled = false;
            this.street_searcher.Location = new System.Drawing.Point(148, 81);
            this.street_searcher.Name = "street_searcher";
            this.street_searcher.Size = new System.Drawing.Size(153, 22);
            this.street_searcher.TabIndex = 7;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 544);
            this.Controls.Add(this.street_searcher);
            this.Controls.Add(this.enable_street_search);
            this.Controls.Add(this.street_search_name);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.result_name);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.form_name);
            this.Name = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form_name;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label result_name;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label street_search_name;
        private System.Windows.Forms.Button enable_street_search;
        private System.Windows.Forms.TextBox street_searcher;
    }
}