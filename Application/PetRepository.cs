using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Domain;

namespace Application
{
    public class PetRepository : ISubscriber
    {
        List<Pet> pets = new List<Pet>();
        public void Update(IPublisher publisher, string message)
        {
            
        }
    }
}
