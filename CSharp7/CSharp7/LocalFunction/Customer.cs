using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunction
{
    class Customer
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public bool Vip
        {
            get
            {
                return CustomerPriority();
                bool CustomerPriority()
                {
                    return Balance > 1000 ? true : false;
                }
            }
        }
        public override string ToString()
        {
            return String.Format("{0} {1} öncelikli bir müşteridir. ", Name, CustomerPriority(Balance));
            // local function:
            string CustomerPriority(int balance)
            {
                return balance > 1000 ? "H" : "L";
            }
        }
    }
}
