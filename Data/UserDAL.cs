using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace asibproject.Data
{
    public class UserDAL
    {
        private static readonly ApplicationContext db = new ApplicationContext();

        //this method will get all the user record
        public static IEnumerable<User> GetAllUsers()
        {
            try
            {
                return db.Users.OrderBy(u => u.LastName)
                               .ToList();
            }
            catch
            {
                throw;
            }

        }

        //this method will add a new user 
        public int CreateUser(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }


        }
        //this method will update the existing user record    
        public int UpdateUser(int id, User user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }

        }
        //this method will get detail of a specific user
        public User GetUserData(int id)
        {
            try
            {
                User user = db.Users.Find(id);
                return user;
            }
            catch
            {
                throw;
            }

        }
        //this method will delete the specifig user record    
        public int DeleteUser(int id)
        {
            try
            {
                User emp = db.Users.Find(id);
                db.Users.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }

        }

    }
}
