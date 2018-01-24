using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local Function 1
            DisplayCustomerListData();

            // Local Function  2
            Customer cust = new Customer { Name = "Bilisim.io", Balance = 100000 };
            Console.WriteLine(cust.ToString());

            // Local Function  get ör3
            Customer cust3 = new Customer { Name = "Bilisim.io", Balance = 200000 };
            Console.WriteLine(cust3.Vip);

            Console.ReadKey();
        }
        private static void DisplayCustomerListData()
        {
            int listSize = 20; // Hatalı kullanım fakat göstermek için
            List<Customer> PopulateCustomer()
            {
                List<Customer> list = new List<Customer>();
                for (int i = 0; i < listSize; i++)
                {
                    list.Add(new Customer { Name = "Customer " + i.ToString(), Balance = 500 * i });
                }
                return list;
            }

            List<Customer> listOfCutomer = PopulateCustomer();
            foreach (var cust in listOfCutomer)
            {
                Console.WriteLine(string.Format(" Customer : {0} - {1}- {2}", cust.Name, cust.Balance, cust.ToString()));
            }
        }
    }
}
