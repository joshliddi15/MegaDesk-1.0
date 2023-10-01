using System.Text.RegularExpressions;

namespace MegaDesk_1._0
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            DeskQuote newDeskQuote = new DeskQuote();
            dateLabel.Text = "Quote Date: " + DateTime.Now.ToString("dd MMM yyyy");
            matlBox.DataSource = Enum.GetValues(typeof(desktopMatl));
            matlBox.DisplayMember = "ToString";
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form DisplayQuote = new DisplayQuote();
            this.Hide();
            DisplayQuote.FormClosed += Button2_Click;
            DisplayQuote.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.White;
                string input = textBox1.Text;

                // Use a regular expression to remove non-numeric characters
                string numericOnly = Regex.Replace(input, "[^0-9]", "");

                // Update the TextBox with the cleaned input
                textBox1.Text = numericOnly;

                int parsedValue = int.Parse(textBox1.Text); // Attempt to parse the entered text as an integer

                // Replace these values with your desired range
                int minValue = 24;
                int maxValue = 96;

                if (parsedValue >= minValue && parsedValue <= maxValue)
                {
                    textBox1.ForeColor = Color.Black; // Set the text color to show  valid input
                    label7.Visible = false;
                }
                else
                {
                    throw new Exception("Value is outside the valid range"); // Raise an error
                }
            }
            catch (Exception ex)
            {
                textBox1.ForeColor = Color.Red; // Set the text color red to show invalid input
                label7.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.ForeColor = Color.White;
                string input = textBox2.Text;

                // Use a regular expression to remove non-numeric characters
                string numericOnly = Regex.Replace(input, "[^0-9]", "");

                // Update the TextBox with the cleaned input
                textBox2.Text = numericOnly;

                int parsedValue = int.Parse(textBox2.Text); // Attempt to parse the entered text as an integer

                // Replace these values with your desired range
                int minValue = 24;
                int maxValue = 96;

              if (parsedValue >= minValue && parsedValue <= maxValue)
                {
                    textBox2.ForeColor = Color.Black; // Set the text color to show  valid input
                    label8.Visible = false;
                }
                else
                {
                    throw new Exception("Value is outside the valid range"); // Raise an error
                }
            }
            catch (Exception ex)
            {
                textBox2.ForeColor = Color.Red; // Set the text color red to show invalid input
                label8.Visible = true;
            }
        }
    }
}
