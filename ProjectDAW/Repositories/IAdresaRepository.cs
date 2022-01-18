using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Repositories
{
    public interface IAdresaRepository : IGenericRepository<Adresa>
    {
        Adresa GetAdresaAllDetails(int id);
        List<Adresa> GetAdreseAllDetails();
    }
}
