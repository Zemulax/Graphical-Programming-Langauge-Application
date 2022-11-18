

namespace MyAssignment
{
    /// <summary>
    /// this class is an instance of shape base class.
    /// it can be used to draw rectangle shapes
    /// </summary>
    public class Rectangle : Shape
    {
        private int length;
        private int width;
        private Pen myPen = new Pen(Color.White,5);
        readonly Brush brush = new SolidBrush(Color.White);

        /// <summary>
        /// empty constructor
        /// </summary>
        Rectangle()
        {

        }
        /// <summary>
        /// constructor for rectangle shapes
        /// </summary>
        /// <param name="xPos">the x axis where the rectangle will be drawn</param>
        /// <param name="yPos">the y axis where the rectangle will be drawn</param>
        /// <param name="width">width of the rectangle to be drawn</param>
        /// <param name="length">length of the rectangle to be drawn</param>
        public Rectangle(Point point, int width, int length): base(point)
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
        /// sets the pen object
        /// returns the pen object
        /// </summary>
        public Pen MyPen
        {
            get { return myPen; }
            set { myPen = value; }
        }

        /// <summary>
        /// draw method for rectangle class
        /// this method draws the rectangle with specified parameters
        /// </summary>
        /// <param name="graphics">specifies where the drawing will be done</param>
        /// <param name="fill">specifies whether the object should be colored or outlined</param>
        public  override void DrawShape(Graphics graphics, bool fill)
        {  if (fill == true)
                {
                    graphics.FillRectangle(brush, ShapePoint.X, ShapePoint.Y, Width, Length);
                }
                else
                {
                    graphics.DrawRectangle(myPen, ShapePoint.X, ShapePoint.Y, Width, Length);
                }
        }
    }
}
