namespace myForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (fullName.Text == "" || rollNumber.Text == "" || faculty.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save data to a text file
            using (StreamWriter writer = new StreamWriter("info.txt", true))
            {
                writer.WriteLine("**********************");
                writer.WriteLine("Name:  " + fullName.Text);
                writer.WriteLine("Roll Number:  " + rollNumber.Text);
                writer.WriteLine("Faculty:  " + faculty.Text);
                writer.WriteLine("**********************");
            }

            MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields after saving
            fullName.Clear();
            rollNumber.Clear();
            faculty.Clear();
            fullName.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fullName.Clear();
            rollNumber.Clear();
            faculty.Clear();
            fullName.Focus();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("info.txt"))
            {
                using (StreamReader reader = new StreamReader("info.txt"))
                {
                    infoBox.Text = reader.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("No Info!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
