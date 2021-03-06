﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter Vargas
 * Date: July 11, 2017
 * Description:This is a super Human sub class
 * Version: 0.9 - override void display skills
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
        /// <summary>
        /// This private returnd the index of the power if found
        /// ifnot found returns -1
        /// </summary>
        /// <param name="name"></param>
        /// <returns>This returns a n interher related to index</returns>
        private int _findPower(string name)
        {
            int index = 0;
            foreach (Power power in this.Powers)
            {
                if (name.Equals(power.Name))
                {
                    break;
                }
                index++;
                if (this.Powers.Count == index )
                {
                    index = -1;
                }
                
            }
            return index;
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
        /// <summary>
        /// This method overrides the human abstarct superclass Display Method 
        /// this method will dispay a list of skills
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }

       
    }
   
}