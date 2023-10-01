namespace MegaDesk_1._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void displayQuoteBtnClick(object sender, EventArgs e)
        {
            Form displayQuote = new DisplayQuote();
            this.Hide();
            displayQuote.FormClosed += ShowMainForm;
            displayQuote.Show();
        }

        private void viewAllQuotesBtnClick(object sender, EventArgs e)
        {
            Form viewAllQuotes = new ViewAllQuotes();
            this.Hide();
            viewAllQuotes.FormClosed += ShowMainForm;
            viewAllQuotes.Show();
        }

        private void exitBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchQuotesBtnClick(object sender, EventArgs e)
        {
            Form searchQuote = new SearchQuotes();
            this.Hide();
            searchQuote.FormClosed += ShowMainForm;
            searchQuote.Show();
        }

        private void newQuoteBtn_Click(object sender, EventArgs e)
        {
            Form AddQuote = new AddQuote();
            this.Hide();
            AddQuote.FormClosed += ShowMainForm;
            AddQuote.Show();
        }

        private void ShowMainForm(object? sender, FormClosedEventArgs e)
        {
            this.Show();

        }
    }
}