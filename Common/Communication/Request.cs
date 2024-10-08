using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    [Serializable]
    public class Request
    {
        public Operation Operation { get; set; }   
        public Object Argument {  get; set; }

        public Request() { }
        public Request(Operation operation, object argument)
        {
            Operation = operation;
            Argument = argument;
        }




    }
}
