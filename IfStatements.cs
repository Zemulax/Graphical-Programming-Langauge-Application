namespace MyAssignment
{
    /// <summary>
    /// classs used to execute code determined by 
    /// a condition
    /// </summary>
    public class IfStatements
    {
        private readonly Dictionary<string, int> ifstatementsDictionary = new();
        static int shapeParameter = 0;
        static readonly string[] methodlines = new string[2];

        public IfStatements() { }

        /// <summary>
        /// if statement constructor initates executing commands using if statements
        /// </summary>
        /// <param name="ifStatementsList">an if statement block to be processed</param>
        /// <param name="graphihcs">a drawing surface for commands in if statements</param>
        public IfStatements(List<string> ifStatementsList)
        {
            try
            {

                string[] ifstatementSplit = ifStatementsList[0].Split(" "); //if mozay = 90; line1 ;line2 ;endif
                ifstatementsDictionary.Add(ifstatementSplit[1], int.Parse(ifstatementSplit[3])); //take specific values from the array


                string[] line1 = ifStatementsList[1].Split(" ");
                string[] line2 = ifStatementsList[2].Split(" ");


                methodlines[0] = line1[1];
                methodlines[1] = line2[1];

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
                            break;
                        }
                    }
                    else
                    {
                        Form1.ErrorMessages.Add("That variable was not found");
                    }


                }

            }

            catch (IndexOutOfRangeException)
            {
                Form1.ErrorMessages.Add("If statement was not properly created!");

            }

        }

        /// <summary>
        /// shape parameter property is used to
        /// supply a draw parameter when an if statement is drawn
        /// </summary>
        public static int ShapeParameter
        {
            get { return shapeParameter; }
        }
        /// <summary>
        /// property for method lines is used to
        /// provide access to the line within
        /// an if-statement block
        /// </summary>
        public static Array Methodlines
        {
            get { return methodlines; }
        }
    }
}
