using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects {
    interface IOrderDao {
        Order GetOrder(string orderId);

        List<Order> GetOrders(string customerPhone);

        void InsertOrder(Order order);

        void UpdateOrder(Order order);
    }
}
