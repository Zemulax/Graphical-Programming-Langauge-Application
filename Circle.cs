

namespace MyAssignment
{
    /// <summary>
    /// circle class used to draw circular objects
    /// </summary>
    public class Circle : Shape
    {
        int radius;


        /// <summary>
        /// empty constructor
        /// </summary>
        public Circle() : base() { }
        
       /// <summary>
       /// class constructor
       /// </summary>
       /// <param name="point">x and y axis where the object will be drawn</param>
       /// <param name="radius">radius of the circle to be drawn</param>
        public Circle(Point point, Color color, int radius): base(point, color)
        {
            this.radius = radius;
        }

        public override void Set(Color color, bool fill, Brush shapeBrush, Pen shapePen, params int[] coordinates)
        {
            base.Set(color, fill, shapeBrush, shapePen, coordinates[0], coordinates[1]);
            this.radius = coordinates[2];
        }

        public override void DrawShape(Graphics graphics)
        {
            // shapePen = new(Color.White);
            if (fill == true)
            {
                graphics.FillEllipse(ShapeBrush, ShapePoint.X, ShapePoint.Y, radius, radius);
            }
            else
            {
                graphics.DrawEllipse(ShapePen, ShapePoint.X, ShapePoint.Y, radius, radius);
            }
        }

        /// <summary>
        /// property of rectangle class
        /// sets the length value
        /// gets the length value
        /// </summary>
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        
        /// <summary>
        /// draw method for circle class
        /// this method draws the rectangle with specified parameters
        /// </summary>
        /// <param name="graphics">specifies where the drawing will be done</param>
        /// <param name="fill">determines whether the circle should be colored or outlined</param>
       
    }
}
