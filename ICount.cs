using System;
namespace iearxiyainterface
{
    public interface ICount
    {
        public int Age { get; set; }
        public int Eye  { get; set; }
        public int FootCount { get; set; }
        


        void GetSound();
        void GetRun();
        void Jumping();
    }
}
