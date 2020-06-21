using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class OrderItemRepository : BaseRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(PhoneDbContext context) : base(context)
        {
        }

        public void SaveOrderItem(OrderItem orderItem)
        {
            if (orderItem.Id == 0)
            {
                _context.OrderItems.Add(orderItem);
                var kote = _context.OrderItems;
            }
            _context.SaveChanges();
        }
    }
}
