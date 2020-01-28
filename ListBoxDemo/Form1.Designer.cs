namespace ListBoxDemo
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
            this.demoListBox = new System.Windows.Forms.ListBox();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteItemsButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // demoListBox
            // 
            this.demoListBox.FormattingEnabled = true;
            this.demoListBox.Location = new System.Drawing.Point(13, 13);
            this.demoListBox.Name = "demoListBox";
            this.demoListBox.Size = new System.Drawing.Size(120, 407);
            this.demoListBox.TabIndex = 0;
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(140, 13);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(100, 20);
            this.stringTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(140, 40);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteItemsButton
            // 
            this.deleteItemsButton.Location = new System.Drawing.Point(221, 40);
            this.deleteItemsButton.Name = "deleteItemsButton";
            this.deleteItemsButton.Size = new System.Drawing.Size(75, 23);
            this.deleteItemsButton.TabIndex = 3;
            this.deleteItemsButton.Text = "Delete";
            this.deleteItemsButton.UseVisualStyleBackColor = true;
            this.deleteItemsButton.Click += new System.EventHandler(this.deleteItemsButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deleteItemsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.demoListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox demoListBox;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteItemsButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

