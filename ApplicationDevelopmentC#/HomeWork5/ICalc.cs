using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentC_.HomeWork5
{
    public interface ICalc
    {
        public double Result { get; set; }
        void Sum(double x);
        void Subtract(double x);
        void Multiply(double x);
        void Divide(double x);
        void CancelLast();

        event EventHandler<EventArgs> MyEventHandler;
    }
}
