

using DocumentFormat.OpenXml.Drawing;

namespace MyAssignment
{
    /// <summary>
    /// this class parses and executes all commands
    /// </summary>
    internal class CommandParser  : DrawService
    {
        readonly DrawService drawService;
        readonly Rectangle1 rect = null;
        readonly int[] cordinates = new int[3];
        private string command = null;

        private bool fill;
        
        /// <summary>
        /// commandParser constructor 
        /// </summary>
        /// <param name="graphics">surface where the drawing will happen</param>
        /// <param name="commands">an array of commands to be parsed</param>
        public CommandParser(Graphics g,string[] commands, string fillers)  : base(g)
        {
            if(fillers.Equals("fill on")){
                this.fill = true;
            }
            
            drawService = new DrawService(Graphic);
            for (int i = 0; i < commands.Length; i++)
            {

                    try
                    {
                        IEnumerable<string> values = commands[i].Split(" "); //split the first item in the array by space
                        string firstCommand = values.First();
                        int parameter1 = int.Parse(values.Skip(1).First());
                        int parameter2 = int.Parse(values.Last());


                        cordinates[0] = parameter1;
                        cordinates[1] = parameter2;

                    switch (firstCommand.ToLower()) //uniform all input
                    {

                        case "drawto":
                           
                            drawService.DrawTo(parameter1, parameter2);
                            //MessageBox.Show(YPos + "" + XPos);
                            break;

                        case "rect":
                            rect = new Rectangle1(XPos,YPos, parameter1, parameter2);
                            rect.DrawShape(Graphic,fill);
                            break;

                        case "circle":
                            Circle circle = new (XPos, YPos, parameter1, parameter2);
                            circle.DrawShape(Graphic,fill);

                            break;
                        case "moveto":
                            drawService.MoveTo(parameter1, parameter2);
                            break;

                        default:
                            MessageBox.Show("wrong command");
                            break;
                    }
                }

                catch (FormatException)
                    {
                        MessageBox.Show("You might have entered an incorrect parameter at " + i);
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
