using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light1 = new Light("red");
            Light light2 = new Light("green");
            Alarm alarm1 = new Alarm("beep");
            Alarm alarm2 = new Alarm("beez");

            Thermometr thermometr = new Thermometr();
            thermometr.registerobserver(alarm1);
            thermometr.registerobserver(alarm2);
            thermometr.registerobserver(light1);
            thermometr.registerobserver(light2);
            int treshold;
            Console.WriteLine("Enter treshold: ");
            treshold = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                thermometr.createrandtemp(treshold);
            }
            Console.ReadKey();
        }
    }
}
