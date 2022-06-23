namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Operation = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.nonint = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.Operation);
            this.panel1.Controls.Add(this.text);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 212);
            this.panel1.TabIndex = 0;
            // 
            // Operation
            // 
            this.Operation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.Operation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Operation.Cursor = System.Windows.Forms.Cursors.No;
            this.Operation.Font = new System.Drawing.Font("Microsoft JhengHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Operation.ForeColor = System.Drawing.Color.White;
            this.Operation.Location = new System.Drawing.Point(25, 62);
            this.Operation.Multiline = true;
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Size = new System.Drawing.Size(195, 95);
            this.Operation.TabIndex = 1;
            this.Operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Cursor = System.Windows.Forms.Cursors.No;
            this.text.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(265, 62);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(684, 95);
            this.text.TabIndex = 0;
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(24, 258);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(195, 83);
            this.delete.TabIndex = 1;
            this.delete.Text = "C";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.cos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cos.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cos.ForeColor = System.Drawing.Color.White;
            this.cos.Location = new System.Drawing.Point(264, 258);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(195, 83);
            this.cos.TabIndex = 2;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // pow
            // 
            this.pow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.pow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pow.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pow.ForeColor = System.Drawing.Color.White;
            this.pow.Location = new System.Drawing.Point(506, 258);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(195, 83);
            this.pow.TabIndex = 3;
            this.pow.Text = "^";
            this.pow.UseVisualStyleBackColor = false;
            this.pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.division.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.division.ForeColor = System.Drawing.Color.White;
            this.division.Location = new System.Drawing.Point(753, 258);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(195, 83);
            this.division.TabIndex = 4;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // number7
            // 
            this.number7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.number7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number7.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number7.ForeColor = System.Drawing.Color.White;
            this.number7.Location = new System.Drawing.Point(24, 374);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(195, 83);
            this.number7.TabIndex = 5;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = false;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.number8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number8.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number8.ForeColor = System.Drawing.Color.White;
            this.number8.Location = new System.Drawing.Point(264, 374);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(195, 83);
            this.number8.TabIndex = 6;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = false;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.number9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number9.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number9.ForeColor = System.Drawing.Color.White;
            this.number9.Location = new System.Drawing.Point(506, 374);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(195, 83);
            this.number9.TabIndex = 7;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = false;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiply.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiply.ForeColor = System.Drawing.Color.White;
            this.multiply.Location = new System.Drawing.Point(753, 374);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(195, 83);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.number4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number4.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number4.ForeColor = System.Drawing.Color.White;
            this.number4.Location = new System.Drawing.Point(24, 492);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(195, 83);
            this.number4.TabIndex = 9;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = false;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.number5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number5.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number5.ForeColor = System.Drawing.Color.White;
            this.number5.Location = new System.Drawing.Point(264, 492);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(195, 83);
            this.number5.TabIndex = 10;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = false;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            this.number6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.number6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number6.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number6.ForeColor = System.Drawing.Color.White;
            this.number6.Location = new System.Drawing.Point(506, 492);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(195, 83);
            this.number6.TabIndex = 11;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = false;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minus.ForeColor = System.Drawing.Color.White;
            this.minus.Location = new System.Drawing.Point(753, 492);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(195, 83);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.number1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number1.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number1.ForeColor = System.Drawing.Color.White;
            this.number1.Location = new System.Drawing.Point(24, 608);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(195, 83);
            this.number1.TabIndex = 13;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.number2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number2.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number2.ForeColor = System.Drawing.Color.White;
            this.number2.Location = new System.Drawing.Point(264, 608);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(195, 83);
            this.number2.TabIndex = 14;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = false;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.number3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number3.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number3.ForeColor = System.Drawing.Color.White;
            this.number3.Location = new System.Drawing.Point(506, 608);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(195, 83);
            this.number3.TabIndex = 15;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = false;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plus.ForeColor = System.Drawing.Color.White;
            this.plus.Location = new System.Drawing.Point(753, 608);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(195, 83);
            this.plus.TabIndex = 16;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // number0
            // 
            this.number0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.number0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number0.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number0.ForeColor = System.Drawing.Color.White;
            this.number0.Location = new System.Drawing.Point(24, 726);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(435, 83);
            this.number0.TabIndex = 17;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = false;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // nonint
            // 
            this.nonint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.nonint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nonint.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nonint.ForeColor = System.Drawing.Color.White;
            this.nonint.Location = new System.Drawing.Point(506, 726);
            this.nonint.Name = "nonint";
            this.nonint.Size = new System.Drawing.Size(195, 83);
            this.nonint.TabIndex = 18;
            this.nonint.Text = ",";
            this.nonint.UseVisualStyleBackColor = false;
            this.nonint.Click += new System.EventHandler(this.nonint_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equal.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equal.ForeColor = System.Drawing.Color.White;
            this.equal.Location = new System.Drawing.Point(753, 726);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(195, 83);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(989, 853);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.nonint);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.division);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button delete;
        private Button cos;
        private Button pow;
        private Button division;
        private Button number7;
        private Button number8;
        private Button number9;
        private Button multiply;
        private Button number4;
        private Button number5;
        private Button number6;
        private Button minus;
        private Button number1;
        private Button number2;
        private Button number3;
        private Button plus;
        private Button number0;
        private Button nonint;
        private Button equal;
        private TextBox Operation;
        protected TextBox text;
    }
}