using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter Vargas
 * Date: July 11, 2017
 * Description:This is a new Power Data type
 * Version: 0.2 - Add a custom Constructer
 * */
namespace COMP123_S2017_Lesson8A
{

    /// <summary>
    /// The power SuperClass contains the Data and structure of each super Power
    /// </summary>
    public class Power
    {
        //PUBLIC CONTRUCTER
       
        public string Name { get; set; }
        public int Rank { get; set; }
        /// <summary>
        /// takes two parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
        //Overloaded Methods
        /// <summary>
        /// This method overloads the > operator for the power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Return the Power that is greater</returns>
        public static Power operator > (Power lhs, Power rhs)
        {

            return (lhs.Rank > rhs.Rank) ? lhs : rhs;
        }
        /// <summary>
        /// This method overloads the < operator for the power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Return the Power that is greater</returns>
        public static Power operator < (Power lhs, Power rhs)
        {
            return (lhs.Rank < rhs.Rank) ? lhs : rhs;
        }
    }
}