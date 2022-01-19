using ProiectDAW.Models;
using ProjectDAW.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDAW.Mapper
{
    public static class UserMapper
    {
        public static User ToUserExtension(this RegisterRequest request)
        {
            return new User
            {
                Email = request.Mail,
                Password = request.Password,
                FacultateId = request.FacultateId
            };
        }
    }
}
