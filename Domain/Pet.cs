using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace Domain
{
    public class Pet : IPublisher
    {
        private List<ISubscriber> observers = new List<ISubscriber>();


        public Pet(string name, string type, string breed, string dob, float weight, int ownerID)
        {

        }

        public void Attach(ISubscriber o)
        {
            observers.Add(o);
        }

        public void Detach(ISubscriber o)
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
