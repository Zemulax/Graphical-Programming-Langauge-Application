

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

         
         readonly Pen pen = new(Color.White,5);
         readonly private int width;
         readonly private int height;

        /// <summary>
        /// empty constructor
        /// </summary>
        public Cursor() { }


        /// <summary>
        /// cursor constructor
        /// </summary>
        /// <param name="point">points to update the cursor</param>
        public Cursor(Point point) : base(point)
        {
            this.width = 0;
            this.height = 0;


        }

        /// <summary>
        /// used to draw a shape to represent the cursor
        /// </summary>
        /// <param name="graphic">surface to draw the cursor on</param>
        /// <param name="fill">determines whether the cursor should be outlined or colored</param>
        public override void DrawShape(Graphics graphic,bool fill)
        {
            graphic.DrawRectangle(pen, points.X, points.Y, 0, 0);
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
