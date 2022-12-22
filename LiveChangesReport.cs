using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    public class LiveChangesReport
    {
        
        public LiveChangesReport(string[] syntax) 
        {
          for(int s = 0; s < syntax.Length; s++)
            {
                if (syntax[s].StartsWith("method") && !syntax[s].EndsWith("()"))
                {
                    Form1.SyntaxChecks.Add("method not ended properly");
                    continue;
                }
                else if(!syntax[s].StartsWith("method") && syntax[s].EndsWith("()"))
                {
                   Form1.SyntaxChecks.Add("bad method definition detected");
                    break;
                }
                else if(syntax[s].StartsWith("if") && syntax[s].EndsWith("=="))
                {
                   Form1.SyntaxChecks.Add("incomplete if statement detected") ;
                    break;
                }
                else if(!syntax[s].StartsWith("if") && syntax.Contains("=="))
                {
                    Form1.SyntaxChecks.Add("missing an if definition?");
                    break;
                }
                else if(syntax[s].StartsWith("if") && !syntax[s].Contains("=="))
                {
                   Form1.SyntaxChecks.Add("check if-statement condition" + syntax);
                    break;
                }
                else if(syntax[s].Contains(" =") && syntax[s].EndsWith(" ="))
                {
                    Form1.SyntaxChecks.Add("variable initialisation is incomplete at line: " + syntax[s]);
                    continue;
                }
            }
        }
    }
}
