using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    /**
     * This class defines a generic Person
     *
     * @class Person
     * @field _name {string}
     */
    public class Person
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _name;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * This is a property for our _name field
         * @property {string} Name
         */
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /**
         * This is default empty constructor for the Person class
         * 
         * @constructor Person
        */
        
        public Person()
        {
            this._name = "unknown name";
        }

        /**
        * This is the constructor that takes name as a parameter and passes 
        * it to the _name private instance variable
        * 
        * @constructor Person
        * @param {string} name
       */
        public Person(string name)
        {
            this._name = name;
        }
    }
}
