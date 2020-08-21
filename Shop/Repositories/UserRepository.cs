using System.Collections.Generic;
using Shop.Models;
using System.Linq;

namespace Shop.Repositories {

   public static class UserRepository {

      public static User Get(string username, string password){

         var users = new List<User>();
         users.Add(new User { Id = 1, Username = "User 1", Password = "123456", Role = "manager" });
         users.Add(new User { Id = 1, Username = "User 2", Password = "123456", Role = "employee" });

         return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();

      }

   }

}