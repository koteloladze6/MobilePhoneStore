using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IOrderItemRepository : IBaseRepository<OrderItem>
    {
        void SaveOrderItem(OrderItem orderItem);
    }
}
