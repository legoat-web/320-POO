using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Déplacement_drone
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            const int delay = 100;
            const int posy1 = 10;
            const int posy2 = 20;

            int posx1 = 0;
            int posx2 = 0;

            var battery1 = 50;
            var battery2 = 50;

            string drone = "x-0-x";

            while (battery1 > 0)
            {
                await Task.Delay(delay);
                Movedrone(delay, ref posx1);
                Movedrone(delay, ref posx2);

                Removebattery1(ref battery1);
                Removebattery1(ref battery2);

                Show(drone, posx1, posy1);
                Show(drone, posx2, posy2);
            }
            Ending(ref drone, posx1, posy1);
            Ending(ref drone, posx2, posy2); // A VERIFIER CAR LA FIN NE MARCHE PAS
        }

        static void Movedrone(int delay, ref int posx1)
        {
            Console.Clear();
            posx1 += 1;
        }

        static void Removebattery1(ref int battery1)
        {
            battery1 -= 2;
        }
        static void Show(string drone, int posx1, int posy1)
        {
            Console.SetCursorPosition(posx1, posy1);
            Console.Write(drone);
        }

        static void Ending(ref string drone, int posx1, int posy1)
        {
            Console.Clear();
            Console.SetCursorPosition(posx1, posy1);
            drone = "____";
            Console.Write(drone);

            Thread.Sleep(500);
            Console.SetCursorPosition(posx1, posy1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("/!\\ MORT /!\\");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
