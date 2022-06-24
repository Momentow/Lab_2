using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Candy chocolate = new ChocolateCandy();
            Candy marmelade = new Marmelade();
            Candy glassC = new GlassCandy();
            GiftBox gift = new GiftBox();

            Console.WriteLine("Add new candy:\n [1] Glass-candy,\n [2] Marmelade," +
                              "\n [3] Chocolate candy,\n [0] Go to the giftbox.");
            int status = 1;
            while (status != 0)
            {
                int candy = Convert.ToInt32(Console.ReadLine());
                switch (candy)
                {
                    case 1:
                        gift.AddNewCandy(glassC);
                        break;
                    case 2:
                        gift.AddNewCandy(marmelade);
                        break;
                    case 3:
                        gift.AddNewCandy(chocolate);
                        break;
                    case 0:
                        status = 0;
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }

            status = 1;
            while (status != 0)
            {
                Console.WriteLine("\nChoose option:\n [1] Show candy list,\n [2] Sort by name,\n [3] Sort by weight," +
                                  "\n [4] Sort by sugar,\n [5] Find the candy,\n [6] Total weight;\n [0] Exit.");
                int mode = Convert.ToInt32(Console.ReadLine());
                switch (mode)
                {
                    case 1:
                        gift.Show();
                        break;
                    case 2:
                        gift.SortByName();
                        break;
                    case 3:
                        gift.SortByWeight();
                        break;
                    case 4:
                        gift.SortBySugarPercentage();
                        break;
                    case 5:
                        int startValue = Convert.ToInt32(Console.ReadLine());
                        int finishValue = Convert.ToInt32(Console.ReadLine());
                        gift.FindCandy(startValue, finishValue);
                        break;
                    case 6:
                        Console.WriteLine(gift.GetTotalWeight() + " g");
                        break;
                    case 0:
                        status = 0;
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
        }
    }
}