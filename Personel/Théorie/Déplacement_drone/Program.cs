using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Déplacement_drone
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            const int delay = 100;
            int posx = 0;
            const int posy = 10;
            var battery = 50;
            string drone = "x-0-x";

            while (battery > 0)
            {
                await Task.Delay(delay);
                Console.Clear();
                Console.SetCursorPosition(posx, posy);
                Console.Write(drone);
                posx += 1;
                battery -= 2;
            }
            Console.Clear();
            Console.SetCursorPosition(posx, posy);
            drone = "___";
            Console.Write(drone);
            Console.ReadKey();
        }
    }
}
