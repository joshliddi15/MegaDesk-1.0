using System.Text;

namespace MegaDesk_1._0
{
    public partial class SearchQuotes : Form
    {

        public class DeskQuoteData
        {
            public int quoteID;
            public double deskWidth;
            public double deskDepth;
            public int deskDrawerCnt;
            public desktopMatl deskMatl;
            public string customerName;
            public double quoteAmount;
        }

        public SearchQuotes()
        {
            InitializeComponent();
            matlBox.DataSource = Enum.GetValues(typeof(desktopMatl));
            matlBox.DisplayMember = "ToString";
            string csvFilePath = "quotes.csv";
            List<DeskQuoteData> quotes = LoadQuotesFromCsv(csvFilePath);
            QuotesListBox.DataSource = quotes;
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            string csvFilePath = "quotes.csv";
            List<DeskQuoteData> quotes = LoadQuotesFromCsv(csvFilePath);
            QuotesListBox.DataSource = quotes;

        }

        private List<DeskQuoteData> LoadQuotesFromCsv(string quotesHistoryFilePath)
        {
            List<DeskQuoteData> quotes = new List<DeskQuoteData>();
            //if (File.Exists(quotesHistoryFilePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(quotesHistoryFilePath, Encoding.UTF8);

                    foreach (string line in lines.Skip(1))
                    {
                        string[] fields = line.Split(',');

                        if (fields.Length >= 7)
                        {
                            DeskQuoteData quoteData = new DeskQuoteData
                            {
                                quoteID = int.Parse(fields[0]),
                                deskWidth = double.Parse(fields[1]),
                                deskDepth = double.Parse(fields[2]),
                                deskDrawerCnt = int.Parse(fields[3]),
                                deskMatl = (desktopMatl)Enum.Parse(typeof(desktopMatl), fields[4]),
                                customerName = fields[5],
                                quoteAmount = double.Parse(fields[6])
                            };

                            quotes.Add(quoteData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading quotes: {ex.Message}");
                }
            }
            return quotes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
