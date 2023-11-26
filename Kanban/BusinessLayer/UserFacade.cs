using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BusinessLayer
{
    internal class UserFacade
    {
        Dictionary<string, User> users; // string = email
        public UserFacade() { users = new Dictionary<string, User>(); }
        public void Register(string email, string password)
        {
            if(email == null)
                throw new ArgumentNullException("e-mail is null");
            if(password == null)
                throw new ArgumentNullException("password is null");
            if (!email.Contains('@'))
                throw new ArgumentException("email is invalid");
            if (users.Keys.Contains(email))
                throw new Exception("e-mail is already exists");
            users.Add(email, new User(email, password));
            Login(email, password);
        }
        public void Login(string email, string password)
        {
           if (email == null)
              throw new ArgumentNullException("e-mail is null");
            if (!users.ContainsKey(email))
                throw new Exception("e-mail does not exists in the system");
            users[email].Login(password);
        }
        public List<Task> InProgressTasks(string email)
        {
            throw new NotImplementedException();
        }
        public void Logout(string email)
        {

        }
        public User GetUser(string s)
        {
            throw new NotImplementedException();
        }
    }
}
