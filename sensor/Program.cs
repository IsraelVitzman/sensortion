using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Activate game = new Activate();
            game.StartGame();

            
            Console.WriteLine("םינימז םינשייח: Audio, Thermal, Pulse, Motion, Magnetic, Signal, Light");

            while (true)
            {
                Console.WriteLine("ןשייח םש סנכה:");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    continue;

                game.FindAgent(input);

                Console.WriteLine("להמשך Enter,  'exit' ליציאה");
                string continueGame = Console.ReadLine();
                if (continueGame?.ToLower() == "exit")
                    break;
            }
        }
    }
 }
    

