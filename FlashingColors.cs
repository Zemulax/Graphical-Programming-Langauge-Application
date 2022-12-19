
using System.Drawing;

namespace MyAssignment
{
    internal class FlashingColors : Shape
    {
        bool flag = false;
        readonly Thread colorThread;
        private Brush shapeBrush = new SolidBrush(Color.White);
        private Pen shapePen = new(Color.White);
        string command;
        CommandParser commandparser = new();
       

        public FlashingColors() { }
        public FlashingColors(Graphics graphics, string commands)
        {
            this.command = commands;
            colorThread = new(Flash);
            colorThread.Start();

            Rectangle rectangle1 = new(ShapePoint, 200, 200);
            Circle circle = new(ShapePoint, 200);
            if(commands == "mozay")
            {
                
                rectangle1.DrawShape(graphics, commandparser.Fill, shapePen, ShapeBrush);
            }
            

        }

        public void Flash()
        {

            while (true)
            {
                if (flag == false)
                {
                    MessageBox.Show("okytt");
                    ShapePen = new(Color.Black, 9);
                    ShapeBrush = new SolidBrush(Color.Black);
                    flag = true;
                    continue;
                }
                else
                {
                    MessageBox.Show("oky22tt");
                    ShapePen = new(Color.Green, 9);
                    ShapeBrush = new SolidBrush(Color.Green);
                    flag = false;
                }
                Thread.Sleep(100);
                continue;
            }

        }

        public override void DrawShape(Graphics graphics, bool fill, Pen shapePen, Brush shapeBrush)
        {
            throw new NotImplementedException();
        }

        public Brush ShapeBrush
        {
            get { return shapeBrush; }
            set { shapeBrush = value; }
        }

        /// <summary>
        /// pen property 
        /// gets and returns pen
        /// </summary>
        public Pen ShapePen
        {
            get { return shapePen; }
            set { shapePen = value; }
        }
    }
}

/**public partial class Form1 : Form
{

    Thread MyThread;
    bool flag = false;
    

    public void GoesToThread()
    {
        
        while (true)
        {
            if (flag == false)
            {
               
                button1.BackColor = Color.Honeydew;
                button2.BackColor = Color.MistyRose;
                button3.BackColor = Color.Firebrick;
                button4.BackColor = Color.MintCream;
                button5.BackColor = Color.Bisque;
                button6.BackColor = Color.Beige;
                flag = true;

            }
            else
            {

                button5.BackColor = Color.Indigo;

                button4.BackColor = Color.PapayaWhip;

                button1.BackColor = Color.LightGoldenrodYellow;

                button6.BackColor = Color.Aquamarine;

                button2.BackColor = Color.Chartreuse;

                button3.BackColor = Color.MediumVioletRed;


                flag = false;
            }
            Thread.Sleep(100);

        }

    }

    private void button1_Click(object sender, EventArgs e)
    {
        //flag= !flag;
    }
}
**/