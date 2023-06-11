using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiformApp.Views {
    public partial class SecondForm : Form {
        private int number;

        public SecondForm(int number, Form ownerForm) {
            this.number = number;
            InitializeComponent();

            this.textBox1.Text = number.ToString();
            ownerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.number++;
            this.textBox1.Text = number.ToString();
        }
    }
}
