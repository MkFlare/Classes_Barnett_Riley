using System;

namespace Classes_Barnett_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="name"></param>
            Greetings greetings = new Greetings();
            //
            greetings.Welcome();
            Console.WriteLine("What is your name squire?");
            string userName = Console.ReadLine();

            //
            greetings.Hello("Morgan");

        }
    }
}
