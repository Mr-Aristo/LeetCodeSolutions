using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.GRAPS_and_SOLID.SOLID
{
    /*
         Clients should not be forced to depend upon the interfaces that they do not use.
     */
    public class InterfaceSegregation
    {
        // ISP'yi ihlal eden örnek
        public interface IMachine
        {
            void Print();
            void Scan();
            void Fax();
        }

        // ISP'yi takip eden örnek
        public interface IPrinter
        {
            void Print();
        }

        public interface IScanner
        {
            void Scan();
        }

        public interface IFax
        {
            void Fax();
        }

        public class MultiFunctionPrinter : IPrinter, IScanner, IFax
        {
            public void Print() { }
            public void Scan() { }
            public void Fax() { }
        }

        public class SimplePrinter : IPrinter
        {
            public void Print() { }
        }

    }

}

