﻿using FoodHazardAnalysis.Interfaces.DbContext;
using FoodHazardAnalysis.Interfaces.Repositories;
using FoodHazardAnalysis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodHazardAnalysis.Repositories
{
    public class EAdditiveRepository: IRepository<Eadditives>
    {
        IContext _context;
        public EAdditiveRepository(IContext context)
        {
            _context = context;
        }
        public List<Eadditives> GetAll()
        {
            return _context.Eadditives.OrderBy(x => x.Name).ToList();
        }

        public Eadditives GetById(int Id)
        {
            return _context.Eadditives.ToList().Find(x => x.Id == Id);
        }
    }
}