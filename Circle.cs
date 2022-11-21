

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
        Circle()
        {
        }
        
       /// <summary>
       /// class constructor
       /// </summary>
       /// <param name="point">x and y axis where the object will be drawn</param>
       /// <param name="radius">radius of the circle to be drawn</param>
        public Circle(Point point, int radius): base(point)
        {

            this.radius = radius;
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
        public override void DrawShape(Graphics graphics,bool fill, Pen shapePen, Brush shapeBrush)
        {
           // shapePen = new(Color.White);
                if (fill == true)
                {
                    graphics.FillEllipse(shapeBrush, ShapePoint.X, ShapePoint.Y, radius, radius);
                }
                else
                {
                    graphics.DrawEllipse(shapePen, ShapePoint.X, ShapePoint.Y, radius, radius);
                }
        }
    }
}
