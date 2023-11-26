using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.BusinessLayer
{
    internal class User
    {
        private const int lower_bound = 6;
        private const int upper_bound = 20;
        private string email;
        public string Email 
        {
            get { return email; }
            set { email = value; }
        }
        private string password;
        public string Password 
        {
            private get { return password; }
            set {
                if (!isValidPassword(password))
                    throw new ArgumentException("Password is not valid");
                password = value;
                }
        }
        private bool isLoggedIn;
        private bool isValidPassword(string password)
        {
            if(password.Length < lower_bound || password.Length > upper_bound)
                return false;
            if (password.Equals(password.ToLower()) || password.Equals(password.ToUpper()))
                return false;
            string numbers = "0123456789";
            if (numbers.Any(x => password.Contains(x))
                return true;
            return false;
        }

        public void Login(string password)
        {
            if (password == null)
                throw new ArgumentNullException("Password is null!");
            else if (!this.password.Equals(password))
                throw new ArgumentException("Password incorrect!");
            else if (isLoggedIn)
                throw new Exception("User already logged in");
            else 
                isLoggedIn = true;
        }
        public void Logout() 
        {
            if (!isLoggedIn)
                throw new Exception("User is not logged in");
            isLoggedIn = false;
        }
    }
}
