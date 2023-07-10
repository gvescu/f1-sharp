using F1Sharp;
using F1Sharp.Data;
using F1Sharp.Packets;
using System.Runtime.InteropServices;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listening for F1 23...");

            TelemetryClient client = new(20777);

            client.OnCarDamageDataReceive += Client_OnCarDamageDataReceive;

            Console.CursorVisible = false;
            Console.Read();
        }

        private static void Client_OnCarDamageDataReceive(CarDamagePacket packet)
        {
            int index = 0;
            Console.Clear();
            foreach (CarDamageData data in packet.carDamageData)
            {
                Console.WriteLine($"INDEX: {index}");
                Console.WriteLine($"{data}");
                Console.WriteLine("----");
                index++;
                if (index == 5)
                {
                    break;
                }
            }

            Console.WriteLine($"{packet.carDamageData[packet.header.playerCarIndex]}");
        }
    }
}