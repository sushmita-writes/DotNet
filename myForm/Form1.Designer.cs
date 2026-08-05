namespace myForm
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
            fullName = new TextBox();
            rollNumber = new TextBox();
            faculty = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            saveButton = new Button();
            clearButton = new Button();
            showButton = new Button();
            infoBox = new RichTextBox();
            SuspendLayout();
            // 
            // fullName
            // 
            fullName.Location = new Point(230, 63);
            fullName.Name = "fullName";
            fullName.Size = new Size(458, 29);
            fullName.TabIndex = 0;
            // 
            // rollNumber
            // 
            rollNumber.Location = new Point(230, 123);
            rollNumber.Name = "rollNumber";
            rollNumber.Size = new Size(236, 29);
            rollNumber.TabIndex = 1;
            // 
            // faculty
            // 
            faculty.Location = new Point(230, 183);
            faculty.Name = "faculty";
            faculty.Size = new Size(329, 29);
            faculty.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 69);
            label1.Name = "label1";
            label1.Size = new Size(97, 22);
            label1.TabIndex = 3;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 128);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 4;
            label2.Text = "Roll Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 188);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 5;
            label3.Text = "Faculty";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(594, 270);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 59);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(594, 335);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 59);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // showButton
            // 
            showButton.Location = new Point(594, 400);
            showButton.Name = "showButton";
            showButton.Size = new Size(94, 59);
            showButton.TabIndex = 8;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // infoBox
            // 
            infoBox.Location = new Point(73, 270);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(504, 189);
            infoBox.TabIndex = 9;
            infoBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 471);
            Controls.Add(infoBox);
            Controls.Add(showButton);
            Controls.Add(clearButton);
            Controls.Add(saveButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(faculty);
            Controls.Add(rollNumber);
            Controls.Add(fullName);
            Font = new Font("Book Antiqua", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fullName;
        private TextBox rollNumber;
        private TextBox faculty;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveButton;
        private Button clearButton;
        private Button showButton;
        private RichTextBox infoBox;
    }
}
