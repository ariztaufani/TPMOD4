using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400043
{
    internal class DoorMachine
    {
        private string state;

        public DoorMachine()
        {
            state = "Terkunci";
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (state == "Terkunci")
            {
                state = "Terbuka";
                Console.WriteLine("Pintu tidak terkunci");
            }
            else if (state == "Terbuka")
            {
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public void KunciPintu()
        {
            if (state == "Terbuka")
            {
                state = "Terkunci";
                Console.WriteLine("Pintu terkunci");
            }
            else if (state == "Terkunci")
            {
                Console.WriteLine("Pintu terkunci");
            }
        }
    }
}
