using FoodHazardAnalysis.Interfaces.Repositories;
using FoodHazardAnalysis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHazardAnalysis.Services
{
    public class EAdditiveService : IService<Eadditives>
    {
        IRepository<Eadditives> _repository;

        public EAdditiveService(IRepository<Eadditives> repository)
        {
            _repository = repository;
        }

        public Repositories.EAdditiveRepository EAdditiveRepository
        {
            get => default(Repositories.EAdditiveRepository);
            set
            {
            }
        }

        public List<Eadditives> GetAll()
        {
            return _repository.GetAll();
        }

        public Eadditives GetById(int id)
        {
            return  _repository.GetById(id);
        }
    }
}
