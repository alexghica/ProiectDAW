using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Services.IServices
{
    public interface IFacultateService
    {
        Facultate Create(Facultate facultate);
        Facultate Get(int id);
        Facultate Update(Facultate facultate);
        bool Delete(int id);
        List<Facultate> GetAll();
    }
}
