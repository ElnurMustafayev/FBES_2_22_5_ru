namespace GettingStartedApp {
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
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(52)))), ((int)(((byte)(255)))));
            this.ClickMeButton.Cursor = System.Windows.Forms.Cursors.No;
            this.ClickMeButton.Font = new System.Drawing.Font("Swis721 BlkEx BT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ClickMeButton.ForeColor = System.Drawing.Color.Yellow;
            this.ClickMeButton.Location = new System.Drawing.Point(231, 159);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClickMeButton.Size = new System.Drawing.Size(317, 98);
            this.ClickMeButton.TabIndex = 0;
            this.ClickMeButton.Text = "click me";
            this.ClickMeButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ClickMeButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClickMeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ClickMeButton;
    }
}