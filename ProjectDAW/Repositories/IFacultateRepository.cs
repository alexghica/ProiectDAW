using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Repositories
{
    public interface IFacultateRepository : IGenericRepository<Facultate>
    {
        Facultate GetFacultateAllDetails(int id);
        List<Facultate> GetFacultateAllDetails();
        List<Facultate> GetAllWithInclude();
        List<Facultate> GetAllWithJoin();
    }
}
