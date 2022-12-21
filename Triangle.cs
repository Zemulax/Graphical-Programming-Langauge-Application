
namespace MyAssignment
{
    /// <summary>
    /// this is a triangle class used to draw predefined triangular objects
    /// </summary>
    public class Triangle : Shape
    {

        public Triangle():base() { }
        /// <summary>
        /// triangle constructor
        /// </summary>
        /// <param name="points"></param>
        public Triangle(Point points,Color color) : base(points,color)
        {
        }

        /// <summary>
        /// draw method for triangle class
        /// </summary>
        /// <param name="graphics">surface to be drawn on</param>
        /// <param name="fill">whether the shape shoulf be colored or outlined</param>
        public override void DrawShape(Graphics graphics)
        {
            graphics.DrawLine(ShapePen, 180, 200, 50, 320);
            graphics.DrawLine(ShapePen, 50, 320, 320, 320);
            graphics.DrawLine(ShapePen, 320, 320, 180, 200);
            
        }
    }
}
