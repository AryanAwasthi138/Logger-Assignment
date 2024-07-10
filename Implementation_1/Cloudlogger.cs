using Implementation_1.Interface_Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_1
{
    public class Cloudlogger : Rules
    {
        public Cloudlogger() {
            Console.WriteLine("Cloud Logger is invoked");
        }
        public bool WriteLog(string message)
        {
            Console.WriteLine("Uploaded Successfully " + message);
            return true;
        }
    }
}
