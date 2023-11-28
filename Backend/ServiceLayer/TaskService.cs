using Kanban.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.ServiceLayer
{
    internal class TaskService
    {
        private TaskFacade taskFacade;
        public string SetDueDate(int taskId, string userEmail, string boardName, string newDate)
        {
            throw new NotImplementedException();
        }
        public string SetTitle(int taskId, string userEmail, string boardName, string newTitle)
        {
            throw new NotImplementedException();
        }
        public string SetDescription(int taskId, string userEmail, string boardName, string newDescription)
        {
            throw new NotImplementedException();
        }
        public string GetTaskInColumn(string userEmail, string boardName, int coldId)
        {
            throw new NotImplementedException();
        }
        public string AddTask(string userEmail, int boardId, string title, string description, DateTime dueDate)
        {
            throw new NotImplementedException();
        }
        public string AdvanceTask(int taskId, string userEmail, string boardName, int colId)
        {
            throw new NotImplementedException();
        }
    }
}
