using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter Vargas
 * Date: July 11, 2017
 * Description: Abstarct Class Human which other sub class will derived from
 * 
 * */
namespace COMP123_S2017_Lesson8A
{
    /// <summary>
    /// This is the Human Abstarct Class
    /// </summary>
    public abstract class Humans
    {
        //PRIVATE FIELDS(INSTANCE VARIABLES)
        private string _name;

        //PUBLIC PROPERTIES
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        //CONSTRUSTERS--->
        public Humans(string name)
        {
            this.Name = name;
        }
    }
}