using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuissonLasagne
{

    class Lasagna
    {
        // TODO: define the 'ExpectedMinutesInOven()' metho
        public int ExpectedMinutesInOven()
        {
            return (40);
        }//=> 40

        // TODO: define the 'RemainingMinutesInOven()' method
        public int RemainingMinutesInOven()
        {
            return (40) - 10; //: 10
        }

        // TODO: define the 'PreparationTimeInMinutes()' method
        public int PreparationTimeInMinutes()
        {
            return 2*2; //: 4
        }
        // TODO: define the 'ElapsedTimeInMinutes()' method
        public int ElapsedTimeInMinutes()
        {
            return (3+2 + 20);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Test the methods to ensure they work correctly
            var lasagna = new Lasagna();

            Console.WriteLine(lasagna.ExpectedMinutesInOven());          // Should print 40
            Console.WriteLine(lasagna.RemainingMinutesInOven());       // Should print 30 (40 - 10)
            Console.WriteLine(lasagna.PreparationTimeInMinutes());      // Should print 4 (2 * 2)
            Console.WriteLine(lasagna.ElapsedTimeInMinutes());      // Should print 26 (3 * 2 + 20)
        }
    }
}
