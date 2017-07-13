using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Marvin Jupiter Vargas
 * Date: July 13, 2017
 * Description: This Interface list the signature for any super hero subclass
 * Version: 0.1 - Karma property
 * */
namespace COMP123_S2017_Lesson8A
{
    public interface IHasKarma
    {              
        //PUBLIC PROPERTIES
        int Karma { get; set; }
    }
}