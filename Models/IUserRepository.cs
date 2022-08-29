using System;
using System.Collections.Generic;

namespace asibproject.Models
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        
        UserModel Add(UserModel user);
    }
}