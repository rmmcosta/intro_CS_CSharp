using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IMachine
    {
        void Play();
        int NoiseLevel{ get;set;}
    }

    public class Hoven:IMachine
    {
        private int noiseLevel;
        public Hoven(int db)
        {
            NoiseLevel = db;
        }

        public int NoiseLevel { get => noiseLevel; set => noiseLevel = value; }

        public void Play()
        {
            Console.WriteLine("Making some noise at {0} dB!", NoiseLevel);
        }
        public void Upgrade(int inc)
        {
            noiseLevel += inc;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hoven ufesa = new Hoven(50);
            ufesa.Play();
            ufesa.Upgrade(5);
            ufesa.Play();
        }
    }
}
