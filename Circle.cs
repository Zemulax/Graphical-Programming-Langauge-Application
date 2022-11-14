
using DocumentFormat.OpenXml.Drawing.ChartDrawing;

namespace MyAssignment
{
    /// <summary>
    /// this class is an instance of shape base class.
    /// it can be used to draw rectangle shapes
    /// </summary>
    public class Circle : Shape
    {

        int radius;
        readonly int radius1;
        private readonly Pen myPen = new (Color.White, 5);
        readonly Brush brush = new SolidBrush(Color.Magenta);

        /// <summary>
        /// empty constructor
        /// </summary>
        Circle()
        {

        }
        /// <summary>
        /// constructor for rectangle shapes
        /// </summary>
        /// <param name="xPos">the x axis where the rectangle will be drawn</param>
        /// <param name="yPos">the y axis where the rectangle will be drawn</param>
       
        public Circle(int xPos, int yPos, int radius, int radius1) : base(xPos, yPos)
        {
            this.radius = radius;
            this.radius1 = radius1;
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
        public override void DrawShape(Graphics graphics,bool fill)
        {
            if (fill == true)
            {
                graphics.DrawEllipse(myPen, new Rectangle(XPosition, YPosition, radius, radius1));
                graphics.FillEllipse(brush, new Rectangle(XPosition, YPosition, radius, radius1));
            }
            else
            {
                graphics.DrawEllipse(myPen, new Rectangle(XPosition, YPosition, radius, radius1));
            }
        }


        
        //rectangle method that calls draw, takes in command and parameters





    }
}
