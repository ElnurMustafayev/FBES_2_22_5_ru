namespace ComponentsApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ProceedButton_Click(object sender, EventArgs e) {

            //MessageBox.Show(sender.GetType().Name);


            try {
                string num1Str = this.FirstTextBox.Text;
                string num2Str = this.SecondTextBox.Text;

                if (string.IsNullOrWhiteSpace(num1Str) || string.IsNullOrWhiteSpace(num2Str))
                    throw new ArgumentNullException(message: "Numbers can not be empty!", paramName: "textbox");

                if (int.TryParse(num1Str, out int num1) == false || int.TryParse(num2Str, out int num2) == false)
                    throw new ArgumentException(message: "Text must be a number!", paramName: "textbox");
                
                this.ResultTextBox.Text = (num1 + num2).ToString();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
    }
}