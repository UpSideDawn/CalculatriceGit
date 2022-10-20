using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IOperationBasiqueService
    {
        public double Addition(double a, double b);


        public double Soustraction(double a, double b);


        public double Division(double a, double b);


        public double Multiplication(double a, double b);
    }   
}
