

namespace MyAssignment
{
    public class Cursor : Shape
    {
         CommandParser c = new ();
         Pen pen = new(Color.White,5);
         readonly private int width, height;
        public Cursor(Point point,int width,int height) : base(point)
        {
            this.width = width;
            this.height = height;
           

        }

        public Cursor() { }
        public override void DrawShape(Graphics graphic,bool fill)
        {
            
            graphic.DrawRectangle(pen, ShapePoint.X,ShapePoint.Y,width,height); 
            
        }

        public void UpdateCursor()
        {
            ShapePoint = c.Points;
        }

    }
}
