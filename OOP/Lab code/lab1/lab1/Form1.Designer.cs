namespace lab1
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.square_calc_button = new System.Windows.Forms.Button();
            this.material_calc_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome_label.Location = new System.Drawing.Point(135, 55);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(495, 38);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome to Materials Calculator!";
            // 
            // square_calc_button
            // 
            this.square_calc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.square_calc_button.Location = new System.Drawing.Point(447, 212);
            this.square_calc_button.Name = "square_calc_button";
            this.square_calc_button.Size = new System.Drawing.Size(203, 79);
            this.square_calc_button.TabIndex = 2;
            this.square_calc_button.Text = "I have materials. Calculate!";
            this.square_calc_button.UseVisualStyleBackColor = true;
            // 
            // material_calc_button
            // 
            this.material_calc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.material_calc_button.Location = new System.Drawing.Point(142, 212);
            this.material_calc_button.Name = "material_calc_button";
            this.material_calc_button.Size = new System.Drawing.Size(203, 79);
            this.material_calc_button.TabIndex = 3;
            this.material_calc_button.Text = "I don\'t have materials. Calculate!";
            this.material_calc_button.UseVisualStyleBackColor = true;
            this.material_calc_button.Click += new System.EventHandler(this.material_calc_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 622);
            this.Controls.Add(this.material_calc_button);
            this.Controls.Add(this.square_calc_button);
            this.Controls.Add(this.welcome_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button square_calc_button;
        private System.Windows.Forms.Button material_calc_button;
    }
}

