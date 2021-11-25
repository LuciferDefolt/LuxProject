namespace TestProjectLuxoft
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
            this.CallNumber = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PersonNameField = new System.Windows.Forms.Label();
            this.PersonNumberField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CallNumber
            // 
            this.CallNumber.Location = new System.Drawing.Point(12, 111);
            this.CallNumber.Name = "CallNumber";
            this.CallNumber.Size = new System.Drawing.Size(169, 23);
            this.CallNumber.TabIndex = 0;
            this.CallNumber.Text = "Call";
            this.CallNumber.UseVisualStyleBackColor = true;
            this.CallNumber.Click += new System.EventHandler(this.CallNumber_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PersonNameField
            // 
            this.PersonNameField.AutoSize = true;
            this.PersonNameField.Location = new System.Drawing.Point(12, 13);
            this.PersonNameField.Name = "PersonNameField";
            this.PersonNameField.Size = new System.Drawing.Size(0, 13);
            this.PersonNameField.TabIndex = 4;
            // 
            // PersonNumberField
            // 
            this.PersonNumberField.AutoSize = true;
            this.PersonNumberField.Location = new System.Drawing.Point(12, 43);
            this.PersonNumberField.Name = "PersonNumberField";
            this.PersonNumberField.Size = new System.Drawing.Size(0, 13);
            this.PersonNumberField.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 144);
            this.Controls.Add(this.PersonNumberField);
            this.Controls.Add(this.PersonNameField);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CallNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CallNumber;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PersonNameField;
        private System.Windows.Forms.Label PersonNumberField;
    }
}

