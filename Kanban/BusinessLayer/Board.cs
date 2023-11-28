using Kanban.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Kanban.BusinessLayer.Task;

namespace Backend.BusinessLayer
{
    internal class Board
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public List<Column> columns { get; private set; }
        private User owner;
        private List<User> members;

        public void AddTask(Task task)
        {
            if (task == null)
                throw new ArgumentNullException("task is null");
            columns[0].AddTask(task);
        }
        public void AddMember(User user)
        {  
            if (user == null) 
                throw new ArgumentNullException("user is null");
            members.Add(user);
        }
        public void RemoveMember(User member)
        {
            if (!IsMember(member))
                throw new ArgumentException("the user is not member of the board");
            members.Remove(member);
        }
        
        private bool IsMember(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user in null");
            return members.Contains(user);
        }
        public  void TransferOwnerShip(User user)
        {
            if (!IsMember(user))
                throw new ArgumentException("The potential user is not a memeber of this board");
            if (user.Equals(owner))
                throw new Exception("The user is already an Owner");
            owner = user;
        }
        public void AdvanceTask(int taskId, int colId)
        {

        }
        public Column GetColumn(int columnId)
        {
            return columns[columnId];   
        }
        public Task GetTask(int taskId)
        {
            
        }
    }
}
