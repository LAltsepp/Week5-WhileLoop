using System;

namespace PINValidationThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada pin koodi
            //programm võrdleb pin koodi arvuga 1234
            //kui sisestatud pin kood on 1234,
            //programm kuvab kondoolis "tere tulemast"
            //kui sisustatud pin kood on vale, programm kuvab konsooli,
            //"vale pin proovi uuesti"
            //katsete arv on piiramatu

            Console.WriteLine("Sisesta oma PIN-kood");

            int userPIN = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < 3)
            if (userPIN == 1234)
            {
                Console.WriteLine("Norm PIN");
                    break;
            }
            else
            {
                Console.WriteLine("Ei ole norm PIN");
                    break;
            }


        }
    }
}
