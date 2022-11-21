

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


        /// <summary>
        /// draw method for rectangle class
        /// this method draws the rectangle with specified parameters
        /// </summary>
        /// <param name="graphics">specifies where the drawing will be done</param>
        /// <param name="fill">specifies whether the object should be colored or outlined</param>
        public  override void DrawShape(Graphics graphics, bool fill, Pen shapePen, Brush shapeBrush)
        {  if (fill == true)
                {
                    graphics.FillRectangle(shapeBrush, ShapePoint.X, ShapePoint.Y, Width, Length);
                }
                else
                {
                    graphics.DrawRectangle(shapePen, ShapePoint.X, ShapePoint.Y, Width, Length);
                }
        }
    }
}
