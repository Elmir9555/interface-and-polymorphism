using System;
namespace iearxiyainterface
{
    public class Dog : ICount
    {
        public int Age { get; set; }
        public int Eye { get; set; }
        public int FootCount { get; set; }

        public void GetRun()
        {
            Console.WriteLine("daha sürətli qaçır");
        }

        public void GetSound()
        {
            Console.WriteLine("hav-hav...");
        }

        public void Jumping()
        {
            Console.WriteLine("daha uzaq mesafeye tullana bilir");
        }
    }
}
