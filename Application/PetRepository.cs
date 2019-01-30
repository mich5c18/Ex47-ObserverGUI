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
        private List<ISubscriber> observers = new List<ISubscriber>(); //Liste af subscribers

        List<Pet> pets = new List<Pet>(); //Liste af Pets

        public void AddPet(string name, string type, string breed, string dOB, string weight)
        {
            Pet pet = new Pet(name, type, breed, dOB, weight); //Laver en instans af Pet
            pets.Add(pet); //Tilføjer pet til listen af Pets
            pet.RegisterSubscriber(this); //Bliver til en subscriber til pet
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
