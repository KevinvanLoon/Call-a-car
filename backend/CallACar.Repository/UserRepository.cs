using System;
using CallACarr.Domain;

namespace CallACar.Repository
{
    public class UserRepository : AbstractRepository<User>
    {
        public void UpdatePassword(int userId, string password)
        {
            throw new NotImplementedException();
        }
    }
}