﻿using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Repositories
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        Role GetRoleAllDetails(int id);
        List<Role> GetRolesAllDetails();
    }
}
