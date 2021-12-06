using System;
namespace iearxiyainterface
{
    public class Sheep :ICount
    {       
        public int Age { get; set; }        
        public int Eye { get; set; }
        public int FootCount { get; set; }
        


        public  void GetRun()
        {
            Console.WriteLine("Digerlerine nisbeten çəkisi çox olduğundan yavaş qaçır");
        }

        public void GetSound()
        {
            Console.WriteLine("məəə......");
        }

        public void Jumping()
        {
            Console.WriteLine("Çəkisi çox olduğundan daha az məsafəyə tullanır");
        }
    }
}
