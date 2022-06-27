using Boardgames_test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boardgames_test.Data
{
    /// <summary>
    /// Database context for boardgames, users and orders
    /// </summary>
    public class Boardgames_PlatformContext: DbContext
    {
        public Boardgames_PlatformContext(DbContextOptions<Boardgames_PlatformContext> options)
            : base(options)
        {
        }
        public DbSet<Boardgames_test.Models.Boardgame> Boardgames { get; set; }

        public DbSet<Boardgames_test.Models.Order> Orders { get; set; }
        public DbSet<Boardgames_test.Models.User> Users { get; set; }

        public DbSet<Boardgames_test.Models.Category> Categories { get; set; }

        /// <summary>
        /// Adding order for specific boardgame and user, order is defaulted to be in "awaits" status
        /// </summary>
        /// <param name="boardgameID"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool AddOrder(int boardgameID, User user)
        {
            Order order = new Order();
            try
            {
                order.Boardgame = Boardgames.Find(boardgameID);
                order.User = user;
                order.OrderStatus = "awaits";
                order.OrderDate = DateTime.Now;
                order.ReturnDate = order.OrderDate.Date.AddDays(8);
                Orders.Add(order);
            }
            catch (Exception e)
            {
                return false;
            }


            return true;

        }
    }
}
