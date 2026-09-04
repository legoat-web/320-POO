using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Déplacement_drone
{
    internal class Drone
    {
        private string _modelA = "x-0-x";
        private string _modelD = "_____";
        private int _posx;
        private int _posy;
        public int _battery;
        
        public Drone(int posx, int posy, int battery)
        {
            _posx = posx;
            _posy = posy;
            _battery = battery;
        }

        public void ChangeState(ref int _posx, ref int _battery)
        {
            _posx += 1;
            _battery -= 2;
        }

        public void Draw(int _posx, int _posy, int _battery, string _modelA, string _modelD)
        {
            Console.Clear();
            Console.SetCursorPosition(_posx, _posy);

            if (_battery > 0)
                Console.Write(_modelA);

            else  
                Console.Write(_modelD);
        
            Console.SetCursorPosition(_posx +1, _posy -1);

            if(_battery > 0)
                Console.Write($"{_battery}%");

            Thread.Sleep(200);
        }

        public void Ending()
        {
            Console.Clear();
            Console.SetCursorPosition(_posx, _posy);
            Console.Write("MORT");
            Thread.Sleep(1000);
        }

    
        public void Execute()
        {
            while(_battery > 0)
            {
                ChangeState(ref _posx, ref _battery);
                Draw(_posx, _posy, _battery, _modelA, _modelD);
            }
            Ending();
        }
    }
}


//}

//    
//

//static void Ending(ref string drone, int posx1, int posy1)
//{
//    Console.Clear();
//    Console.SetCursorPosition(posx1, posy1);
//    drone = "____";
//    Console.Write(drone);

//    Thread.Sleep(500);
//    Console.SetCursorPosition(posx1, posy1);
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("/!\\ MORT /!\\");
//    Console.ResetColor();
