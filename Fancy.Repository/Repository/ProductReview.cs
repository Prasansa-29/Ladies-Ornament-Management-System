using Fancy.Models.Items;
using FANCY_CLOTHES_MANAGEMENT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Repository.Repository
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductImageRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductImage> GetAllProductImages()
        {
            return _context.ProductImages.ToList();
        }

        public ProductImage GetProductImageById(int id)
        {
            return _context.ProductImages.Find(id);
        }

        public void AddProductImage(ProductImage productImage)
        {
            _context.ProductImages.Add(productImage);
            _context.SaveChanges();
        }

        public void UpdateProductImage(ProductImage productImage)
        {
            _context.ProductImages.Update(productImage);
            _context.SaveChanges();
        }

        public void DeleteProductImage(int id)
        {
            var productImage = _context.ProductImages.Find(id);
            if (productImage != null)
            {
                _context.ProductImages.Remove(productImage);
                _context.SaveChanges();
            }
        }
    }

    public interface IProductImageRepository
    {
        IEnumerable<ProductImage> GetAllProductImages();
        ProductImage GetProductImageById(int id);
        void AddProductImage(ProductImage productImage);
        void UpdateProductImage(ProductImage productImage);
        void DeleteProductImage(int id);
    }
}

