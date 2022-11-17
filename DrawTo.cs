using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    public class DrawTo : Shape
    {
       private readonly Pen drawTopen = new(Color.White,5);
       private readonly Point points = new()
        {
            X = 0,
            Y = 0

        };

        public DrawTo(Point point, Point points) : base(point)
        {
            this.points = points;
        }
        
        public override void DrawShape(Graphics graphics, bool fill)
        {
            graphics.DrawLine(drawTopen,ShapePoint, points);
        }

        public Point Points
        {
            get { return points; }

        }



















    }
}
