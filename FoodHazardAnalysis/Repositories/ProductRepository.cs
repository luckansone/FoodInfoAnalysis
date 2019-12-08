using FoodHazardAnalysis.Interfaces.DbContext;
using FoodHazardAnalysis.Interfaces.Repositories;
using FoodHazardAnalysis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHazardAnalysis.Repositories
{
    public class ProductRepository : IRepository<Products>
    {
        IContext _context;
        public ProductRepository(IContext context)
        {
            _context = context;
        }

        public Products Products
        {
            get => default(Products);
            set
            {
            }
        }

        public List<Products> GetAll()
        {
            return _context.Products.OrderBy(x => x.Name).ToList();
        }

        public Products GetById(int Id)
        {
            return _context.Products.ToList().Find(x => x.Id == Id);
        }
    }
}
