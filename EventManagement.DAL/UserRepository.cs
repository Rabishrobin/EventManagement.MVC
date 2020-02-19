
using System.Collections.Generic;
using EventManagement.Entity;
namespace EventManagement.DAL
{
    public class UserRepository
    {
        public static List<UserDetails> userList = new List<UserDetails>();
        public void AddUserDetails(UserDetails user)
        {
            userList.Add(user);
        }
    }
}
