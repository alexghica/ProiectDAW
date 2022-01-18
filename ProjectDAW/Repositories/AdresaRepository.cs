using ProiectDAW.Data;
using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Repositories
{
    public class AdresaRepository : GenericRepository<Adresa>, IAdresaRepository
    {
        public AdresaRepository(FacultateContext context) : base(context)
        {

        }
        public Adresa GetAdresaAllDetails(int id)
        {
            return _table.Where(arg => arg.AdresaId == id)
                .FirstOrDefault();
        }

        public List<Adresa> GetAdreseAllDetails()
        {
            return _table
                .ToList();
        }
    }
}
