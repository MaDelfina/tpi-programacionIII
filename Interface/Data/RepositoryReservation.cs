using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ReservationRepository : RepositoryBase<Reservation>
    {
        private readonly ApplicationContext _context;
        public ReservationRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        /*
        public ICollection<Sneaker> GetSneaker

        public ICollection<Subject> GetStudentSubjects(int studentId) =>
        _context.Students.Include(a => a.SubjectsAttended).ThenInclude(m => m.Professors).Where(a => a.Id == studentId)
        .Select(a => a.SubjectsAttended).FirstOrDefault() ?? new List<Subject>();*/
    }
}
