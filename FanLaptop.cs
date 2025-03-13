using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modul4_103022300050
{
    enum State { Balanced, Quiet, Performance, Turbo};
    internal class FanLaptop
    {
        State state = State.Quiet;
        string[] status = { "Balanced", "Quiet", "Performance", "Turbo" };

        public FanLaptop()
        {
            state = State.Quiet;
            Console.WriteLine(status[(int)state] + " Fan");
        }

        public void Balanced()
        {
            Console.WriteLine("Fan " + status[(int)state] + " berubah menjadi Balanced");
            state = State.Balanced;
            Console.WriteLine(status[(int)state] + " Fan");
        }

        public void Turbo()
        {
            Console.WriteLine("Fan " + status[(int)state] + " berubah menjadi Turbo");
            state = State.Turbo;
            Console.WriteLine(status[(int)state] + " Fan");
        }

        public void Performance() 
        {
            Console.WriteLine("Fan " + status[(int)state] + " berubah menjadi Performance");
            state = State.Performance;
            Console.WriteLine(status[(int)state] + " Fan");
        }

        public void Quiet()
        {
            Console.WriteLine("Fan " + status[(int)state] + " berubah menjadi Quiet");
            state = State.Quiet;
            Console.WriteLine(status[(int)state] + " Fan");
        }
    }
}
