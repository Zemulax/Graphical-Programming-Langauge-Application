
namespace MyAssignment
{
    internal class DrawService
    {
       private readonly Graphics graphics;

        
        public DrawService(Graphics graphics)
        {
            this.graphics = graphics;
            
        }

        public void Drawers()
        {
            
            Pen mypen = new(Color.White, 7);
            graphics.DrawLine(mypen, 10, 10, 100, 100);
        }

       

    }
}