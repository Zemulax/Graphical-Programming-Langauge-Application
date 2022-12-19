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
        private static Color colour = Color.White;
        readonly Dictionary<string, int> collectVariables = new();
        readonly Variables variables= new();
        List<string> collectIfStatements = new();
        List<string>collectedMethods = new();
        Colours colours = new(colour);
        Methods methods= new Methods();
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
            int parameter1;
            int parameter2;

            //used where points are required
            Point generalUsePoints = new();
            //all command execution happens in here
            for (int i = 0; i < commands.Length; i++)
            {
                try
                {
                    //methods
                    if (commands[i].ToLower().StartsWith("method"))
                    {
                        if (commands[i].ToLower().EndsWith("()"))
                        {

                            collectedMethods.Add(commands[i]);
                            i++;
                            if (commands[i].StartsWith(" "))
                            {
                                collectedMethods.Add(commands[i]);
                                i++;
                                if (commands[i].StartsWith(" "))
                                {
                                    collectedMethods.Add(commands[i]);
                                    i++;
                                    if (commands[i].Contains("endmethod"))
                                    {
                                        collectedMethods.Add(commands[i]);

                                    }
                                    else
                                    {
                                        Form1.ErrorMessages.Add("Warning: Method not ended properly at line: " + commands[i]);
                                        return;
                                    }
                                }
                                else
                                {
                                    Form1.ErrorMessages.Add("incorrect indentation detected at line: " + commands[i]);
                                    return;

                                }
                            }
                            else
                            {
                                Form1.ErrorMessages.Add("incorrect indentation detected at line: " + commands[i]);
                                return;

                            }
                        }
                        else
                        {
                            Form1.ErrorMessages.Add("Warning!! Bad command definition detected. Please inspect and add () at line: " + commands[i]);
                            return;
                        }
                        methods.MethodsProcessor(collectedMethods);
                        continue;

                    }
                    else if (methods.methodname == null)
                    {
                    }
                    else if (commands[i].Contains(methods.methodname[1]))
                    {
                        {
                            for (int c = 0; c < methods.methodLines.Length; c++)
                            {
                                commands[i] = methods.methodLines[c];
                                c++;

                            }
                        }

                    }
                    else
                    {}
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
                    if (commands[i].Contains(" = "))
                    {
                        try
                        {
                            string[] splitVariable = commands[i].Split('=');
                            collectVariables.Add(splitVariable[0], int.Parse(splitVariable[1]));
                            variables.VariableProcessor(collectVariables);
                        }
                        catch (Exception) { Form1.ErrorMessages.Add("Variables have already been declared"); break; }

                        continue;
                    }


                    //if statements
                    else if (commands[i].Contains("if"))
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
                                    Form1.ErrorMessages.Add("if statement not ended correctly at line:" + commands[i]);
                                    return;
                                }
                            }
                            else
                            {
                                Form1.ErrorMessages.Add("incorrect indentation was detected at line: " + commands[i]);
                                return;
                            }

                        }
                        else
                        {
                            Form1.ErrorMessages.Add("incorrect indentation was detected at line:" + commands[i]);
                            return;
                        }
                        IfStatements ifStatements = new(collectIfStatements, graphics);
                        continue;
                    }
               


                    //this block processes the variables to be used as parameters
                    else if (collectVariables.Count > 0)
                    {
                        string[] splitcommand = commands[i].Split(" "); //check what variable the command owns
                        if (splitcommand.Length > 2)
                        {
                            foreach (KeyValuePair<string, int> pair in collectVariables)
                            {
                                if (pair.Key.Contains(splitcommand[1]))
                                {
                                    parameter1 = pair.Value;
                                    cordinates[0] = parameter1;
                                }
                                else if (pair.Key.Contains(splitcommand[2]))
                                {
                                    parameter2 = pair.Value;
                                    cordinates[1] = parameter2;
                                }
                            }
                            generalUsePoints.X = cordinates[0];
                            generalUsePoints.Y = cordinates[1];


                        }
                        else
                        {
                            foreach (KeyValuePair<string, int> pair in collectVariables)
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
                        continue;
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

                            case "penta":
                                Pen penpen = new (Color.Red);
                                triangle.DrawShape(graphics, fill, colours.ShapePen, colours.ShapeBrush);
                                circle.DrawShape(graphics, fill, colours.ShapePen, colours.ShapeBrush);
                                rectangle1.DrawShape(graphics, fill, colours.ShapePen, colours.ShapeBrush);
                                graphics.DrawBezier(penpen, 40, 80, 120, 160, 200, 240, 280, 320);
                                break;

                            default:
                                Form1.ErrorMessages.Add("Unrecognised command at: " + commands[i]);
                                break;
                        }
                       
                    }

                }

                catch (NullReferenceException)
                {
                    Form1.ErrorMessages.Add("Warning! Please check that your method definition contains ()");
                }

                catch (FormatException)
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
