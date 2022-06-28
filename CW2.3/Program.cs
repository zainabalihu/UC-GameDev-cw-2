using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double playerSpeed1 = 5.6, playerSpeed2 = 2.5;
            double playerSpeed3 = (playerSpeed1 + playerSpeed2);
            
            void playerSpeed ()
            {
                Console.WriteLine("player speed 1 is " + playerSpeed1 + " player speed 2 is" + playerSpeed3);
            }

            playerSpeed();
            playerSpeed();
            playerSpeed();

        }


    }
}
