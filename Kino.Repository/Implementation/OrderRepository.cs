﻿
using Kino.Domain.DomainModels;
using Kino.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Kino.Repository.Implementation /*201227*/
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Order> entities;

        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities =  context.Set<Order>();
        }
        public List<Order> GetAllOrders()
        {
           return entities
                .Include(z=>z.User)
                .Include(z => z.ProductInOrders)
                .Include("ProductInOrders.OrderedProduct")
                .ToListAsync().Result;
        }

        public Order GetOrderDetails(BaseEntity model)
        {
            return entities
              .Include(z => z.User)
              .Include(z => z.ProductInOrders)
              .Include("ProductInOrders.OrderedProduct")
              .SingleOrDefaultAsync(z => z.Id == model.Id).Result;
        }
    }
}
