

using DocumentFormat.OpenXml.Drawing.ChartDrawing;

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
        CommandParser commandParser;

        /// <summary>
        ///  constructor for form class
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            DisplayBitmap = new Bitmap(488, 401);
            MyDraw = new DrawService(Graphics.FromImage(DisplayBitmap));
            MyDraw.MoveTo(MyDraw.XPos,MyDraw.yPos);
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
            if (InputField.Text == "run" || InputField.Text == "")
            {
                CommandParser commandParser = new(Graphics.FromImage(DisplayBitmap), CommandLine.Lines, Fill.Text);
                
            }

            else
            {
               CommandParser commandParser = new(Graphics.FromImage(DisplayBitmap), InputField.Lines, Fill.Text.ToLower());

               
               
            }

            InputField.Clear();
            Refresh();
        }

        private void CommandLine_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
            Graphics graphics = Graphics.FromImage(DisplayBitmap);
            graphics.Clear(Color.MidnightBlue);
           
            Refresh();
        }

        private void InputField_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// saves a users program from the command line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Save My Program"
            };

            saveFileDialog.ShowDialog();
            if(saveFileDialog.FileName != "")
            {
               string myProgramName = saveFileDialog.FileName;
               TextWriter writer = new StreamWriter(myProgramName);
               writer.WriteLine(CommandLine.Text);
               MessageBox.Show("Program has been saved!");
               writer.Close();
            }

        }

        /// <summary>
        /// Loads a program from the users computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.ShowDialog(this);
            if(openFileDialog.FileName != "")
            {
                StreamReader reader = new (openFileDialog.FileName);
                CommandLine.Text = reader.ReadToEnd();
            }
        }

        private void Fill_Click(object sender, EventArgs e)
        {

            Fill.Text = "Fill On";
            Fill.BackColor = Color.RebeccaPurple;
        }
    }
}