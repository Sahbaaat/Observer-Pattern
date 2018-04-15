using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise3
{
    class Alarm : Observer
    {
        string sound;
        public Alarm(string s)
        {
            sound = s;
        }
        public void Update()
        {
            Console.WriteLine("Alarm : {0}", sound);
        }
    }
}
