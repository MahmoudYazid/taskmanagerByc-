using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskmanager.tasks
{

    internal class VariablesClass
    {
        public Boolean Start_counter = true;
        public string AddOrder="add";
        public string FindByIdOrder="find by id";
        public string FindByNameOrder= "find by name";
        public string deleteOrder= "delete";
        public string ShowAllOrder = "showall";
        public string ModificationNameOrder = "mod name";
        public string ModificatonDescriptionOrder = "mod desc";
        public string Showorders = "orders";
        public string Clearorder= "clear";
        List<string> Orders= new List<string>();
        public void ShowOrdersFunc() { 
            foreach(var or in Orders)
            {
                Console.WriteLine(or);
            }
        
        
        
        }
        public VariablesClass()
        {

            Orders.Add(AddOrder);
            Orders.Add(FindByIdOrder);
            Orders.Add(FindByNameOrder);
            Orders.Add(deleteOrder);
            Orders.Add(ShowAllOrder);
            Orders.Add(ModificatonDescriptionOrder);
            Orders.Add(ModificationNameOrder);

            






        }




    }
}
