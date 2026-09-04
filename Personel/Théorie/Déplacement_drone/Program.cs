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
            Console.CursorVisible = false;

            Drone[] drones =
            {
                 new Drone(0, 20, 50),
                 new Drone(3, 6, 70)
            };

        }
    }
}
