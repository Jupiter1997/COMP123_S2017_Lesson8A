using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Marvin Jupiter Vargas
 * Date: July 11, 2017
 * Description: Abstarct Class Human which other sub class will derived from
 * Version 0.1 Instantiate an object type of super human
 * */
namespace COMP123_S2017_Lesson8A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhuman = new SuperHuman("Damn Man");
            superhuman.Powers.Add(new Power("KAMEHAMEHA!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!",90000));
            superhuman.Powers.Add(new Power("Haduken", 60));
            Console.WriteLine(superhuman.ToString());
            Console.WriteLine("Karma: ");


         

            SuperVillain supervillain = new SuperVillain("Uncanny Canadian", 86);
            supervillain.AddPower("Axe Hand", 39);
            supervillain.AddPower("Lumberjack Spirit", 15);
            Console.WriteLine(supervillain.ToString());
            Console.WriteLine("Malice: " + supervillain.Malice);

            if (supervillain is IHasMalice)
            {
                Console.WriteLine("Im Awesome");
            }
        }

    }
}
