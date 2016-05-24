using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    /**
     * This class is the driver class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * The main method for our driver class Program
         *
         * @method Main
         * @param {strinf[]} args
         */
        public static void Main(string[] args)
        {
            // Create a new instance of the Person class
            Person person = new Person("Aslan");

            Console.WriteLine(person.Name);

            // Set a value in the Name property of the Person class
            //person.Name = "Aslan";

            // Get the Name value and print to console
            Console.WriteLine(person.Name);

        }
    }
}
