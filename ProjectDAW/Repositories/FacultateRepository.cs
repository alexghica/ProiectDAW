using Microsoft.EntityFrameworkCore;
using ProiectDAW.Data;
using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Repositories
{
    public class FacultateRepository : GenericRepository<Facultate>, IFacultateRepository
    {
        public FacultateRepository(FacultateContext context) : base(context)
        {

        }
        public Facultate GetFacultateaAllDetails(int id)
        {
            return _table.Where(arg => arg.FacultateId == id)
                .FirstOrDefault();
        }

        public List<Facultate> GetFacultatiAllDetails()
        {
            return _table
                .ToList();
        }

        public List<Facultate> GetAllWithInclude()
        {
            return _table.Include(x => x.Useri).ToList();
        }

        public List<Facultate> GetAllWithJoin()
        {
            var result = _table.Join(_context.Users, x => x.FacultateId, y => y.FacultateId,
                (x, y) => new { x, y }).Select(obj => obj.x);

            return result.ToList();
        }

    }
}
