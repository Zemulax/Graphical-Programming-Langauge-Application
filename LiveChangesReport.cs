using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    /// <summary>
    /// class for checking user input for errors
    /// in real time
    /// </summary>
    public class LiveChangesReport
    {
        /// <summary>
        /// this method generates messages tied to specific 
        /// incorrect user inputs
        /// </summary>
        /// <param name="syntax">an array of commands to be checked for errors</param>
        public LiveChangesReport(string[] syntax) 
        {
            for (int s = 0; s < syntax.Length; s++)
            {
                if (syntax[s].StartsWith("method") && !syntax[s].EndsWith("()"))
                {
                    Form1.SyntaxChecks.Add("method missing '()' at line: " + syntax[s]);
                    continue;
                }
                else if (!syntax[s].StartsWith("method") && syntax[s].EndsWith("()"))
                {
                    Form1.SyntaxChecks.Add("Check method definition, ignore if method call: " + syntax[s]);
                    continue;
                }
                else if (syntax[s].StartsWith("if") && syntax[s].EndsWith("=="))
                {
                    Form1.SyntaxChecks.Add("incomplete if statement detected at line: " + syntax[s]);
                    continue;
                }
                else if (!syntax[s].StartsWith("if") && syntax.Contains("=="))
                {
                    Form1.SyntaxChecks.Add("missing an if definition? at line " + syntax[s]);
                    continue;
                }
                else if (syntax[s].StartsWith("if") && !syntax[s].Contains("=="))
                {
                    Form1.SyntaxChecks.Add("check if-statement condition at line " + syntax[s]);
                    continue;
                }
                else if (syntax[s].Contains(" =") && syntax[s].EndsWith(" ="))
                {
                    Form1.SyntaxChecks.Add("variable initialisation is incomplete at line: " + syntax[s]);
                    continue;
                }
                else if (syntax[s].Contains("rectan") && syntax[s].EndsWith("e"))
                {
                    Form1.SyntaxChecks.Add("Did you forget a parameter? at line: " + syntax[s]);
                    continue;
                }
                else if (syntax[s].Contains("circ") && syntax[s].EndsWith("e"))
                {
                    Form1.SyntaxChecks.Add("Did you forget a parameter? at line: " + syntax[s]);
                    continue;
                }
                else if (syntax[s] == " " || syntax[s] == null)
                {
                    Form1.SyntaxChecks.Add("Empty line detected: " + syntax[s]);
                    continue;
                }
            }
        }
    }
}
