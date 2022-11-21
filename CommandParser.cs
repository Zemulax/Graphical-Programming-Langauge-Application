

namespace MyAssignment
{
    /// <summary>
    /// this class parses and executes all commands
    /// </summary>
    public class CommandParser  : Shape
    {
        
        public List<string> errorMessages = new(); //collects exceptions
        private readonly Graphics graphics = null;
        readonly int[] cordinates = new int[3];
        private readonly bool fill;
        private Color colour = Color.White;


        public CommandParser()
        {
           
        }

        /// <summary>
        /// Parsecommander class constructor interprets and executes commands using various method calls
        /// </summary>
        /// <param name="points">the x and y axis to set the pen to</param>
        /// <param name="graphics">surface for drawing</param>
        /// <param name="commands">commands that determine execution</param>
        public CommandParser(Point points,Graphics graphics,string[] commands)  : base(points)
        {
            this.graphics = graphics;
            Colours colours = new(colour);
            for (int i = 0; i < commands.Length; i++)
            {
               try
               {
                    switch (commands[i].ToLower())
                    {
                        case "pen red":
                            colour = Color.Red;
                            colours.ShapePen = new(Color.Red,5);
                            colours.ShapeBrush = new SolidBrush(Color.Red);
                            continue;

                        case "pen green":
                            colour = Color.Red;
                            colours.ShapePen = new(Color.Green,5);
                            colours.ShapeBrush = new SolidBrush(Color.Green);
                            continue;

                        case "pen magenta":
                            colour = Color.Red;
                            colours.ShapePen = new(Color.Magenta, 5);
                            colours.ShapeBrush = new SolidBrush(Color.Magenta);
                            continue;

                        case "pen yellow":
                            colour = Color.Red;
                            colours.ShapePen = new(Color.Yellow, 5);
                            colours.ShapeBrush = new SolidBrush(Color.Yellow);
                            continue;

                        case "default":
                            colour = Color.White;
                            colours.ShapePen = new(Color.White, 5);
                            colours.ShapeBrush = new SolidBrush(Color.White);
                            continue;

                        case "fill on":
                            fill = true;
                            continue;

                        case "fill off":
                            fill = false;
                            continue;

                        case "clear":
                            graphics.Clear(Color.MidnightBlue);
                            continue;
            
                        case "reset":
                            points.X = 0;
                            points.Y = 0;
                            ShapePoint = points;
                            continue;
                    }
                  
                        string[] separators = { " ", "," };
                        IEnumerable<string> values = commands[i].Split(separators, StringSplitOptions.RemoveEmptyEntries); //split the first item in the array by two delimiters
                        string firstCommand = values.First().ToLower();

                        int parameter1 = int.Parse(values.Skip(1).First()); //skip the first value which is the "firstCommand",get the second value
                        int parameter2 = int.Parse(values.Last());

                        if(parameter1>=515 ||parameter1<0 || parameter2 >515 || parameter2<0)
                        {
                            throw new ArgumentOutOfRangeException(" \nValue out of bounds. limit 515 ");
                        }

                        cordinates[0] = parameter1;
                        cordinates[1] = parameter2;

                        Point generalUsePoints = new()
                        {
                            X = parameter1,
                            Y = parameter2

                        };

                        //shape objects instantiation
                        Cursor cursor = new(ShapePoint);
                        DrawTo drawto = new(ShapePoint, generalUsePoints);
                        Rectangle rectangle1 = new(ShapePoint, parameter1, parameter2);
                        Triangle triangle = new(ShapePoint);
                        Circle circle = new (ShapePoint, parameter1);

                        switch (firstCommand.ToLower()) //uniform all input
                        {
                            case "rectangle":
                                rectangle1.DrawShape(graphics, fill, colours.ShapePen,colours.ShapeBrush);
                                break;

                            case "circle":
                                circle.DrawShape(graphics, fill,colours.ShapePen,colours.ShapeBrush);
                                break;

                            case "triangle":
                                triangle.DrawShape(graphics, fill,colours.ShapePen, colours.ShapeBrush);
                                break;

                            case "moveto":
                                
                                cursor.Points = generalUsePoints;
                                ShapePoint = cursor.Points;
                                break;

                            case "drawto":
                                drawto.DrawShape(graphics, fill, colours.ShapePen, colours.ShapeBrush);
                                break;

                            default:
                                errorMessages.Add("Unrecognised command at: " + commands[i]);
                                break;
                        }
                    
               }

                catch(FormatException)
                {
                        errorMessages.Add("Incorrect parameter at command: " + commands[i]);
                }

                catch(InvalidOperationException)
                {
                      errorMessages.Add("Missing Parameter at command: " + commands[i]);
                }

                catch (ArgumentOutOfRangeException)
                {
                    errorMessages.Add("value too large");
                }
            }
        }
        
        /// <summary>
        /// sets and gets the coordiated into the array
        /// </summary>
        public int[] Cordinates
        {
            get { return cordinates; }
        }

        /// <summary>
        /// unimplemented method
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="fill"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void DrawShape(Graphics graphics, bool fill,Pen shapePen,Brush shapeBrush)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// sets the value of fill to true or false
        /// </summary>
        public bool Fill
        {
            get { return fill; }
            
        }
        public Color Colour
        {
            get { return colour; }
            set { this.colour = value; }
        }
    }
}
