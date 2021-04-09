using System;
using System.Linq;
using CallACarr.Domain;

namespace CallACar.Repository
{
    public class UserRepository : AbstractRepository<User>
    {
        public UserRepository(){
            Entities = DatabaseMock.Users.ToList();
        }
        
        public void UpdatePassword(int userId, string password)
        {
            throw new NotImplementedException();
        }
    }
}