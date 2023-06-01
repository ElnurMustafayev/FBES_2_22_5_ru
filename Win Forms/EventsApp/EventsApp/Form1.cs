namespace EventsApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // public delegate void EventHandler(object? sender, EventArgs e);
            // public event EventHandler Click { add; remove; }

            //this.button1.Click += new EventHandler(ClickEvent);
            //this.button1.Click += ClickEvent;
            //this.button1.Click += delegate (object? sender, EventArgs e) {
            //    MessageBox.Show("Anonimous Delegate");
            //};



            //this.button1.Click += (sender, e) => MessageBox.Show("Lambda");

            //this.button1.MouseDown += MouseClick;
            //this.textBox1.MouseDown += MouseClick;
            //this.textBox1.MouseDown += (s, e) => { Console.WriteLine(e); };



            //this.textBox1.TextChanged += (sender, e) => {
            //    if(sender is TextBox textbox) {
            //        this.button1.Enabled = (string.IsNullOrWhiteSpace(textbox.Text) == false && textbox.Text.Length > 10);
            //    }
            //};

            // label / richtextbox

            // 1. success / error
            // 2. success / error list

            // if(success): button("Register").Visible = True;
            // else:        button("Register").Visible = False;

            // input (Password)
            // not empty
            // length >= 10
            // contains digits (min 1)
            // starts with capital symbol


            this.button1.Visible = false;
            this.richTextBox1.Enabled = false;
            PasswordInput(this.textBox1, null);

            this.textBox1.TextChanged += PasswordInput;
        }

        private void PasswordInput(object? sender, EventArgs e) {
            if (sender is TextBox textBox) {
                var inputText = textBox.Text;

                var errorMessages = new List<string>();

                if (string.IsNullOrEmpty(inputText)) {
                    errorMessages.Add("not empty");
                    //throw new Exception("not empty");
                }

                if (string.IsNullOrEmpty(inputText) || inputText.Length < 10) {
                    errorMessages.Add("length >= 10");
                    //throw new Exception("length >= 10");
                }

                if (HasDigits(inputText) == false) {
                    errorMessages.Add("contains digits (min 1)");
                    //throw new Exception("contains digits (min 1)");
                }

                if (StartsWithCapital(inputText) == false) {
                    errorMessages.Add("starts with capital symbol");
                    //throw new Exception("starts with capital symbol");
                }

                if (errorMessages.Count == 0) {
                    // success
                    this.button1.Visible = true;
                    this.richTextBox1.Text = "Success";
                }
                else {
                    this.button1.Visible = false;
                    this.richTextBox1.Text = string.Empty;

                    foreach (var errorMessage in errorMessages) {
                        this.richTextBox1.Text += $"{errorMessage}\n";
                    }
                }
            }
        }


        private bool StartsWithCapital(string text) {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            var firstSymbol = text[0];

            return (char.IsLetter(firstSymbol) && firstSymbol == char.ToUpper(firstSymbol));
        }

        private bool HasDigits(string text) {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            foreach (var symbol in text) {
                if (char.IsDigit(symbol))
                    return true;
            }

            return false;
        }

        //private void MouseClick(object? sender, MouseEventArgs e) {

        //    MessageBox.Show($"{e.Button.ToString()} mouse button clicked. Element: {sender}");
        //}

        //private void ClickEvent(object? sender, EventArgs e) {
        //    MessageBox.Show("Create Method");
        //}
    }
}