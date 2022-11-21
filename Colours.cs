using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    /// <summary>
    /// this class is for setting up different
    /// colors for different shape drawings
    /// </summary>
    public class Colours
    {
      
        private Brush shapeBrush= new SolidBrush(Color.White);
        private Pen shapePen = new(Color.White);
        
        /// <summary>
        /// constructor for setting up the new color
        /// </summary>
        /// <param name="colour">takes color parameter</param>
        public Colours(Color colour) 
        {
            ShapePen = new Pen(colour,5);
        }

        public Colours() {}

        public Brush ShapeBrush
        {
            get { return shapeBrush; }
            set { shapeBrush = value; }
        }
        public Pen ShapePen
        {
            get { return shapePen; }
            set { shapePen = value; }
        }
    }
}
