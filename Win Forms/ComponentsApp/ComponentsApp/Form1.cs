namespace ComponentsApp {
    class User {

    }

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            this.listBox1.Items.Add("test");
            this.listBox1.Items.Add(new User());
            this.listBox1.Items.Add("test");

            this.ResultTextBox.ReadOnly = true;

            this.comboBox1.Items.Add("One");
            this.comboBox1.Items.Add("Two");
            this.comboBox1.Items.Add("Three");
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.BackColor = Color.FromArgb(red: 100, green: 100, blue: 100);

            this.pictureBox1.ImageLocation = "https://media.tenor.com/InVopqVqtdAAAAAd/cat-small.gif";
            checkBox1_CheckedChanged(this.checkBox1, EventArgs.Empty);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if(sender is CheckBox checkBox) {
                this.pictureBox1.Visible = checkBox.Checked;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if(sender is ComboBox comboBox) {
                MessageBox.Show(comboBox.SelectedIndex.ToString());
            }
        }
    }
}