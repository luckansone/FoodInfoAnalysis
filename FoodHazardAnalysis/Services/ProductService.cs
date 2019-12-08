using FoodHazardAnalysis.Interfaces.Repositories;
using FoodHazardAnalysis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHazardAnalysis.Services
{
    public class ProductService:IService<Products>
    {
        IRepository<Products> _repository;

        public ProductService(IRepository<Products> repository)
        {
            _repository = repository;
        }

        public Repositories.ProductRepository ProductRepository
        {
            get => default(Repositories.ProductRepository);
            set
            {
            }
        }

        public List<Products> GetAll()
        {
            return _repository.GetAll();
        }

        public Products GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
