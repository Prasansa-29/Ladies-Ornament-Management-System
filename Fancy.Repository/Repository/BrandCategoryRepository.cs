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
    public class BrandCategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public BrandCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BrandCategory> GetAllBrandCategories()
        {
            return _context.BrandCategories.ToList();
        }

        public BrandCategory GetBrandCategoryById(int id)
        {
            return _context.BrandCategories.FirstOrDefault(bc => bc.BrandCategoryId == id);
        }

        public void AddBrandCategory(BrandCategory brandCategory)
        {
            _context.BrandCategories.Add(brandCategory);
            _context.SaveChanges();
        }

        public void UpdateBrandCategory(BrandCategory brandCategory)
        {
            _context.Entry(brandCategory).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteBrandCategory(BrandCategory brandCategory)
        {
            _context.BrandCategories.Remove(brandCategory);
            _context.SaveChanges();
        }
    }
}

