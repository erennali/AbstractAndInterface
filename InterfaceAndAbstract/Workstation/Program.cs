using InterfaceAbstract.Abstract;
using InterfaceAbstract.Adapters;
using InterfaceAbstract.Concrete;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2004, 3, 11), FirstName = "EREN ALİ", LastName = "KOA", NationalityId = "19448581460" });
            Console.ReadLine();
        }
    }
}
