namespace MyAssignment
{
    /// <summary>
    /// draw to class used to draw a line
    /// from on point to another
    /// </summary>
    public class DrawTo : Shape
    {
        private Point points = new()
        {
            X = 0,
            Y = 0

        };


        public DrawTo() : base() { }
        /// <summary>
        /// constructor for line objects
        /// </summary>
        /// <param name="point">starting point for drawing the line</param>
        /// <param name="points">ending point for drawing the line</param>
        public DrawTo(Point point, Color color, Point points) : base(point, color)
        {
            this.points = points;
        }


        public override void Set(Color color, bool fill, Brush shapeBrush, Pen shapePen, params int[] coordinates)
        {
            base.Set(color, fill, shapeBrush, shapePen, coordinates[0], coordinates[1]);
            points.X = coordinates[2];
            points.Y = coordinates[3];

        }
        /// <summary>
        /// this method draws the line object
        /// </summary>
        /// <param name="graphics">surface to draw the line</param>
        /// <param name="fill">not needed here</param>
        public override void DrawShape(Graphics graphics)
        {
            graphics.DrawLine(ShapePen, ShapePoint, points);
        }

    }
}
