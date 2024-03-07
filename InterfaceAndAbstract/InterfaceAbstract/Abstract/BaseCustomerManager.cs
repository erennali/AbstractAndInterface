using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.Abstract
{
    public abstract class BaseCustomerManager : ICustomerServices
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine($"Saved to db: {customer.FirstName}");
        }
    }
}
