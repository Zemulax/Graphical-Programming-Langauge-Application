
namespace MyAssignment
{
    /// <summary>
    /// this class parses and executes all commands
    /// </summary>
    public class CommandParser  : Shape
    {
        // readonly DrawService? drawService;

        private readonly string errorMessages = "";

        private readonly Graphics graphics;
        readonly Bitmap displayBitmap = new(800, 400);
        readonly int[] cordinates = new int[3];
        private string command = "";

        
        Point points = new()
        {
            X =0,
            Y =0

        };
        private readonly bool fill;
        
        public CommandParser() { }

        
        /// <summary>
        /// commandParser constructor 
        /// </summary>
        /// <param name="graphics">surface where the drawing will happen</param>
        /// <param name="commands">an array of commands to be parsed</param>
        public CommandParser(Point points,Graphics g,string[] commands)  : base(points)
        {
            this.points = points;
            this.graphics = g;
            DrawService drawService = new(graphics);

            // drawService = new DrawService(Graphic,xposition,yposition);
            for (int i = 0; i < commands.Length; i++)
            {
               try
                  {
                     string[] separators = { " ", "," };
                     IEnumerable<string> values = commands[i].Split(separators, StringSplitOptions.RemoveEmptyEntries); //split the first item in the array by two delimiters
                     string firstCommand = values.First().ToLower();


                    if (firstCommand.Equals("fill")){
                        fill = true;
                        continue;
                    }

                    else if(firstCommand.Equals("unfill")){
                        fill = false;
                        continue;
                    }

                    else
                    {
                        int parameter1 = int.Parse(values.Skip(1).First());
                        int parameter2 = int.Parse(values.Last());



                        cordinates[0] = parameter1;
                        cordinates[1] = parameter2;

                        Point generalUsePoints = new()
                        {
                            X = parameter1,
                            Y = parameter2

                        };

                        Cursor cursor = new(ShapePoint, parameter1, parameter2);
                        DrawTo drawto = new(ShapePoint, generalUsePoints);
                        Rectangle rectangle1 = new(ShapePoint, parameter1, parameter2);
                        Circle circle = new (ShapePoint, parameter1);

                        switch (firstCommand) //uniform all input
                        {

                            case "rectangle":
                                rectangle1.DrawShape(graphics, fill);
                                break;

                            case "circle":
                                circle.DrawShape(graphics, fill);
                                break;

                            case "moveto":
                                points.X = parameter1;
                                points.Y = parameter2;
                                ShapePoint = points;
                               // cursor.DrawShape(drawService.Graphic, fill);
                                break;

                            case "drawto":
                                drawto.DrawShape(graphics, fill);
                                break;

                            default:
                                drawService.Dr();
                                MessageBox.Show("Unrecognised command at line " + i);
                                break;
                        }
                    }
                     

                }

                catch (FormatException)
                    {
                        errorMessages =  "You might have entered an incorrect parameter at line " + i;
                        
                    }
                    catch (InvalidOperationException)
                    {
                    errorMessages = "You might have entered an incorrect parameter at line " + i;
                }   
             
            }
        }



        /// <summary>
        /// sets and gets the value of command
        /// </summary>
        public string Command
        {
            set { command = value; }
            //get { return command; }
        }

        /// <summary>
        /// sets and gets the coordiated into the array
        /// </summary>
        public int[] Cordinates
        {
            get { return cordinates; }
        }

        public override void DrawShape(Graphics graphics, bool fill)
        {
            throw new NotImplementedException();
        }

        public Bitmap DisplayBitmap
        {
            get { return displayBitmap; }
        }

        public bool Fill
        {
            get { return fill; }
            
        }
        public Point Points
        {
            set { points = value; }
            get { return points; }

        }
        public String ErrorMessage { get { return errorMessages; } }
    }
}
