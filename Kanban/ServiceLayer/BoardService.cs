using Kanban.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.ServiceLayer
{
    internal class BoardService
    {
        private BoardFacade boardFacade;
        public string CreateBoard(string userEmail, string boardName)
        {
            throw new NotImplementedException();
        }
        public string DeleteBoard(string userEmail, int boardId)
        {
            throw new NotImplementedException();
        }
        public string JoinBoard(string userEmail, int boardId)
        {
            throw new NotImplementedException();
        }
        public string LeaveBoard(string userEmail, int boardId)
        {
            throw new NotImplementedException();
        }
        public string TransferOwnership(int boardId, string newOwnerEmail)
        {
            throw new NotImplementedException();
        }
    }
}
