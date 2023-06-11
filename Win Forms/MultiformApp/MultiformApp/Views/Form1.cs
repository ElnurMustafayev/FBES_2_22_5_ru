namespace MultiformApp.Views {

    public partial class Form1 : Form {
        private Form form;

        public Form1() {
            InitializeComponent();

            this.form = new SecondForm(100, this);

            //for (int i = 0; i < 100; i++) {
            //    var button = GetButton("test", 300, (i * 30));
            //    this.Controls.Add(button);
            //}
        }

        private void button1_Click(object sender, EventArgs e) {
            //var form = new SecondForm(30);
            //MessageBox.Show("Test");
            //form.Show();
            //form.ShowDialog();

            //this.secondForm.Show();
            //this.form.ShowDialog();



            //this.Visible = false;
            this.Close();
            this.form.ShowDialog();
            //this.Visible = true;
        }

        //public Button GetButton(string text, int posX, int posY) {
        //    var button = new Button();

        //    button.Location = new Point(posX, posY);
        //    button.Text = text;
        //    button.Size = new Size(200, 30);
        //    button.TabIndex = 0;
        //    button.UseVisualStyleBackColor = true;

        //    return button;
        //}
    }
}