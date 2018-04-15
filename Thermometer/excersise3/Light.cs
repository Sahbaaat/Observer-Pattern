using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise3
{
    class Light : Observer
    {
        string color;
        public Light(string s)
        {
            color = s;
        }
        public void Update()
        {
            Console.WriteLine( "Light : {0}",color);
        }
    }
}
