

namespace MyAssignment
{
    /// <summary>
    /// this class is used to draw
    /// </summary>
    internal class DrawService 
    {
        private readonly Graphics graphics;
        public int xPos = 20;
        public int yPos = 20;
        Pen pen = new(Color.White,5);
        
        
        /// <summary>
        /// constructor for drawing graphics
        /// </summary>
        /// <param name="graphics">where the graphics should be drawn</param>
        public DrawService(Graphics graphics)
        {
            this.graphics = graphics;
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
            graphics.DrawLine(pen,xPos, yPos, toX, toY);
            

        }
        public int MoveTo(int x, int y)
        {
            graphics.DrawRectangle(pen,YPos, XPos, 5, 5);
            return x;
            

        }
        
    }
}