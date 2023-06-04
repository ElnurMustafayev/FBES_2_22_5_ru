namespace MoneyConverterApp {
    public partial class Form1 : Form {
        private readonly Currency[] Currencies;

        public Form1() {
            InitializeComponent();

            this.Currencies = new Currency[] {
                new Currency("AZN", 1),
                new Currency("RUB", 47.53),
                new Currency("USD", 0.59),
            };

            this.CurrencyCombobox.Items.AddRange(this.Currencies);
            this.CurrencyCombobox.SelectedIndex = 0;
        }

        private double ConvertMoneyByCombobox(ComboBox comboBox, double money) {
            if (comboBox == null || comboBox.SelectedIndex == -1)
                throw new Exception("Combobox is empty!");

            switch (comboBox.SelectedIndex) {
                case 0:
                    return money * 1;
                case 1:
                    return money * 47.53;
                case 2:
                    return money * 0.59;

                default:
                    throw new NotImplementedException(message: $"Implementation not found for currency '{comboBox.SelectedItem}'");
            }
        }

        private void ConvertMoney(object sender, EventArgs e) {
            try {
                //ArgumentNullException.ThrowIfNull(textBox.Text, nameof(textBox.Text));
                string moneyStr = this.MoneyTextbox.Text;

                if (string.IsNullOrWhiteSpace(moneyStr))
                    throw new ArgumentNullException(paramName: nameof(moneyStr), message: "Please write money!");

                if (double.TryParse(moneyStr, out double money) == false)
                    throw new FormatException(message: "Please write money in correct format! (Only digits)");

                if(this.CurrencyCombobox.SelectedItem is Currency currentCurrency) {
                    var result = currentCurrency.Convert(money);
                    this.ResultTextbox.Text = result.ToString();
                }

                //double result = ConvertMoneyByCombobox(this.CurrencyCombobox, money);

                this.MessageRichTextbox.Text = string.Empty;
            }
            catch(Exception ex) {
                this.MessageRichTextbox.Text = ex.Message;
            }
        }
    }
}