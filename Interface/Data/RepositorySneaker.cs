﻿using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class RepositorySneaker : RepositoryBase<Sneaker>, IRepositorySneaker
    {
        private readonly ApplicationContext _context;
        public RepositorySneaker(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public ICollection<Sneaker>? GetByBrand(string brand)
        {
            return (List<Sneaker>)_context.Set<Sneaker>().ToList().Where(sneaker => sneaker.Brand == brand);
        }

        public ICollection<Sneaker>? GetByCategory(string category)
        {
            return (List<Sneaker>)_context.Set<Sneaker>().ToList().Where(Sneaker => Sneaker.Category == category);
        }

        public void Buy(Sneaker sneaker)
        {
            sneaker.Stock = sneaker.Stock - 1;
            _context.SaveChanges();
        }

        public bool CheckAvailableProduct(Sneaker sneaker)
        {
            return sneaker.Stock > 0;
        }
    }
}