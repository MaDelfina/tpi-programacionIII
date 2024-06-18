using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;

namespace Infrastructure.Data
{
    public class RepositoryUser : RepositoryBase<User>, IRepositoryUser
    {
        private readonly ApplicationContext _context;
        public RepositoryUser(ApplicationContext context) : base(context)
        {
            _context = context;
        }


    }
}