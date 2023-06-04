namespace MoneyConverterApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MoneyTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrencyCombobox = new System.Windows.Forms.ComboBox();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.MessageRichTextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MoneyTextbox
            // 
            this.MoneyTextbox.Location = new System.Drawing.Point(181, 31);
            this.MoneyTextbox.Name = "MoneyTextbox";
            this.MoneyTextbox.Size = new System.Drawing.Size(265, 23);
            this.MoneyTextbox.TabIndex = 0;
            this.MoneyTextbox.TextChanged += new System.EventHandler(this.ConvertMoney);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "AZN:";
            // 
            // CurrencyCombobox
            // 
            this.CurrencyCombobox.FormattingEnabled = true;
            this.CurrencyCombobox.Location = new System.Drawing.Point(181, 77);
            this.CurrencyCombobox.Name = "CurrencyCombobox";
            this.CurrencyCombobox.Size = new System.Drawing.Size(265, 23);
            this.CurrencyCombobox.TabIndex = 3;
            this.CurrencyCombobox.SelectedIndexChanged += new System.EventHandler(this.ConvertMoney);
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(12, 191);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(434, 23);
            this.ResultTextbox.TabIndex = 4;
            // 
            // MessageRichTextbox
            // 
            this.MessageRichTextbox.Location = new System.Drawing.Point(480, 12);
            this.MessageRichTextbox.Name = "MessageRichTextbox";
            this.MessageRichTextbox.ReadOnly = true;
            this.MessageRichTextbox.Size = new System.Drawing.Size(308, 202);
            this.MessageRichTextbox.TabIndex = 5;
            this.MessageRichTextbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageRichTextbox);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.CurrencyCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoneyTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox MoneyTextbox;
        private Label label1;
        private ComboBox CurrencyCombobox;
        private TextBox ResultTextbox;
        private RichTextBox MessageRichTextbox;
    }
}