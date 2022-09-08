namespace TempConverter__UI_
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UserInsert = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Button();
            this.Rights = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Celsuis To Fahrenheit",
            "Fahrenheit To Celsuis",
            "Celsuis To Kelvin",
            "Fahrenheit to Kelvin",
            "Kelvin to Fahrenheit",
            "Kelvin to celsuis"});
            this.listBox1.Location = new System.Drawing.Point(14, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(404, 94);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UserInsert
            // 
            this.UserInsert.AutoSize = true;
            this.UserInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInsert.Location = new System.Drawing.Point(11, 116);
            this.UserInsert.Name = "UserInsert";
            this.UserInsert.Size = new System.Drawing.Size(129, 15);
            this.UserInsert.TabIndex = 4;
            this.UserInsert.Text = "Insert Temperature";
            this.UserInsert.Click += new System.EventHandler(this.UserInsert_Click);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(326, 167);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(90, 27);
            this.convert.TabIndex = 3;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // Rights
            // 
            this.Rights.AutoSize = true;
            this.Rights.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rights.Location = new System.Drawing.Point(12, 254);
            this.Rights.Name = "Rights";
            this.Rights.Size = new System.Drawing.Size(88, 12);
            this.Rights.TabIndex = 5;
            this.Rights.Text = "Peter Hamilton 2020";
            this.Rights.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 275);
            this.Controls.Add(this.Rights);
            this.Controls.Add(this.UserInsert);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Temperature Converter 2.1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label UserInsert;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label Rights;
    }
}

