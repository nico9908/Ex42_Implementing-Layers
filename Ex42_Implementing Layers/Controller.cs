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

        public void InsertPet()
        {
            Pet pet = new Pet { };
            DBC.InsertPet(pet);
        }

        public void InsertOwner()
        {
            Owner owner = new Owner {  };
            DBC.InsertOwner(owner);
        }

        public void ShowPets()
        {
            DBC.ShowPets();
        }

        public void FindOwnerByLastName(string lastName)
        {
            DBC.FindOwnerByLastName(lastName);
        }

        public void FindOwnerByEmail(string email, string name)
        {
            DBC.FindOwnerByEmail(email, name);
        }
    }
}
