
namespace MyAssignment
{
    /// <summary>
    /// this is the base class shape from which all shape objects are originated
    /// </summary>
    public abstract class Shape : ShapesInterface
    {
        private int xPosition = 200;
        private int yPosition = 200;
        
        /// <summary>
        /// empty constructor
        /// </summary>
        public Shape(){}
       
        /// <summary>
        /// base constructor for all classes
        /// </summary>
        /// <param name="xposition">x axis</param>
        /// <param name="yposition">y axis</param>
        public Shape(int xposition, int yposition)
        {
            this.xPosition = xposition;
            this.yPosition = yposition; 
        }

        /// <summary>
        /// sets and gets the x axis for an object
        /// </summary>
       public int XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }

        /// <summary>
        /// sets and gets the y axis for an object
        /// </summary>
        public int YPosition { 
   
            set { yPosition = value; }
            get { return yPosition; }

        }

       /// <summary>
       /// Every object of shape must have this method
       /// </summary>
       /// <param name="graphics">the drawing surface where the shape object will be drawn</param>
        public abstract void DrawShape(Graphics graphics, bool fill);
    }
}
