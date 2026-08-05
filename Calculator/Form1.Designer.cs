namespace Calculator
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
            inputBox = new TextBox();
            n9 = new Button();
            n8 = new Button();
            n7 = new Button();
            n6 = new Button();
            n5 = new Button();
            n4 = new Button();
            n3 = new Button();
            n2 = new Button();
            n1 = new Button();
            n0 = new Button();
            plus = new Button();
            minus = new Button();
            multiply = new Button();
            divide = new Button();
            equalsTo = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(224, 38);
            inputBox.Margin = new Padding(5, 4, 5, 4);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(615, 39);
            inputBox.TabIndex = 0;
            inputBox.TextAlign = HorizontalAlignment.Right;
            // 
            // n9
            // 
            n9.Location = new Point(224, 125);
            n9.Margin = new Padding(5, 4, 5, 4);
            n9.Name = "n9";
            n9.Size = new Size(124, 64);
            n9.TabIndex = 1;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += n9_Click;
            // 
            // n8
            // 
            n8.Location = new Point(356, 125);
            n8.Margin = new Padding(5, 4, 5, 4);
            n8.Name = "n8";
            n8.Size = new Size(124, 64);
            n8.TabIndex = 2;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += n8_Click;
            // 
            // n7
            // 
            n7.Font = new Font("Tempus Sans ITC", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n7.Location = new Point(488, 125);
            n7.Margin = new Padding(5, 4, 5, 4);
            n7.Name = "n7";
            n7.Size = new Size(124, 64);
            n7.TabIndex = 7;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += n7_Click;
            // 
            // n6
            // 
            n6.Location = new Point(224, 197);
            n6.Margin = new Padding(5, 4, 5, 4);
            n6.Name = "n6";
            n6.Size = new Size(124, 64);
            n6.TabIndex = 4;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += n6_Click;
            // 
            // n5
            // 
            n5.Location = new Point(356, 197);
            n5.Margin = new Padding(5, 4, 5, 4);
            n5.Name = "n5";
            n5.Size = new Size(124, 64);
            n5.TabIndex = 5;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += n5_Click;
            // 
            // n4
            // 
            n4.Location = new Point(488, 197);
            n4.Margin = new Padding(5, 4, 5, 4);
            n4.Name = "n4";
            n4.Size = new Size(124, 64);
            n4.TabIndex = 6;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += n4_Click;
            // 
            // n3
            // 
            n3.Location = new Point(224, 269);
            n3.Margin = new Padding(5, 4, 5, 4);
            n3.Name = "n3";
            n3.Size = new Size(124, 64);
            n3.TabIndex = 7;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += n3_Click;
            // 
            // n2
            // 
            n2.Location = new Point(356, 269);
            n2.Margin = new Padding(5, 4, 5, 4);
            n2.Name = "n2";
            n2.Size = new Size(124, 64);
            n2.TabIndex = 8;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += n2_Click;
            // 
            // n1
            // 
            n1.Location = new Point(488, 269);
            n1.Margin = new Padding(5, 4, 5, 4);
            n1.Name = "n1";
            n1.Size = new Size(124, 64);
            n1.TabIndex = 9;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += n1_Click;
            // 
            // n0
            // 
            n0.Location = new Point(356, 341);
            n0.Margin = new Padding(5, 4, 5, 4);
            n0.Name = "n0";
            n0.Size = new Size(124, 64);
            n0.TabIndex = 10;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += n0_Click;
            // 
            // plus
            // 
            plus.Location = new Point(715, 125);
            plus.Margin = new Padding(5, 4, 5, 4);
            plus.Name = "plus";
            plus.Size = new Size(124, 64);
            plus.TabIndex = 11;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.Location = new Point(715, 197);
            minus.Margin = new Padding(5, 4, 5, 4);
            minus.Name = "minus";
            minus.Size = new Size(124, 64);
            minus.TabIndex = 12;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(715, 269);
            multiply.Margin = new Padding(5, 4, 5, 4);
            multiply.Name = "multiply";
            multiply.Size = new Size(124, 64);
            multiply.TabIndex = 13;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.Location = new Point(715, 341);
            divide.Margin = new Padding(5, 4, 5, 4);
            divide.Name = "divide";
            divide.Size = new Size(124, 64);
            divide.TabIndex = 14;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // equalsTo
            // 
            equalsTo.Location = new Point(488, 341);
            equalsTo.Margin = new Padding(5, 4, 5, 4);
            equalsTo.Name = "equalsTo";
            equalsTo.Size = new Size(124, 64);
            equalsTo.TabIndex = 15;
            equalsTo.Text = "=";
            equalsTo.UseVisualStyleBackColor = true;
            equalsTo.Click += equalsTo_Click;
            // 
            // clear
            // 
            clear.Location = new Point(224, 341);
            clear.Margin = new Padding(5, 4, 5, 4);
            clear.Name = "clear";
            clear.Size = new Size(124, 64);
            clear.TabIndex = 16;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1120, 558);
            Controls.Add(clear);
            Controls.Add(equalsTo);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(n0);
            Controls.Add(n1);
            Controls.Add(n2);
            Controls.Add(n3);
            Controls.Add(n4);
            Controls.Add(n5);
            Controls.Add(n6);
            Controls.Add(n7);
            Controls.Add(n8);
            Controls.Add(n9);
            Controls.Add(inputBox);
            Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private Button n9;
        private Button n8;
        private Button n7;
        private Button n6;
        private Button n5;
        private Button n4;
        private Button n3;
        private Button n2;
        private Button n1;
        private Button n0;
        private Button plus;
        private Button minus;
        private Button multiply;
        private Button divide;
        private Button equalsTo;
        private Button clear;
    }
}
