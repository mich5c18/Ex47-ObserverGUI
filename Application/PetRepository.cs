using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Domain;

namespace Application
{
    public class PetRepository : ISubscriber, IPublisher
    {
        private List<ISubscriber> observers = new List<ISubscriber>();

        List<Pet> pets = new List<Pet>();

        public void AddPet(string name, string type, string breed, string dOB, string weight)
        {
            Pet pet = new Pet(name, type, breed, dOB, weight);
            pets.Add(pet);
            pet.RegisterSubscriber(this);
        }

        public void RegisterSubscriber(ISubscriber o)
        {
            observers.Add(o);
        }

        public void RemoveSubscriber(ISubscriber o)
        {
            observers.Remove(o);
        }

        public void NotifySubscribers(string message)
        {
            foreach (ISubscriber o in observers)
            {
                o.Update(this, message);
            }
        }

        public void Update(IPublisher publisher, string message)
        {
            
        }
    }
}
