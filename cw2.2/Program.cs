using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String heroName = "Jimmy", villainName = "Simon";
            int heroPower = 1500, villainPower = 1600;

            Console.WriteLine("The strongest is");

            if (heroPower > villainPower)
            {
                Console.WriteLine(" Jimmy ");
            }
            
            else if ( heroPower == villainPower )

            {
                Console.WriteLine(" Thy have the same power "); 
            }
            
            else 
            {
                Console.WriteLine(" simon ");
            }

            

                double playerSpeed1 = 5.6, playerSpeed2 = 2.5;
                double playerSpeed = (playerSpeed1 + playerSpeed2);

            void playerspeed() 
            { 
            
                Console.WriteLine(" player speed 1 is " + playerSpeed1 + " player speed 2 is " + playerSpeed2 );
            }

            playerspeed();
            playerspeed();




























        }
    }
}
