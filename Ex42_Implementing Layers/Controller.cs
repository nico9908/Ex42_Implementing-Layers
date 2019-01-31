using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42_Implementing_Layers
{
    public class Controller
    {
        Database_Controller DBC = new Database_Controller();
        public void InsertPet(string name, string type, string breed, string dob, string weight, string ownerId)
        {
            Pet pet = new Pet { name = name}
            DBC.InsertPet();
        }
    }
}
