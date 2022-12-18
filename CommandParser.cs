namespace MyAssignment
{
    /// <summary>
    /// this class parses and executes all commands
    /// </summary>
    public class CommandParser  : Shape
    {
       
        private readonly Graphics graphics = null;
        readonly int[] cordinates = new int[3];
        private readonly bool fill;
        private Color colour = Color.White;
        readonly Dictionary<string, int> collectVariables = new();
        readonly Variables variables= new();
        List<string> collectIfStatements = new();
        

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
            int parameter1;
            int parameter2;

            //used where points are required
            Point generalUsePoints = new();
            //all command execution happens in here
            for (int i = 0; i < commands.Length; i++)
            {
                try
                {
                    //checks commands that donot draw
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

                    //if statements
                    if (commands[i].StartsWith("if"))
                    {
                        
                        Rectangle rectangle1 = new(ShapePoint, cordinates[0], cordinates[1]);
                        collectIfStatements.Add(commands[i]);
                        i++;
                        if (commands[i].Contains(" "))
                        {
                            collectIfStatements.Add(commands[i]);
                            i++;
                            
                            if (commands[i].Contains(" "))
                            {
                                collectIfStatements.Add(commands[i]);
                                i++;
                                if (commands[i].Contains("endif"))
                                {
                                    collectIfStatements.Add(commands[i]);   
                                }
                                else
                                {
                                    Form1.ErrorMessages.Add("if statement not ended correctly");
                                }
                            }
                            else
                            {
                                Form1.ErrorMessages.Add("incorrect indentation was detected");
                            }

                        }
                        else
                        {
                            Form1.ErrorMessages.Add("incorrect indentation was detected");
                        }
                        IfStatements ifStatements = new(collectIfStatements,graphics);
                        continue;
                    }
                    //this block checks if a command is a 
                    //variable declaration
                    //if yes, store it in a dictionary
                    else if (commands[i].Contains('='))
                    {
                        try
                        {
                            string[] splitVariable = commands[i].Split('=');
                            collectVariables.Add(splitVariable[0], int.Parse(splitVariable[1]));
                            i++;
                            if (commands[i].Contains('='))
                            {
                                string[] splitVariable1 = commands[i].Split('=');
                                collectVariables.Add(splitVariable1[0], int.Parse(splitVariable1[1]));
                                
                            }
                            else
                            {
                                Form1.ErrorMessages.Add("Please Declare 2 variables");
                                break;
                                
                            }
                            variables.VariableProcessor(collectVariables);
                        }
                        catch (Exception) { Form1.ErrorMessages.Add("Variables have already been declared"); break; }
                        
                        continue;
                    }
                  
                     //this block processes the variables to be used as parameters
                    if (collectVariables.Count > 1)
                    {
                        string[] splitcommand = commands[i].Split(" "); //check what variable the command owns
                        if (splitcommand.Length > 2)
                        {
                            foreach(KeyValuePair<string, int> pair in collectVariables)
                            {
                                if (pair.Key.Contains(splitcommand[1]))
                                {
                                    parameter1 = pair.Value;
                                    cordinates[0] = parameter1;
                                }
                                else if (pair.Key.Contains(splitcommand[2]))
                                {
                                    parameter2= pair.Value;
                                    cordinates[1] = parameter2;
                                }
                            }
                            generalUsePoints.X = cordinates[0];
                            generalUsePoints.Y = cordinates[1];


                        }
                        else
                        {
                            foreach(KeyValuePair<string,int> pair in collectVariables)
                            {
                                if (pair.Key.Contains(splitcommand[1]))
                                {
                                    parameter1 = pair.Value;
                                    parameter2 = pair.Value;
                                    cordinates[0] = parameter1;
                                    cordinates[1] = parameter2;

                                    generalUsePoints.X = cordinates[0];
                                    generalUsePoints.Y = cordinates[1];
                                }
                            }
                        }
                        Cursor cursor = new(ShapePoint);
                        DrawTo drawto = new(ShapePoint, generalUsePoints);
                        Rectangle rectangle1 = new(ShapePoint, cordinates[0], cordinates[1]);
                        Triangle triangle = new(ShapePoint);
                        Circle circle = new(ShapePoint, cordinates[0]);
                        //this section checks for processed commands with integer parameters 
                        switch (splitcommand[0].ToLower()) //uniform all input
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
                                Form1.ErrorMessages.Add("Unrecognised command at: " + commands[i]);
                                break;

                        }
                    }
                    else //this section executes commands that do not own variables as parameters
                    {
                        string[] separators = { " ", "," };
                        IEnumerable<string> values = commands[i].Split(separators, StringSplitOptions.RemoveEmptyEntries); //split the first item in the array by two delimiters
                        string firstCommand = values.First().ToLower();


                        parameter1 = int.Parse(values.Skip(1).First()); //skip the first value which is the "firstCommand",get the second value
                        parameter2 = int.Parse(values.Last());

                        if (parameter1 >= 515 || parameter1 < 0 || parameter2 > 515 || parameter2 < 0)
                        {
                            throw new ArgumentOutOfRangeException(" \nValue out of bounds. limit 515 ");
                        }

                        cordinates[0] = parameter1;
                        cordinates[1] = parameter2;
                        generalUsePoints.X = cordinates[0];
                        generalUsePoints.Y = cordinates[1];

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
                                Form1.ErrorMessages.Add("Unrecognised command at: " + commands[i]);
                                break;
                        }
                    }

                }

                catch(FormatException)
                {
                        Form1.ErrorMessages.Add("Incorrect parameter at command: " + commands[i]);
                }

                catch(InvalidOperationException)
                {
                     Form1.ErrorMessages.Add("Missing Parameter at command: " + commands[i]);
                }

                catch (ArgumentOutOfRangeException)
                {
                   Form1.ErrorMessages.Add("The input parameter is too large!");
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
