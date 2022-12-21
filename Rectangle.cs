

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
        public Rectangle():base()
        {

        }
        /// <summary>
        /// constructor for rectangle shapes
        /// </summary>
        /// <param name="xPos">the x axis where the rectangle will be drawn</param>
        /// <param name="yPos">the y axis where the rectangle will be drawn</param>
        /// <param name="width">width of the rectangle to be drawn</param>
        /// <param name="length">length of the rectangle to be drawn</param>
        public Rectangle(Point point, Color color, int width, int length): base(point,color)
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

        public override void Set(Color color, bool fill, Brush shapeBrush, Pen shapePen, params int[] coordinates)
        {
            base.Set(color, fill, shapeBrush, shapePen, coordinates[0], coordinates[1]);
            width = coordinates[2];
            length = coordinates[3];

        }

        /// <summary>
        /// draw method for rectangle class
        /// this method draws the rectangle with specified parameters
        /// </summary>
        /// <param name="graphics">specifies where the drawing will be done</param>
        /// <param name="fill">specifies whether the object should be colored or outlined</param>
        public  override void DrawShape(Graphics graphics)
        {  
            if (fill == true)
                {
                    graphics.FillRectangle(ShapeBrush, ShapePoint.X, ShapePoint.Y, Width, Length);
                }
                else
                {
                    graphics.DrawRectangle(ShapePen, ShapePoint.X, ShapePoint.Y, Width, Length);
                }
        }
    }
}
