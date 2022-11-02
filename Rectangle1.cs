
namespace MyAssignment
{
    /// <summary>
    /// this class is an instance of shape base class.
    /// it can be used to draw rectangle shapes
    /// </summary>
    internal class Rectangle1 : Shape 
    {
        
        private int length;
        private int width;
        readonly Pen myPen = new(Color.Green);
        Brush brush = new SolidBrush(Color.Magenta);

        /// <summary>
        /// empty constructor
        /// </summary>
        Rectangle1()
        {

        }
        /// <summary>
        /// constructor for rectangle shapes
        /// </summary>
        /// <param name="xPos">the x axis where the rectangle will be drawn</param>
        /// <param name="yPos">the y axis where the rectangle will be drawn</param>
        /// <param name="width">width of the rectangle to be drawn</param>
        /// <param name="length">length of the rectangle to be drawn</param>
        public Rectangle1(int xPos, int yPos, int width, int length) : base(xPos, yPos)
        {
            this.width = width;
            this.length = length;   
        }


        /// <summary>
        /// property of rectangle class
        /// sets the length value
        /// gets the length value
        /// </summary>
        public int Length
        {
            set { length = value; }
            get { return length; }
        }

        /// <summary>
        /// property of rectangle class
        /// sets the length value
        /// gets the length value
        /// </summary>
        public int Width
        {
            set { width = value; }
            get { return width; }
        }

        /// <summary>
        /// draw method for rectangle class
        /// this method draws the rectangle with specified parameters
        /// </summary>
        /// <param name="graphics">specifies where the drawing will be done</param>
        public override void DrawShape(Graphics graphics)
        {

            graphics.DrawRectangle(myPen, XPosition, YPosition, Width,Length);
            graphics.FillRectangle(brush, XPosition, YPosition, Width, Length);
        }

        //rectangle method that calls draw, takes in command and parameters

       



    }
}
