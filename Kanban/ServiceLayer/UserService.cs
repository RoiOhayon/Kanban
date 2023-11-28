using Kanban.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.ServiceLayer
{
    internal class UserService
    {
        private UserFacade userFacade;
        public UserService() { }
        public string Register(string email, string password)
        {
            throw new NotImplementedException();
        }
        public string Login(string email, string password)
        {
            throw new NotImplementedException();
        }
        public string LogOut(string email)
        {
            throw new NotImplementedException();
        }
        public string InProgressTasks(string email)
        {
            throw new NotImplementedException();
        }
    }
}
