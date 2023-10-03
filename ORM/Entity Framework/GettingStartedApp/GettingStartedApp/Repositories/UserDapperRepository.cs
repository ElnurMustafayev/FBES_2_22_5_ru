using GettingStartedApp.Entities;
using GettingStartedApp.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedApp.Repositories
{
    public class UserDapperRepository : IUserRepository
    {
        public User Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
