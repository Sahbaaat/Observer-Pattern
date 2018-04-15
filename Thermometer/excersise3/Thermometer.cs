using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise3
{
    class Thermometr : Subject
    {

        Random rndm = new Random();

        public void createrandtemp(int treshold)
        {
            int temp =rndm.Next(0, 300);
            Console.WriteLine("random tempreture is : {0}", temp);
            if (temp > treshold)
                notifyobserver();
            else
                Console.WriteLine("No Problem!");

        }

    }
}
