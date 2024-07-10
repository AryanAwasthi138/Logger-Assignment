using Implementation_1.Interface_Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_1
{
    public class LogManager
    {
        Rules _storagetype = null;

        public LogManager(Rules storagetype)
        {
            _storagetype = storagetype;
        }
        public bool WriteLog(string message)
        {
            return _storagetype.WriteLog(message);
        }
    }
}
