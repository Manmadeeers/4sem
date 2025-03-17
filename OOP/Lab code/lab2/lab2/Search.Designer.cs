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
            this.enable_city_search = new System.Windows.Forms.Button();
            this.city_searcher = new System.Windows.Forms.TextBox();
            this.city_name = new System.Windows.Forms.Label();
            this.enable_floor_search = new System.Windows.Forms.Button();
            this.floor_searcher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enable_price_search = new System.Windows.Forms.Button();
            this.lower_range = new System.Windows.Forms.TextBox();
            this.upper_range = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.richTextBox1.Location = new System.Drawing.Point(552, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(339, 408);
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
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
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
            this.street_search_name.Location = new System.Drawing.Point(145, 62);
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
            this.street_searcher.Size = new System.Drawing.Size(235, 22);
            this.street_searcher.TabIndex = 7;
            // 
            // enable_city_search
            // 
            this.enable_city_search.Location = new System.Drawing.Point(12, 163);
            this.enable_city_search.Name = "enable_city_search";
            this.enable_city_search.Size = new System.Drawing.Size(75, 23);
            this.enable_city_search.TabIndex = 8;
            this.enable_city_search.Text = "Enable";
            this.enable_city_search.UseVisualStyleBackColor = true;
            this.enable_city_search.Click += new System.EventHandler(this.enable_city_search_Click);
            // 
            // city_searcher
            // 
            this.city_searcher.Enabled = false;
            this.city_searcher.Location = new System.Drawing.Point(148, 163);
            this.city_searcher.Name = "city_searcher";
            this.city_searcher.Size = new System.Drawing.Size(235, 22);
            this.city_searcher.TabIndex = 9;
            // 
            // city_name
            // 
            this.city_name.AutoSize = true;
            this.city_name.Location = new System.Drawing.Point(145, 144);
            this.city_name.Name = "city_name";
            this.city_name.Size = new System.Drawing.Size(93, 16);
            this.city_name.TabIndex = 10;
            this.city_name.Text = "Search by City";
            this.city_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // enable_floor_search
            // 
            this.enable_floor_search.Location = new System.Drawing.Point(12, 243);
            this.enable_floor_search.Name = "enable_floor_search";
            this.enable_floor_search.Size = new System.Drawing.Size(75, 23);
            this.enable_floor_search.TabIndex = 11;
            this.enable_floor_search.Text = "Enable";
            this.enable_floor_search.UseVisualStyleBackColor = true;
            this.enable_floor_search.Click += new System.EventHandler(this.enable_floor_search_Click);
            // 
            // floor_searcher
            // 
            this.floor_searcher.Enabled = false;
            this.floor_searcher.Location = new System.Drawing.Point(148, 243);
            this.floor_searcher.Name = "floor_searcher";
            this.floor_searcher.Size = new System.Drawing.Size(235, 22);
            this.floor_searcher.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search by floor";
            // 
            // enable_price_search
            // 
            this.enable_price_search.Location = new System.Drawing.Point(12, 331);
            this.enable_price_search.Name = "enable_price_search";
            this.enable_price_search.Size = new System.Drawing.Size(75, 23);
            this.enable_price_search.TabIndex = 14;
            this.enable_price_search.Text = "Enable";
            this.enable_price_search.UseVisualStyleBackColor = true;
            this.enable_price_search.Click += new System.EventHandler(this.enable_price_search_Click);
            // 
            // lower_range
            // 
            this.lower_range.Enabled = false;
            this.lower_range.Location = new System.Drawing.Point(148, 331);
            this.lower_range.Name = "lower_range";
            this.lower_range.Size = new System.Drawing.Size(105, 22);
            this.lower_range.TabIndex = 15;
            this.lower_range.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // upper_range
            // 
            this.upper_range.Enabled = false;
            this.upper_range.Location = new System.Drawing.Point(306, 331);
            this.upper_range.Name = "upper_range";
            this.upper_range.Size = new System.Drawing.Size(105, 22);
            this.upper_range.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search by price range";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upper_range);
            this.Controls.Add(this.lower_range);
            this.Controls.Add(this.enable_price_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.floor_searcher);
            this.Controls.Add(this.enable_floor_search);
            this.Controls.Add(this.city_name);
            this.Controls.Add(this.city_searcher);
            this.Controls.Add(this.enable_city_search);
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
        private System.Windows.Forms.Button enable_city_search;
        private System.Windows.Forms.TextBox city_searcher;
        private System.Windows.Forms.Label city_name;
        private System.Windows.Forms.Button enable_floor_search;
        private System.Windows.Forms.TextBox floor_searcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enable_price_search;
        private System.Windows.Forms.TextBox lower_range;
        private System.Windows.Forms.TextBox upper_range;
        private System.Windows.Forms.Label label2;
    }
}