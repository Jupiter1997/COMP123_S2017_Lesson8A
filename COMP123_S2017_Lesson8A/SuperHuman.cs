using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter Vargas
 * Date: July 11, 2017
 * Description:This is a super Human sub class
 * Version: 0.6 - modify to string method to strong to a space
 * */
namespace COMP123_S2017_Lesson8A
{
    /// <summary>
    /// SuperHuman  Subclass 
    /// It inherits from the Human Super Class
    /// </summary>
    public class SuperHuman : Humans
    {
        //PRIVATE FIELDS(INSTANCE VARIABLES)
        private List<Power> _powers;
        //PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return _powers;
            }
        }
        //CONSTRUSTERS--->

        public SuperHuman(string name)
            :base(name)
        {
            this._initialize();
        }
        //PRIVATE METHODS
        /// <summary>
        /// this method initialize and assign values to list
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }
        //PUBLIC Methods
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        public void DisplayPowers()
        {
            foreach (var power in Powers)
            {
                Console.WriteLine("{0} {1}",power.Name,power.Rank);
            }
        }
        /// <summary>
        /// The ToString method overrides the built-in Object.ToString method
        /// it outputs a string that displays the super human's name and power
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n";
            outputString += "Super Human Name:" + this.Name + "\n";
            outputString += "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n";
                foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Rank + "\n"; 
            }
            outputString += "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n";
            return outputString;
        }
    }
   
}