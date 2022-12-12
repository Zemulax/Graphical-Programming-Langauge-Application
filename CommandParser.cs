

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
        readonly Variables va = new();

        /// <summary>
        /// empty commandparser constructor
        /// </summary>
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
                if (commands[i].Contains("int"))
                {
                    va.Checkvarible(commands[i]);
                    continue;
                }

                try
                {
                    //this section checks for utilty commands
                    switch (commands[i].ToLower())
                    {
                       
                        case "pen red":
                            colour = Color.Red;
                            colours.ShapePen = new(Color.Red, 5);
                            colours.ShapeBrush = new SolidBrush(Color.Red);
                            continue;

                        case "pen green":
                            colour = Color.Red;
                            colours.ShapePen = new(Color.Green, 5);
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

                    int parameter1 = 0;
                    int parameter2 = 0;

                    if (va.VariablesList.Contains(values.Skip(1).First()))
                    {
                        parameter1 = va.ParamValues[0];
                        if(parameter2 == 0)
                        {
                            parameter2 = parameter1;
                        }
                        else
                        {
                            parameter2 = va.ParamValues[1];
                        }

                        cordinates[0] = parameter1;
                        cordinates[1] = parameter2;
                    }

                    else
                    {
                        parameter1 = int.Parse(values.Skip(1).First()); //skip the first value which is the "firstCommand",get the second value
                        parameter2 = int.Parse(values.Last());
                    }

                        if (parameter1 >= 515 || parameter1 < 0 || parameter2 > 515 || parameter2 < 0)
                        {
                            throw new ArgumentOutOfRangeException(" \nValue out of bounds. limit 515 ");
                        }

                        //check if user has used the parameters or variables
                        if (parameter1 == 0 && parameter2 == 0)
                        {
                            cordinates[0] = 20;
                        }
                        else
                        {
                            cordinates[0] = parameter1;
                            cordinates[1] = parameter2;
                        }


                        Point generalUsePoints = new()
                        {
                            X = parameter1,
                            Y = parameter2

                        };


                        //shape objects instantiation
                        Cursor cursor = new(ShapePoint);
                        DrawTo drawto = new(ShapePoint, generalUsePoints);
                        Rectangle rectangle1 = new(ShapePoint, cordinates[0], cordinates[1]);
                        Triangle triangle = new(ShapePoint);
                        Circle circle = new(ShapePoint, cordinates[0]);

                        //this section checks for processed commands with integer parameters 
                        switch (firstCommand.ToLower()) //uniform all input
                        {
                            case "rectangle":
                                rectangle1.DrawShape(graphics, fill, colours.ShapePen, colours.ShapeBrush);
                                break;

                            case "circle":
                                circle.DrawShape(graphics, fill, colours.ShapePen, colours.ShapeBrush);
                                break;

                            case "triangle":
                                triangle.DrawShape(graphics, fill, colours.ShapePen, colours.ShapeBrush);
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
                    errorMessages.Add("The input parameter is too large!");
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

        /// <summary>
        /// color property used by the color class
        /// sets and gets the colour
        /// </summary>
        public Color Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
