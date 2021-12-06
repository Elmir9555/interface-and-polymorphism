using System;

namespace iearxiyainterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheep shp = new Sheep();
            Dog dg = new Dog();
            shp.Age = 5;
            shp.Eye = 2;
            shp.FootCount = 4;
            shp.GetSound();
            dg.Age = 2;
            dg.FootCount = 4;
            dg.GetSound();



            

        }
    }
}
