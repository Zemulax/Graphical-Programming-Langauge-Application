

namespace MyAssignment
{
    public partial class Form1 : Form
    {
        private static readonly List<string> errorMessages = new(); //collects exceptions
        private static readonly List<string> syntaxChecks = new(); //collects live sytntax checks
        readonly DrawService MyDraw = new();
        CommandParser commandParser = new();
        readonly Cursor cursor = new();
        readonly Color color = Color.White;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            GlobalExceptions.SetExceptionMessageFunction(SpecialExceptions);
            MyDraw = new DrawService(Graphics.FromImage(MyDraw.DisplayBitmap));

        }

        public static void SpecialExceptions(string error)
        {
            errorMessages.Add(error);
        }
        private void MainDisplay_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.DrawImageUnscaled(MyDraw.DisplayBitmap, cursor.ShapePoint);
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (InputField.Text == "run" || InputField.Text == "")
            {
                commandParser = new(commandParser.ShapePoint, color, Graphics.FromImage(MyDraw.DisplayBitmap), CommandLine.Lines);
            }
            else
            {
                commandParser = new(commandParser.ShapePoint, color, Graphics.FromImage(MyDraw.DisplayBitmap), InputField.Lines);

            }

            InputField.Clear();

            foreach (string error in errorMessages)
            {
                Infotext.Text = Infotext.Text.Insert(0, "\n" + error + "\n");

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
            Functionalities functionalities = new(CommandLine.Text);
            CommandLine.Text = functionalities.SaveProgram();

            MyDraw.DisplayBitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
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
        public static List<string> SyntaxChecks
        {
            get { return syntaxChecks; }
        }

        private void CommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            liveTextBox1.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                LiveChangesReport changesReport = new(CommandLine.Lines);
                foreach (string error in syntaxChecks)
                {
                    liveTextBox1.Text = liveTextBox1.Text.Insert(0, "\n" + error + "\n");

                }
            }
            syntaxChecks.Clear();

        }
    }
}