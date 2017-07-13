using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Marvin Jupiter Vargas
 * Date: July 13, 2017
 * Description: this is the SuperVillain Class
 * Version: 0.11 - added a constructer
 */
namespace COMP123_S2017_Lesson8A
{
    public class SuperVillain : SuperHuman
    {
        //PRIVATE INSTANCE VARIABLE 
        private int _malice;
        //PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }
        /// <summary>
        /// This is the constructer that sets up supervillain 
        ///it take two argument name and malice 
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>
        //CONSTRUCTERS
        public SuperVillain(string name, int malice)
            :base(name)
        {
            this.Malice = malice;
        }
        //PRIVATE METHODS

        //PUBLIC METHODS

    }

}