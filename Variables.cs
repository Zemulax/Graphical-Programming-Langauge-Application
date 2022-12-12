
namespace MyAssignment
{
    /// <summary>
    /// a class that allows use of variables
    /// as parameters and in loops
    /// </summary>
    public class Variables
    {
        readonly List<string> variablesList = new();
        readonly List<int> paramValues = new();
       
        
        /// <summary>
        /// empty varibles constructor
        /// </summary>
        public Variables() 
        {
        }

        /// <summary>
        /// this method proccesses variable declarations
        /// makes it possible for the variables to be used as parameters
        /// 
        /// </summary>
        /// <param name="variable">the variable to be processed</param>
        public void Checkvarible(string variable)
        {
            string[] vars = variable.Split(' ');

            if (variablesList.Contains(vars[1]))
            {
             MessageBox.Show("Ambigous variable declaration detected,first variable will be used!");//
            }
            else
            {
                variablesList.Add(vars[1]);
                paramValues.Add(int.Parse(vars[3]));
            }
        }
       
        /// <summary>
        /// variableList property
        /// allows access to a storage of variables
        /// </summary>
        public List<string>VariablesList
        {
            get { return variablesList; }
        }

        /// <summary>
        /// paramValues property
        /// allows access to a storage of parameters
        /// </summary>
        public List<int> ParamValues
        {
            get { return paramValues; }
        }
        
    }
}
