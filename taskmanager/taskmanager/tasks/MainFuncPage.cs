using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace taskmanager.tasks
{
    internal class MainFuncPage : ifunc
    {
        List<tasksClass> tasksArr = new List<tasksClass>()
        {
            new tasksClass { Id=0,Name="test",Description="test"}

        };

        public void AddTasks(string Name_, string des_){

            Console.WriteLine("no of count:   " +tasksArr.Count());           
            tasksClass new_task = new tasksClass() { Id = tasksArr.Count(), Description = des_, Name = Name_ };
            tasksArr.Add(new_task);
        }

        public void DeleteTasks(int id)
        {
            var find = tasksArr.SingleOrDefault(x => x.Id == id);
            
            tasksArr.Remove(find);


        }

        public tasksClass findById(int id)
        {
            var k = tasksArr.SingleOrDefault(x => x.Id == id);
            Console.WriteLine("name :"+" "+ k.Name);
            Console.WriteLine(" ");

            Console.WriteLine("desc:" +" "+k.Description);

            return k;
            




        }

        public tasksClass findByName(string Name_)
        {
            var k = tasksArr.SingleOrDefault(x => x.Name == Name_);
            Console.WriteLine("name :" + " " + k.Name);
            Console.WriteLine(" ");

            Console.WriteLine("desc:" + " " + k.Description);
            return k ;
        }

        public void ModifyDesc(int id, string desc)
        {
            var Wanted_modified = tasksArr.SingleOrDefault(x => x.Id == id);
            Wanted_modified.Description= desc;

        }

        public void ModifyName(int id, string Name)
        {
            var Wanted_modified = tasksArr.SingleOrDefault(x => x.Id == id);
            Wanted_modified.Name = Name;

        }

        public List<tasksClass> showall()
        {
            var list = tasksArr.ToList();
            foreach (var task in list)
            {
                Console.WriteLine("id:" + " " + task.Id);
                Console.WriteLine("name:"+" "+task.Name);
                Console.WriteLine("desc:"+" "+task.Description);
                Console.WriteLine("--------------------------------");

            }
            return tasksArr;
        }

        
    }
}
