namespace MyAssignment
{
    /// <summary>
    /// this form class initiates all the program activity
    /// it provides a form where drawing should occur
    /// </summary>
    public partial class Form1 : Form
    {
        
        readonly DrawService MyDraw;
        readonly Bitmap DisplayBitmap;

        /// <summary>
        ///  constructor for form class
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            DisplayBitmap = new Bitmap(600, 400);
            MyDraw = new DrawService(Graphics.FromImage(DisplayBitmap));
            
           
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
            graphics.DrawImageUnscaled(DisplayBitmap,0,0);
        }

        /// <summary>
        /// initiates transaction of inputs to the command parser class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "run")
            {
                CommandParser commandParser = new(Graphics.FromImage(DisplayBitmap),CommandLine.Lines);
            }
            else
            {
               CommandParser commandParser = new(Graphics.FromImage(DisplayBitmap),InputField.Lines);
            }

            InputField.Clear();
            Refresh();
        }

        private void CommandLine_TextChanged(object sender, EventArgs e)
        {
            
        }
    }



}