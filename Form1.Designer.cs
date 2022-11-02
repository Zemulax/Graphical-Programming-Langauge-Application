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
            this.CommandLine = new System.Windows.Forms.RichTextBox();
            this.Enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(63, 467);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(245, 27);
            this.InputField.TabIndex = 2;
            this.InputField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputField_KeyDown);
            // 
            // MainDisplay
            // 
            this.MainDisplay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainDisplay.Location = new System.Drawing.Point(339, 12);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.Size = new System.Drawing.Size(634, 401);
            this.MainDisplay.TabIndex = 3;
            this.MainDisplay.TabStop = false;
            this.MainDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.MainDisplay_Paint);
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(63, 12);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(245, 401);
            this.CommandLine.TabIndex = 4;
            this.CommandLine.Text = "";
            this.CommandLine.TextChanged += new System.EventHandler(this.CommandLine_TextChanged);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enter.Location = new System.Drawing.Point(339, 465);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(94, 29);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 587);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.CommandLine);
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
        private RichTextBox CommandLine;
        private Button Enter;
    }
}