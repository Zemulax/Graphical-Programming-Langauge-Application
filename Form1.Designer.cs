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
            this.Enter = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Infotext = new System.Windows.Forms.RichTextBox();
            this.CommandLine = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.AcceptsReturn = true;
            this.InputField.AllowDrop = true;
            this.InputField.BackColor = System.Drawing.SystemColors.Control;
            this.InputField.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InputField.Location = new System.Drawing.Point(540, 594);
            this.InputField.Name = "InputField";
            this.InputField.PlaceholderText = "Single Command Line...";
            this.InputField.Size = new System.Drawing.Size(415, 24);
            this.InputField.TabIndex = 2;
            // 
            // MainDisplay
            // 
            this.MainDisplay.BackColor = System.Drawing.Color.MidnightBlue;
            this.MainDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainDisplay.Location = new System.Drawing.Point(12, 68);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.Size = new System.Drawing.Size(520, 520);
            this.MainDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainDisplay.TabIndex = 3;
            this.MainDisplay.TabStop = false;
            this.MainDisplay.WaitOnLoad = true;
            this.MainDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.MainDisplay_Paint);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Enter.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enter.Location = new System.Drawing.Point(422, 594);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(110, 50);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Red;
            this.Clear.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear.ForeColor = System.Drawing.SystemColors.Window;
            this.Clear.Location = new System.Drawing.Point(12, 594);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(121, 50);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Save.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save.Location = new System.Drawing.Point(302, 594);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(114, 50);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Load.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Load.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Load.Location = new System.Drawing.Point(139, 594);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(110, 50);
            this.Load.TabIndex = 7;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 53);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(317, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHAPE CREATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(538, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "System Logs";
            // 
            // Infotext
            // 
            this.Infotext.BulletIndent = 1;
            this.Infotext.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Infotext.ForeColor = System.Drawing.Color.OrangeRed;
            this.Infotext.Location = new System.Drawing.Point(538, 423);
            this.Infotext.Name = "Infotext";
            this.Infotext.ReadOnly = true;
            this.Infotext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Infotext.Size = new System.Drawing.Size(415, 165);
            this.Infotext.TabIndex = 12;
            this.Infotext.Text = "";
            // 
            // CommandLine
            // 
            this.CommandLine.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandLine.Location = new System.Drawing.Point(538, 99);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CommandLine.Size = new System.Drawing.Size(415, 283);
            this.CommandLine.TabIndex = 14;
            this.CommandLine.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(536, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Multi Command LIne";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 648);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CommandLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Infotext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.InputField);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox InputField;
        private PictureBox MainDisplay;
        private Button Enter;
        private Button Clear;
        private Button Save;
        private Button Load;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private RichTextBox Infotext;
        private RichTextBox CommandLine;
        private Label label3;
    }
}