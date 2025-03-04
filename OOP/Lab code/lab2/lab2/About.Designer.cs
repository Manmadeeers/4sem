namespace lab2
{
    partial class About
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
            this.version_name = new System.Windows.Forms.Label();
            this.developer_name = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // version_name
            // 
            this.version_name.AutoSize = true;
            this.version_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version_name.Location = new System.Drawing.Point(195, 49);
            this.version_name.Name = "version_name";
            this.version_name.Size = new System.Drawing.Size(119, 32);
            this.version_name.TabIndex = 0;
            this.version_name.Text = "Version:";
            // 
            // developer_name
            // 
            this.developer_name.AutoSize = true;
            this.developer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developer_name.Location = new System.Drawing.Point(195, 112);
            this.developer_name.Name = "developer_name";
            this.developer_name.Size = new System.Drawing.Size(196, 32);
            this.developer_name.TabIndex = 1;
            this.developer_name.Text = "Developed by:";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(201, 176);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(124, 36);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 246);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.developer_name);
            this.Controls.Add(this.version_name);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label version_name;
        private System.Windows.Forms.Label developer_name;
        private System.Windows.Forms.Button back_button;
    }
}