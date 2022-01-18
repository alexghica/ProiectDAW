using ProiectDAW.Data;
using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(FacultateContext context) : base(context)
        {
        }

        public Role GetRoleAllDetails(int id)
        {
            return _table.Where(arg => arg.RoleId == id)
                .FirstOrDefault();
        }

        public List<Role> GetRolesAllDetails()
        {
            return _table
                .ToList();
        }
    }
}
