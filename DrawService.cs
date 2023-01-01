

namespace MyAssignment
{
    /// <summary>
    /// this class is used to draw
    /// </summary>
    public class DrawService : IDisposable
    {
        private readonly Graphics graphics = null;
        readonly Bitmap displayBitmap = new(600, 500);

        public DrawService() { }
        /// <summary>
        /// constructor for drawing graphics
        /// </summary>
        /// <param name="graphics">where the graphics should be drawn</param>
        public DrawService(Graphics graphics)
        {
            this.graphics = graphics;

        }

        /// <summary>
        /// this method disposes drawing materials utilised
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// bitmap property
        /// returns bitmap object
        /// </summary>
        public Bitmap DisplayBitmap
        {
            get { return displayBitmap; }
        }

        /// <summary>
        /// graphic property
        /// returns graphic object
        /// </summary>
        public Graphics Graphic
        {
            get { return graphics; }

        }


    }
}