using System;
using System.Collections.Generic;

namespace asibproject.Modelss
{
    public interface IUseerRepository
    {
        IEnumerable<UseerModel> GetAll();
        
        UseerModel Add(UseerModel useer);
    }
}