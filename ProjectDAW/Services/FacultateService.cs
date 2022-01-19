using ProiectDAW.Models;
using ProjectDAW.Repositories;
using ProjectDAW.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Services
{
    public class FacultateService : IFacultateService
    {
        private readonly IFacultateRepository _facultateRepository;

        public FacultateService(IFacultateRepository facultateRepository)
        {
            _facultateRepository = facultateRepository;
        }

        public Facultate Create(Facultate cat)
        {
            _facultateRepository.Create(cat);
            _facultateRepository.SaveChanges();

            return _facultateRepository.GetFacultateAllDetails(cat.FacultateId);
        }
        public Facultate Get(int id)
        {
            return _facultateRepository.GetFacultateAllDetails(id);
        }

        public bool Delete(int id)
        {
            var entity = _facultateRepository.FindById(id);
            if (entity != null)
            {
                _facultateRepository.Delete(entity);
                _facultateRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Facultate> GetAll()
        {
            return _facultateRepository.GetAllWithInclude();
        }

        public Facultate Update(Facultate cat)
        {
            if (_facultateRepository.FindById(cat.FacultateId) == null) return null;
            _facultateRepository.Update(cat);
            _facultateRepository.SaveChanges();
            return _facultateRepository.GetFacultateAllDetails(cat.FacultateId);
        }
    }
}
