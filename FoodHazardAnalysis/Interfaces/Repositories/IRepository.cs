using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHazardAnalysis.Interfaces.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
    }
}
