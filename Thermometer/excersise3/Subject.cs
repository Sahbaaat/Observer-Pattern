using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise3
{
    abstract class Subject
    {
        List<Observer> observers = new List<Observer>();
        public void registerobserver(Observer o)
        {
            observers.Add(o);
        }
        public void unregisterobserver(Observer o)
        {
            observers.Remove(o);
        }
        public void notifyobserver()
        {
            foreach (Observer o in observers)
                o.Update();

        }
    }
}
