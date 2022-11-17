

namespace MyAssignment
{
    /// <summary>
    /// this class is used to draw
    /// </summary>
    public class DrawService : IDisposable
    {
        private readonly Graphics graphics;
        readonly Bitmap displayBitmap = new(800, 400);
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

        public void Dispose()
        {
            Graphic.Dispose();
        }
        public void Dr()
        {
            graphics.DrawRectangle(pen, 20, 20, 20, 20);
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
       

    }
}