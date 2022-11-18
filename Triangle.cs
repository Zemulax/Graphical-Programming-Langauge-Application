
namespace MyAssignment
{
    /// <summary>
    /// this is a triangle class used to draw predefined triangular objects
    /// </summary>
    public class Triangle : Shape
    {
        readonly Pen pen = new (Color.White,5);

        /// <summary>
        /// triangle constructor
        /// </summary>
        /// <param name="points"></param>
        public Triangle(Point points) : base(points)
        {
        }

        /// <summary>
        /// draw method for triangle class
        /// </summary>
        /// <param name="graphics">surface to be drawn on</param>
        /// <param name="fill">whether the shape shoulf be colored or outlined</param>
        public override void DrawShape(Graphics graphics, bool fill)
        {
            graphics.DrawLine(pen, 180, 200, 50, 320);
            graphics.DrawLine(pen, 50, 320, 320, 320);
            graphics.DrawLine(pen, 320, 320, 180, 200);
        }
    }
}
