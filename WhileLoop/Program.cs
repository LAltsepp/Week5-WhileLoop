using System;

namespace WhileLoop
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

            //boolean --> true/false
            bool loopactive = true;

            while (loopactive)
            {
                Console.WriteLine("Sisesta PIN-kood");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopactive = false;
                }
                else
                {
                    Console.WriteLine("Vale PIN mees, proovi veel, ma usun sinusse!");
                }
            }


            Console.WriteLine("Kena päeva!");
            






        }
    }
}
