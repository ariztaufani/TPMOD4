using System;

namespace TP_MODUL4_103022400043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Kode Pos ");

            KodePos kodePos = new KodePos();

            Console.WriteLine("Batununggal : " + kodePos.getKodePos("Batununggal"));
            Console.WriteLine("Kujangsari  : " + kodePos.getKodePos("Kujangsari"));
            Console.WriteLine("Mengger     : " + kodePos.getKodePos("Mengger"));

            Console.WriteLine();


            Console.WriteLine(" Door Machine ");

            DoorMachine pintu = new DoorMachine();

            pintu.BukaPintu();
            pintu.KunciPintu();
            pintu.BukaPintu();

            Console.ReadLine();
        }
    }
}