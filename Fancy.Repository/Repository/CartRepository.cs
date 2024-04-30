using Fancy.Models.Items;
using FANCY_CLOTHES_MANAGEMENT.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Repository.Repository
{
    public class CartRepository
    {
        private readonly ApplicationDbContext _context;

        public CartRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cart> GetAllCarts()
        {
            return _context.Cart.ToList();
        }

        public Cart GetCartById(int id)
        {
            return _context.Cart.FirstOrDefault(c => c.CartId == id);
        }

        public void AddCart(Cart cart)
        {
            _context.Cart.Add(cart);
            _context.SaveChanges();
        }

        public void UpdateCart(Cart cart)
        {
            _context.Entry(cart).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteCart(Cart cart)
        {
            _context.Cart.Remove(cart);
            _context.SaveChanges();
        }
    }
}

