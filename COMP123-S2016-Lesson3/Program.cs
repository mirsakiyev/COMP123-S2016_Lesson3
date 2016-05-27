using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Lab-Assignment #2
 * Author : Aslan Mirsakiyev
 * Student ID : 300850326
 * Date : 27.05.2016
 * Submitted to : Tom Tsiliopoulos
 * GitHub link : https://github.com/mirsakiyev/COMP123-S2016_Lesson3.git
 *
 * Instructions:
 *
 *      1) Create a Program that defines a simple Person class.
 *      2) Ensure the Person class is defined in a separate file.
 *      3) The Person class should include the following private instance variables:
 *           * name {string}
 *           * age {int}
 *
 *      4) The Person class should include the following public property:
 *           * Name
 *
 *      5) The Person class should include the following public methods:
 *              * SaysHello - this method should print the private name value and then 
 *                "says hello" to the console. (e.g. if the private name value is
 *                "Tom" then when the SayHello method is called it should output "Tom 
 *                 says hello" to the console).
 *
 *              * ShowAge - this method should print the private name value followed by
 *                 "is" and then the private age value followed by "years old" to the console 
 *                  (e.g. if the private name value is "Tom" and the private age value is "47" then 
 *                  when the ShowAge method is called it should output "Tom is 47 years old" to the console).
 *
 *      6) Ensure that all private Instance Variables start with an underscore character (_).
 *      7) Ensure that all public Properties and Methods start with a Capital letter.
 *      8) A new person object will be created in the "driver" class named Program.
 *      9) The person object will call its SayHello method.
 *      10) The person object will then call its ShowAge method.
 *
*/

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
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            string separator = "-------------------------------------";

            //----------------------------------------------------------------------------------------------
            //----------------Create a new instance(rick) of the Person class-------------------------------
            //----------------------------------------------------------------------------------------------
            Person rick = new Person();
            rick.Name = "Rick";
            rick.Age = 40;
            rick.SaysHello();
            rick.ShowAge();

            Console.WriteLine(separator);

            //----------------------------------------------------------------------------------------------
            //----------------Create a new instance(daryl) of the Person class------------------------------
            //----------------------------------------------------------------------------------------------
            Person daryl = new Person("Daryl");
            daryl.Age = 39;
            daryl.SaysHello();
            daryl.ShowAge();

            Console.WriteLine(separator);

            //----------------------------------------------------------------------------------------------
            //----------------Create a new instance(carl) of the Person class-------------------------------
            //----------------------------------------------------------------------------------------------
            Person carl = new Person(16);
            carl.Name = "Carl";
            carl.SaysHello();
            carl.ShowAge();

            Console.WriteLine(separator);

            //----------------------------------------------------------------------------------------------
            //----------------Create a new instance(negan) of the Person class------------------------------
            //----------------------------------------------------------------------------------------------
            Person negan = new Person("Negan", 41);
            negan.SaysHello();
            negan.ShowAge();

            Console.WriteLine(separator);

            //----------------------------------------------------------------------------------------------
            //-------------Create a new instance(unknownPerson) of the Person class-------------------------
            //----------------------------------------------------------------------------------------------
            Person unknownPerson = new Person(25);
            unknownPerson.SaysHello();
            unknownPerson.ShowAge();

            Console.WriteLine(separator);
        }
    }
}
