

namespace MyAssignment
{
    /// <summary>
    /// cursor class used to move the pen around the drawing surface
    /// pen is invisible
    /// </summary>
    public class Cursor : Shape
    {
        /// <summary>
        /// used to update pen position
        /// </summary>
        Point points = new()
        {
            X = 0,
            Y = 0

        };


        /// <summary>
        /// empty constructor
        /// </summary>
        public Cursor() : base() { }


        /// <summary>
        /// cursor constructor
        /// </summary>
        /// <param name="point">points to update the cursor</param>
        public Cursor(Point point, Color color) : base(point, color)
        {
            ShapePoint = points;
        }

        /// <summary>
        /// used to draw a shape to represent the cursor
        /// </summary>
        /// <param name="graphic">surface to draw the cursor on</param>
        /// <param name="fill">determines whether the cursor should be outlined or colored</param>
        public override void DrawShape(Graphics graphic)
        {
            graphic.DrawRectangle(ShapePen, ShapePoint.X, ShapePoint.Y, 0, 0);

        }

        /// <summary>
        /// points property
        /// updates point property
        /// retrieves current value of property
        /// </summary>
        public Point Points
        {
            set { points = value; }
            get { return points; }

        }

    }
}
