using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Interface
{
    public interface ILog
    {
        public void Info(string str);
        
        public void Warn(string str);

        public void Error(string str);    


            
    }
}
