using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Kanban.BusinessLayer
{
    internal class Column
    {
        public string name { get; private set; }
        public int Limit 
        {
            get{ return limit;}
            set
            {
                if (value < -1)
                    throw new ArgumentException("Limit is negative");
                if (value == 0)
                    throw new ArgumentException("limit must not be zero");
                this.limit = value;
            }
        }
        private int limit;
        private List<Task> tasks;
        public void AddTask(Task task)
        {
            if (task == null)
                throw new ArgumentNullException("task in null");
            tasks.Add(task);
        }
        public void RemoveTask(int taskid)
        {
            tasks.Remove(GetTask(taskid));
        }
        public Task GetTask(int taskId)
        {
            if (taskId < 0)
                throw new ArgumentException("TaskId is negative");
            Task task = tasks.Find(t => t.id == taskId);
            if (task == null)
                throw new ArgumentException("Task not found");
            return task;
        }         
    }
}
