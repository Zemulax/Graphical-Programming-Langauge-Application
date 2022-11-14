

namespace MyAssignment
{
    /// <summary>
    /// this form class initiates all the program activity
    /// it provides a form where drawing should occur
    /// </summary>
    public partial class Form1 : Form
    {
        
        readonly DrawService MyDraw = new();

        /// <summary>
        ///  constructor for form class
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            MyDraw = new DrawService(Graphics.FromImage(MyDraw.DisplayBitmap));

        }

        /// <summary>
        ///  input field for commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputField_KeyDown(object sender, KeyEventArgs e)
        {    
            InputField.Focus();  
        }

        /// <summary>
        ///  waits for a signal to execute drawing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainDisplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImageUnscaled(MyDraw.DisplayBitmap, MyDraw.XPos, MyDraw.YPos);
        }

        /// <summary>
        /// initiates transaction of inputs to the command parser class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "run" || InputField.Text == "")
            {
                CommandParser commandParser = new(Graphics.FromImage(MyDraw.DisplayBitmap), CommandLine.Lines, Fill.Text.ToLower());
                
            }

            else
            {
               CommandParser commandParser = new(Graphics.FromImage(MyDraw.DisplayBitmap), InputField.Lines, Fill.Text.ToLower());
            }

            InputField.Clear();
            Refresh();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
            Graphics graphics = Graphics.FromImage(MyDraw.DisplayBitmap);
            graphics.Clear(Color.MidnightBlue);
           
            Refresh();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //save program
            Functionalities functionalities = new (CommandLine.Text);
            CommandLine.Text = functionalities.SaveProgram();
        }

        private void Load_Click(object sender, EventArgs e)
        { 
            Functionalities functionalities = new(CommandLine.Text);
            CommandLine.Text = functionalities.LoadProgram();
        }

        private void FillOn_CheckedChanged(object sender, EventArgs e)
        {
            Fill.Text = "Fill On";
            Fill.BackColor = Color.RebeccaPurple;
        }

        private void FillOff_CheckedChanged(object sender, EventArgs e)
        {
            Fill.Text = "Fill Off";
            Fill.BackColor = Color.Magenta;
        }
    }
}