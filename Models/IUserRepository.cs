using System;
using System.Collections.Generic;

namespace asibproject.Models
{
    public interface IUseerRepository
    {
        IEnumerable<UseerModel> GetAll();
        
        UseerModel Add(UseerModel useer);
    }
}