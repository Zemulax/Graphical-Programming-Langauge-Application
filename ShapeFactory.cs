using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    /// <summary>
    /// shape factory class is used to manufacture shapes
    /// </summary>
    public class ShapeFactory
    {
        public Shape GetShape(string shape)
        {
            if (shape.Equals("rectangle"))
            {
                return new Rectangle();
            }
            else if (shape.Equals("circle"))
            {
                return new Circle();
            }
            else if (shape.Equals("triangle"))
            {
                return new Triangle();
            }
            else if (shape.Equals("moveto"))
            {
                return new Cursor();
            }
            else if (shape.Equals("drawto"))
            {
                return new DrawTo();
            }
            else
            {
                ArgumentException unknownshape = new("That shape was not known");
                throw unknownshape;
            }


        }
    }
}
