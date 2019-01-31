using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42_Implementing_Layers
{
   class Program
    {
        Menu menu = new Menu();
        static void Main(string[] args)
        {
            Program pro = new Ex42_Implementing_Layers.Program();
            pro.Run();
        }
        private void Run()
        {
            menu.RunMenu();
        }
    }
}
