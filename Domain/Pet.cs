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

        private string _name;
        public string Name {
            get { return _name; }
            set { _name = value; NotifySubscribers("Name"); } //kalder notify og giver den et parameter. Her "Name"
        }

        private string _type;
        public string Type {
            get { return _type; }
            set { _type = value; NotifySubscribers("Type"); }
        }

        private string _breed;
        public string Breed {
            get { return _breed; }
            set {  _breed = value; NotifySubscribers("Breed"); }
        }

        private string _dob;
        public string DOB {
            get { return _dob; }
            set { _dob = value; NotifySubscribers("DOB"); }
        }

        private string _weight;
        public string Weight {
            get { return _weight; }
            set { _weight = value; NotifySubscribers("Weight"); }
        }

        public Pet(string name, string type, string breed, string dOB, string weight)
        {
            Name = name;
            Type = type;
            Breed = breed;
            DOB = dOB;
            Weight = weight;
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
    }
}
