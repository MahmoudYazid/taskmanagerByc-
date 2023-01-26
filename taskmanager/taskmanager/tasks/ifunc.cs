using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskmanager.tasks
{
    internal interface ifunc
    {
        public tasksClass findById(int id);
        public tasksClass findByName(string Name);
        public List<tasksClass> showall();

        public void AddTasks(string name, string desc);

        public void DeleteTasks(int id);
        public void ModifyDesc(int id,string desc);
        public void ModifyName(int id, string Name);






    }
}
