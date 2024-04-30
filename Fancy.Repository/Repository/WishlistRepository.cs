using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fancy.Models.Items;
using FANCY_CLOTHES_MANAGEMENT.Services;

namespace Fancy.Repository.Repository
{
    public class WishlistRepository : IWishlistRepository
        {
            private readonly ApplicationDbContext _context;

            public WishlistRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public IEnumerable<Wishlist> GetAllWishlists()
            {
                return _context.Wishlist.ToList();
            }

            public Wishlist GetWishlistById(int id)
            {
                return _context.Wishlist.Find(id);
            }

            public void AddWishlist(Wishlist wishlist)
            {
                _context.Wishlist.Add(wishlist);
                _context.SaveChanges();
            }

            public void UpdateWishlist(Wishlist wishlist)
            {
                _context.Wishlist.Update(wishlist);
                _context.SaveChanges();
            }

            public void DeleteWishlist(int id)
            {
                var wishlist = _context.Wishlist.Find(id);
                if (wishlist != null)
                {
                    _context.Wishlist.Remove(wishlist);
                    _context.SaveChanges();
                }
            }
        }

        public interface IWishlistRepository
        {
            IEnumerable<Wishlist> GetAllWishlists();
            Wishlist GetWishlistById(int id);
            void AddWishlist(Wishlist wishlist);
            void UpdateWishlist(Wishlist wishlist);
            void DeleteWishlist(int id);
        }
    
}
