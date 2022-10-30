namespace MyAssignment
{
    public partial class Form1 : Form
    {
        
        readonly DrawService MyCanvas;
        readonly Bitmap DisplayBitmap;
        
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            DisplayBitmap = new Bitmap(600, 400);
            MyCanvas = new DrawService(Graphics.FromImage(DisplayBitmap));


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            var command = InputField.Text.Trim().ToLower(); //uniform all command input
            var pen = new Pen(Color.White, 7);
            var graphics = Graphics.FromImage(DisplayBitmap);

            switch (command)
            {
                case "pie":
                    graphics.DrawPie(pen, 150, 150, 150, 150,150,150);
                    break;

                case "rectangle":
                    graphics.DrawRectangle(pen, 150, 150, 150, 150);
                    break;

                case "circle":
                    graphics.DrawEllipse(pen, 150, 150, 150, 150);
                    break;
            }
            InputField.Focus();
            InputField.Clear();
            Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainDisplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImageUnscaled(DisplayBitmap, 2, 2);

        }


    }



}