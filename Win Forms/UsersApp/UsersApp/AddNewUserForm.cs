using System.Collections;

namespace UsersApp {
    public partial class AddNewUserForm : Form {
        private readonly IList usersCollection;

        public AddNewUserForm(IList usersCollection) {
            InitializeComponent();
            this.usersCollection = usersCollection;

            this.WarningRichTextBox.ReadOnly = true;
            this.WarningRichTextBox.ForeColor = Color.Red;
        }

        public void RefreshComponets() {
            this.WarningRichTextBox.Text = string.Empty;
            this.NameTextbox.Text = string.Empty;
            this.SurnameTextbox.Text = string.Empty;
        }

        private void OkButton_Click(object sender, EventArgs e) {
            try {
                var newUser = new User(
                    firstName: this.NameTextbox.Text,
                    lastName: this.SurnameTextbox.Text);

                this.usersCollection.Add(newUser);

                this.RefreshComponets();
                this.Close();
            }
            catch(Exception ex) {
                this.WarningRichTextBox.Text = ex.Message;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.RefreshComponets();
            this.Close();
        }
    }
}
