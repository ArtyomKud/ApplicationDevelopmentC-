using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentC_.HomeWork6
{
    public interface ICalc_HW6
    {
        public double Result { get; set; }
        
        void SumDouble(double x);
        void SumInteger(int x);
        void SubtractDouble(double x);
        void SubtractInteger(int x);
        void MultiplyDouble(double x);
        void MultiplyInteger(int x);
        void DivideDouble(double x);
        void DivideInteger(int x);
        void CancelLast();

        event EventHandler<EventArgs> MyEventHandler;
    }
}
