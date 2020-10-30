using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    interface ICustomerDao {
        Customer GetCustomer(string phone);

        void InsertCustomer(Customer customer);

        void UpdateCustomer(Customer customer);
    }
}
