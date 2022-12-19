using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    internal class Methods
    {
        public string[] methodLines =  new string[2];
        public string[] methodname;
        public Methods() { }

        public void MethodsProcessor(List<string> collectedMethod) //method mozay(); rectangle 100; circle 200; endmethod
        { 
            methodname = collectedMethod[0].Split(' ');
            methodLines[0] = collectedMethod[1];
            methodLines[1] = collectedMethod[2];
           
            //methodStorage.Add(collectedMethod[1].Split(" "));

        }
    }
}
