

using DocumentFormat.OpenXml.Drawing;

namespace MyAssignment
{
    /// <summary>
    /// this class is used to draw
    /// </summary>
    public class DrawService
    {
        private readonly Graphics graphics;
        readonly Bitmap displayBitmap = new(800, 400);
        private int xPos = 50;
        private int yPos = 50;
        readonly Pen pen = new(Color.White, 5);


        /// <summary>
        /// constructor for drawing graphics
        /// </summary>
        /// <param name="graphics">where the graphics should be drawn</param>
        public DrawService(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public void Clear()
        {
            MessageBox.Show("clearing");
            graphics.Clear(Color.Red);    
        }
        public DrawService() { }
        public Bitmap DisplayBitmap
        {
            get { return displayBitmap; }
        }
        public Graphics Graphic
        {
            get { return graphics; }
            
        }
        
        public int XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public int YPos 
        {
            set { yPos = value; }
            get { return yPos; }
        }

       
        public void DrawTo(int toX, int toY)
        {
            graphics.DrawLine(pen, xPos, yPos, toX, toY);
            xPos = toX;
            yPos = toY;
        }
        
        public void MoveTo(int toX, int toY)
        {
            graphics.DrawRectangle(pen, xPos, yPos, toX, toY);
        }
    }
}