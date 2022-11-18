using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    /// <summary>
    /// draw to class used to draw a line
    /// from on point to another
    /// </summary>
    public class DrawTo : Shape
    {
       private readonly Pen drawTopen = new(Color.White,5);
       private readonly Point points = new()
        {
            X = 0,
            Y = 0

        };

        /// <summary>
        /// constructor for line objects
        /// </summary>
        /// <param name="point">starting point for drawing the line</param>
        /// <param name="points">ending point for drawing the line</param>
        public DrawTo(Point point, Point points) : base(point)
        {
            this.points = points;
        }
        
        /// <summary>
        /// this method draws the line object
        /// </summary>
        /// <param name="graphics">surface to draw the line</param>
        /// <param name="fill">not needed here</param>
        public override void DrawShape(Graphics graphics, bool fill)
        {
                graphics.DrawLine(drawTopen, ShapePoint, points);
        }

    }
}
