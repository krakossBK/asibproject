using System;
using System.Collections.Generic;

namespace asibproject.Modelss
{
    public class UseerRepository : IUseerRepository
    {
        private List<UseerModel> useers = new List<UseerModel>();
        private int _nextId = 1;

        public UseerRepository()
        {
            Add(new UseerModel { firstName = "first1", lastName = "last1", email = "email1@gmail.com" });
            Add(new UseerModel { firstName = "first2", lastName = "last2", email = "email2@gmail.com" });
            Add(new UseerModel { firstName = "first3", lastName = "last3", email = "email3@gmail.com" });
        }

        public IEnumerable<UseerModel> GetAll()
        {
            return useers;
        }

        public UseerModel Add(UseerModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            useers.Add(item);
            return item;
        }
    }
}