using Log.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Implementation
{
    public class MonSystemeDeLogs : ILog
    {
        public void Error(string str)
        {
            Console.WriteLine("Error/ {0} / : {1}", DateTime.Now, str);
        }

        public void Info(string str)
        {
            Console.WriteLine("Info/ {0} / : {1}", DateTime.Now, str);
        }

        public void Warn(string str)
        {
            Console.WriteLine("Warn/ {0} / : {1}", DateTime.Now, str);
        }
    }
}
