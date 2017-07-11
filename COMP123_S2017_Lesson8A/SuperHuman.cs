using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter Vargas
 * Date: July 11, 2017
 * Description:This is a super Human sub class
 * Version: 0.2 - Added Private Initialize Method
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
    }
}