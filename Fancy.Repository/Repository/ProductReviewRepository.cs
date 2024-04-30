using Fancy.Models.Items;
using FANCY_CLOTHES_MANAGEMENT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Repository.Repository
{
    public class ProductReviewRepository : IProductReviewRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductReview> GetAllProductReviews()
        {
            return _context.ProductReview.ToList();
        }

        public ProductReview GetProductReviewById(int id)
        {
            return _context.ProductReview.Find(id);
        }

        public void AddProductReview(ProductReview productReview)
        {
            _context.ProductReview.Add(productReview);
            _context.SaveChanges();
        }

        public void UpdateProductReview(ProductReview productReview)
        {
            _context.ProductReview.Update(productReview);
            _context.SaveChanges();
        }

        public void DeleteProductReview(int id)
        {
            var productReview = _context.ProductReview.Find(id);
            if (productReview != null)
            {
                _context.ProductReview.Remove(productReview);
                _context.SaveChanges();
            }
        }
    }

    public interface IProductReviewRepository
    {
        IEnumerable<ProductReview> GetAllProductReviews();
        ProductReview GetProductReviewById(int id);
        void AddProductReview(ProductReview productReview);
        void UpdateProductReview(ProductReview productReview);
        void DeleteProductReview(int id);
    }
}

