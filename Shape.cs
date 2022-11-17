
namespace MyAssignment
{
    /// <summary>
    /// this is the base class shape from which all shape objects are originated
    /// </summary>
    public abstract class Shape : ShapesInterface
    {
        private Point mypoint;
        
        /// <summary>
        /// empty constructor
        /// </summary>
        public Shape(){}
       
        /// <summary>
        /// base constructor for all classes
        /// </summary>
        /// <param name="xposition">x axis</param>
        /// <param name="yposition">y axis</param>
        public Shape(Point point)
        {
            mypoint = point;
            //MessageBox.Show("" + mypoint);
            
        }


        public Point ShapePoint
        {
            set { mypoint = value; }
            get { return mypoint; }
            
        }

       /// <summary>
       /// Every object of shape must have this method
       /// </summary>
       /// <param name="graphics">the drawing surface where the shape object will be drawn</param>
        public abstract void DrawShape(Graphics graphics, bool fill);
    }
    
}
