using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class OrderItem
    {
        private readonly ILazyLoader _lazyLoader;
        private Phone _phone;
        private Order _order;
        public OrderItem()
        {
        }

        public OrderItem(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        public int Id { get; set; }

        public int OrderId { get; set; }

        public Order Order
        {
            get => _lazyLoader.Load(this, ref _order);
            set => _order = value;
        }

        public int PhoneId { get; set; }

        public Phone phone
        {
            get => _lazyLoader.Load(this, ref _phone);
            set => _phone = value;
        }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

    }
}
