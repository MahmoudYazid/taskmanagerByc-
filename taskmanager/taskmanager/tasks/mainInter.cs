using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace taskmanager.tasks
{
    internal class mainInter:MainFuncPage
    {
        public static void Main(string[] args)
        {
            MainFuncPage new_func = new MainFuncPage();
            VariablesClass NEWVar2= new VariablesClass();
            while (NEWVar2.Start_counter)
            {
                Console.WriteLine("---------------WriteOrders---------------");
                string Input = Console.ReadLine();
                
                Console.Clear();
                
                if (Input == NEWVar2.Showorders) { NEWVar2.ShowOrdersFunc(); }

                if (Input==NEWVar2.AddOrder) {
                    Console.WriteLine("Write name");
                    string InputName = Console.ReadLine();
                    Console.WriteLine("Write describe");
                    string Inputdes = Console.ReadLine();
                    new_func.AddTasks(InputName, Inputdes);
                    
                } 
                   

                if (Input==NEWVar2.FindByIdOrder) {
                    Console.Write("Write id");
                    string wanted_id = Console.ReadLine();
                    new_func.findById(Convert.ToInt32(wanted_id));


                }
    
                if (Input==NEWVar2.FindByNameOrder) {
                    Console.Write("Write name");
                    string wanted_name = Console.ReadLine();
                    new_func.findByName(wanted_name);


                }
                
                    
                
                if (Input==NEWVar2.deleteOrder) {
                    Console.Write("Write id");
                    string del_id = Console.ReadLine();
                    new_func.DeleteTasks(Convert.ToInt32(del_id));

                    
                } 
                    

                if (Input==NEWVar2.ShowAllOrder) {
                    new_func.showall();
                    

                }
                if (Input == NEWVar2.Clearorder)
                {
                    Console.Clear();


                }
                if (Input==NEWVar2.ModificationNameOrder) {
                    Console.Write("Write id");
                    string id = Console.ReadLine();
                    Console.WriteLine("Write new name");
                    string MOD_NAME = Console.ReadLine();
                    new_func.ModifyName(Convert.ToInt32(id), MOD_NAME);
                   


                } 

                if (Input==NEWVar2.ModificatonDescriptionOrder) {
                    Console.Write("Write id");
                    string wantedid = Console.ReadLine();
                    Console.WriteLine("Write new desc");
                    string MOD_desc = Console.ReadLine();

                    new_func.ModifyDesc(Convert.ToInt32(wantedid), MOD_desc);
                    
                }
                    
                


            }
        }
    }
}
