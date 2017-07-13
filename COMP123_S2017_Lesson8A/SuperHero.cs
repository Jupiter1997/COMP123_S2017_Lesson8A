using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter Vargas
 * Date: July 13, 2017
 * Description: Super heror class which inherits from superhuman class
 * Version: 0.7 - override void display skills
 * */
namespace COMP123_S2017_Lesson8A
{
    /// <summary>
    /// this is the superhero class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        //PRIVATE INSTANCE VARIABLE 
        private int _karma;
        //PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }

        //CONSTRUCTERS
        /// <summary>
        /// This is the main constructer for the super hero class
        /// it takes two argument name(string) and karma(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        public SuperHero(string name, int karma)
            :base(name)
        {
            this.Karma = karma;
        }
        //PRIVATE METHODS
        
        //PUBLIC METHODS
         
    }
}