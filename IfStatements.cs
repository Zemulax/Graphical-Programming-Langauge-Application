
namespace MyAssignment
{
    /// <summary>
    /// classs used to execute code determined by 
    /// a condition
    /// </summary>
    public class IfStatements : Shape
    {
        private readonly Dictionary<string, int> ifstatementsDictionary= new();
        private static string line;
        Graphics graphics;
        private  readonly Color colour = Color.White;
        readonly CommandParser commandParser = new();

        int shapeParameter = 0;

        public IfStatements() { }

        /// <summary>
        /// if statement constructor initates executing commands using if statements
        /// </summary>
        /// <param name="ifStatementsList">an if statement block to be processed</param>
        /// <param name="graphihcs">a drawing surface for commands in if statements</param>
        public IfStatements(List<string> ifStatementsList, Graphics graphics) 
        {
            this.graphics = graphics;
            string[] ifstatementSplit = ifStatementsList[0].Split(" "); //if mozay = 90; line1 ;line2 ;endif
            ifstatementsDictionary.Add(ifstatementSplit[1], int.Parse(ifstatementSplit[3])); //take specific values from the array


            string[] line1 = ifStatementsList[1].Split(" ");
            string[] line2 = ifStatementsList[2].Split(" ");

            string[] west = new string[2];
            west[0] = line1[1];
            west[1] = line2[1];

            foreach (KeyValuePair<string, int> pairs in Variables.VariablesDictionary)
            {

                if (ifstatementsDictionary.ContainsKey(pairs.Key.Trim()))
                {
                    
                    if (ifstatementsDictionary.ContainsValue(pairs.Value))
                    {

                        shapeParameter = pairs.Value;

                    }
                    else
                    {
                        Form1.ErrorMessages.Add("Condition returned false");
                    }
                }
                else
                {
                    Form1.ErrorMessages.Add("That variable was not found");
                }

                
            }
            Rectangle rectangle1 = new(ShapePoint, shapeParameter,shapeParameter);
            Circle circle = new(ShapePoint, shapeParameter);
            Colours colours = new(colour);

            for(int x = 0; x < west.Length; x++)
            {
                switch (west[x])
                {
                    case "rectangle":
                        rectangle1.DrawShape(graphics, commandParser.Fill, colours.ShapePen, colours.ShapeBrush);
                        break;

                    case "circle":
                        circle.DrawShape(graphics, commandParser.Fill, colours.ShapePen, colours.ShapeBrush);
                        break;

                    default:
                        break;
                }

            }



        }
        public static string Line 
        { 
            get { return line; }
            //set { line =value; }
        }

        public override void DrawShape(Graphics graphics, bool fill, Pen shapePen, Brush shapeBrush)
        {
            throw new NotImplementedException();
        }
    }
}
