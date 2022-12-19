

namespace MyAssignment
{
    public partial class Form1 : Form
    {
        private static readonly List<string> errorMessages = new(); //collects exceptions
        readonly DrawService MyDraw = new();
        CommandParser commandParser = new();
        readonly Cursor cursor = new();
        
        
        public Form1()
        {
            
            InitializeComponent();
            MyDraw = new DrawService(Graphics.FromImage(MyDraw.DisplayBitmap));
           
        }
        private void MainDisplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImageUnscaled(MyDraw.DisplayBitmap, cursor.ShapePoint);
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "run" || InputField.Text == "")
            {
               commandParser = new(commandParser.ShapePoint,Graphics.FromImage(MyDraw.DisplayBitmap),CommandLine.Lines);
            }


            else
            {
               commandParser = new(commandParser.ShapePoint,Graphics.FromImage(MyDraw.DisplayBitmap), InputField.Lines);
            }
            
            InputField.Clear();

            foreach(string error in errorMessages)
            {
                Infotext.Text = Infotext.Text.Insert(0, "\n"+error + "\n");
                
            }
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
            Functionalities functionalities = new (CommandLine.Text);
            CommandLine.Text = functionalities.SaveProgram();
        }

        private void Load_Click(object sender, EventArgs e)
        { 
            Functionalities functionalities = new(CommandLine.Text);
            CommandLine.Text = functionalities.LoadProgram();
        }

        public static List<string> ErrorMessages
        {
            get { return errorMessages; }
        }
    }
}