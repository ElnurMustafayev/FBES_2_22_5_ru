namespace ComponentsApp {
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
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Location = new System.Drawing.Point(12, 12);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(146, 23);
            this.FirstTextBox.TabIndex = 0;
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(211, 12);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(146, 23);
            this.SecondTextBox.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(511, 12);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(277, 23);
            this.ResultTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(399, 12);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(75, 23);
            this.ProceedButton.TabIndex = 5;
            this.ProceedButton.Text = "=";
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show cat picture";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 351);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(417, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SecondTextBox);
            this.Controls.Add(this.FirstTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstTextBox;
        private TextBox SecondTextBox;
        private TextBox ResultTextBox;
        private Label label1;
        private Button ProceedButton;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
    }
}