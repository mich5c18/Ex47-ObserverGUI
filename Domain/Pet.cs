using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pet : IPublisher
    {
        private List<IObserver> observers = new List<IObserver>();


        public Pet(string name, string type, string breed, string dob, float weight, int ownerID)
        {

        }

        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (PetRepo p in observers)
            {
                p.Update();
            }
        }
    }
}
