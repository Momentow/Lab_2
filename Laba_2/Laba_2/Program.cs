using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_1
{
    class Weel
    {
        int partNo = 1;

        public void Update()
        {
            partNo += 1;
            Console.WriteLine($"Колесо заменено! Теперь это уже {partNo} сменное колесо.");
        }
    }
    class Pedals
    {
        int speed = 0;

        public void SpeedUp()
        {
            speed += 5;
            Console.WriteLine($"Скорость увеличилась! Теперь мы едем со скоростью {speed} км в час.");
        }
        public void SpeedDown()
        {
            speed -= 5;
            Console.WriteLine($"Скорость уменьшилась! Теперь мы едем со скоростью {speed} км в час.");
        }
    }
    class Rudder
    {
        static int angle = 0;

        public void Left()
        { 
            angle = -45;
            Console.WriteLine($"Велосипед повернул успешно! Мы повернули налево на {angle} градусов.");
        }
        public void Right()
        {
            angle = 45;
            Console.WriteLine($"Велосипед повернул успешно! Мы повернули направо на {angle} градусов.");
        }
    }
    class Frame
    {
        string color = "white";

        public void Recolor(string clr)
        {
            color = clr;
            Console.WriteLine($"Готово! Теперь рама цвета {color}.");
        }
    }
    class Bicycle
    {
        public void TurnLeft(Rudder rudder)
        {
            Console.WriteLine("Поворачиваем налево...");
            rudder.Left();
        }
        public void TurnRight(Rudder rudder)
        {
            Console.WriteLine("Поворачиваем направо...");
            rudder.Right();
        }
        public void FrameRecolor(string clr, Frame frame)
        {
            Console.WriteLine("Перекрашиваем раму...");
            frame.Recolor(clr);
        }
        public void Faster(Pedals pedals)
        {
            Console.WriteLine("Давим на педали...");
            pedals.SpeedUp();
        }
        public void Slower(Pedals pedals)
        {
            Console.WriteLine("Притормаживаем...");
            pedals.SpeedDown();
        }
        public void UpdateWeels(Weel weel1, Weel weel2)
        {
            Console.WriteLine("Начинаем замену колес...");
            weel1.Update();
            weel2.Update();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Weel weel1 = new Weel();
            Weel weel2 = new Weel();
            Rudder rudder = new Rudder();
            Pedals pedals = new Pedals();
            Frame frame = new Frame();

            Bicycle bicycle = new Bicycle();
            
            bicycle.Faster(pedals);
            bicycle.TurnLeft(rudder);
            bicycle.Faster(pedals);
            bicycle.TurnRight(rudder);
            bicycle.Slower(pedals);
            bicycle.Slower(pedals);
            bicycle.UpdateWeels(weel1, weel2);
            bicycle.FrameRecolor("green", frame);
        }
    }
}
