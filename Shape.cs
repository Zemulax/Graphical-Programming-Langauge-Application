
namespace MyAssignment
{
    /// <summary>
    /// this is the base class shape from which all shape objects are originated
    /// </summary>
    public abstract class Shape : ShapesInterface
    {
        protected Point mypoint;
        protected Color shapecolor;
        protected bool fill;
        Brush shapeBrush;
        Pen shapePen;
        
        /// <summary>
        /// empty constructor
        /// </summary>
        public Shape(){}
       
        /// <summary>
        /// base constructor for all classes
        /// </summary>
        /// <param name="xposition">x axis</param>
        /// <param name="yposition">y axis</param>
        public Shape(Point point, Color shapecolor)
        {
            mypoint = point;
            this.shapecolor = shapecolor;
           // MessageBox.Show("" + mypoint);
            
        }


        public Point ShapePoint
        {
            set { mypoint = value; }
            get { return mypoint; }
            
        }

        public Color ShapeColor
        {
            set { shapecolor = value; }
            get { return shapecolor; }
        }

        public Brush ShapeBrush
        {
            set { shapeBrush = value; }
            get { return shapeBrush; }
        }
        public Pen ShapePen
        {
            set { shapePen = value; }
            get { return shapePen; }
        }

       /// <summary>
       /// Every object of shape must have this method
       /// </summary>
       /// <param name="graphics">the drawing surface where the shape object will be drawn</param>
        public abstract void DrawShape(Graphics graphics);

        public virtual void Set(Color color, bool fill, Brush shapeBrush, Pen shapePen, params int[] coordinates)
        {
            this.shapecolor = color;
            this.fill = fill;
            this.shapeBrush = shapeBrush;
            this.shapePen = shapePen;

            mypoint.X = coordinates[0];
            mypoint.Y = coordinates[1];
        }
    }
    
}
