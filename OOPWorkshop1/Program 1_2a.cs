using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWorkshop1
{
    class Program1_2a
    {
        static void Main(string[] args)
        {
            Customer ownerA = new Customer();
            BankAccount accountA = new BankAccount();
            accountA.owner = ownerA;

            BankAccount accountB = new BankAccount();
            accountB.owner = ownerA;
        }
    }

    class Program1_2b
    {
        static void Main(string[] args)
        {
            Customer ownerA = new Customer();

            Order orderA = new Order();
            orderA.customer = ownerA;

            Product productA = new Product();
            productA.orderNo = orderA;

            Order orderB = new Order();
            orderB.customer = ownerA;

            Product productB = new Product();
            productB.orderNo = orderB;

        }
    }

}
