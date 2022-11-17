
namespace MyAssignment
{
    /// <summary>
    /// this is a predefined triangle class
    /// </summary>
    public class Triangle : Shape
    {
        Pen pen = new (Color.White);

        public Triangle(int xCordinate, int ycordinate)
        {
            MessageBox.Show("Triangle is predefined!");
        }
        public override void DrawShape(Graphics graphics, bool fill)
        {
           throw new NotImplementedException();
        }
    }
}
