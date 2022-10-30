namespace MyAssignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputField = new System.Windows.Forms.TextBox();
            this.MainDisplay = new System.Windows.Forms.PictureBox();
            this.SecondTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(379, 460);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(302, 27);
            this.InputField.TabIndex = 2;
            this.InputField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputField_KeyDown);
            // 
            // MainDisplay
            // 
            this.MainDisplay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainDisplay.Location = new System.Drawing.Point(358, 95);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.Size = new System.Drawing.Size(484, 302);
            this.MainDisplay.TabIndex = 3;
            this.MainDisplay.TabStop = false;
            this.MainDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.MainDisplay_Paint);
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(57, 95);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(245, 292);
            this.SecondTextBox.TabIndex = 4;
            this.SecondTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 587);
            this.Controls.Add(this.SecondTextBox);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.InputField);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox InputField;
        private PictureBox MainDisplay;
        private RichTextBox SecondTextBox;
    }
}