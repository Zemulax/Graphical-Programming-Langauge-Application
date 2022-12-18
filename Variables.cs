using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    /// <summary>
    /// a class that allows use of variables
    /// </summary>
    public class Variables
    {
        private Dictionary<string,int> variablesDictionary= new();
        private static readonly List<int> variableints = new();
        public Variables() 
        {
           
        }

        /// <summary>
        /// method that takes a dictionary processes it
        /// for drawing commands
        /// </summary>
        /// <param name="variablesCollected">the dictionary to be processed</param>
        public void VariableProcessor (Dictionary<string, int> variablesCollected)
        {
            foreach (KeyValuePair<string, int> variables in variablesCollected)
            {
                variablesDictionary.Add(variables.Key, variables.Value);
                variableints.Add(variables.Value);
            }
        }

        /// <summary>
        /// dictionary property
        /// allows use of dictionary outside of this class
        /// </summary>
        public Dictionary<string,int> VariablesDictionary
        {
            get { return variablesDictionary; }
            set { variablesDictionary = value; }
            
        }

        /// <summary>
        /// variable ints property allows access
        /// to variable values from the dictionary
        /// </summary>
        public static List<int> VariableInts
        {
            get { return variableints; }
        }
    }


    
}
