
namespace MyAssignment
{
    /// <summary>
    /// this class parses and executes all commands
    /// </summary>
    internal class CommandParser  
    {
        readonly int[] cordinates = new int[3];
        private string command;
        private readonly Graphics graphics;
        readonly Rectangle1? rect = null;

        /// <summary>
        /// commandParser constructor 
        /// </summary>
        /// <param name="graphics">surface where the drawing will happen</param>
        /// <param name="commands">an array of commands to be parsed</param>
        public CommandParser(Graphics graphics,string[] commands)
        {
            this.graphics = graphics;

            for (int i = 0; i < commands.Length; i++)
            {

                    try
                    {
                        IEnumerable<string> values = commands[i].Split(" "); //split the first item in the array
                        string firstCommand = values.First();
                        int xCord = int.Parse(values.Skip(1).First());
                        int yCord = int.Parse(values.Last());


                        cordinates[0] = xCord;
                        cordinates[1] = yCord;

                        switch (firstCommand)
                        {

                            case "rectangle":
                                this.command = firstCommand;
                                rect = new Rectangle1(100, 100, yCord, xCord);
                                rect.DrawShape(graphics);
                                break;

                            case "":
                                MessageBox.Show("Have you entered a command?");
                                break;

                            default:
                                MessageBox.Show("wrong command");
                                break;
                        }
                    }

                    catch (FormatException)
                    {
                        MessageBox.Show("You might have entered an incorrect parameter!");
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("You might have forgotten a Parameter!");
                    }
                

                
             }
        }

        /// <summary>
        /// sets and gets the value of command
        /// </summary>
        public string Command
        {
            set { command = value; }
            get { return command; }
        }

        /// <summary>
        /// sets and gets the coordiated into the array
        /// </summary>
        public int[] Cordinates
        {
            get { return cordinates; }
        }

    }
}
