using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWorkshop1
{
    class Program1_1b
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

    class Person
    {
        string name;
        int height;
        string DateOfBirth;
        string gender;
        int age;

        int FindAge()
        {
            return age;
        }

    }

    class Product
    {
        public string productName;
        public Order orderNo;
        string productCode;
        double price;

        double findPrice()
        {
            return price;
        }
    }

    class Customer
    {
        string customerName;
        string customerAddress;

        string findCustomerName()
        {
            return customerName;
        }
    }

    class BankAccount
    {
        string accountNumber;
        public Customer owner;
        double balance;

        double findBalance()
        {
            return balance;
        }

        Customer findOwner()
        {
            return owner;
        }
    }

    class Order
    {
        string customerName;
        public Customer customer;
        string[] listOfItems;
        public int numberOfItems;
        string productId;
        double totalCost;

        double findTotalCost()
        {
            return totalCost;
        }        
    }


}
