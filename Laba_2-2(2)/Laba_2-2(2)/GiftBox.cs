using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2_2_2_
{
    class GiftBox
    {
        public List<Candy> CandyList;
        public GiftBox()
        {
            CandyList = new List<Candy>();
        }
        public void Show()
        {
            Console.WriteLine();
            foreach (Candy cnd in CandyList)
            {
                Console.WriteLine(" " + cnd);
            }
        }
        public void AddNewCandy(Candy candy)
        {
            CandyList.Add(candy);
        }
        public double GetTotalWeight()
        {
            double weight = 0;
            foreach (Candy aPart in CandyList)
            {
                weight += aPart.Weight;
            }
            return weight;
        }
        public void SortByName()
        {
            Console.WriteLine();
            CandyList.Sort(delegate (Candy candy1, Candy candy2)
            { return candy1.Name.CompareTo(candy2.Name); });
            Show();
        }

        public void SortByWeight()
        {
            Console.WriteLine();
            CandyList.Sort(delegate (Candy candy1, Candy candy2)
            { return candy1.Weight.CompareTo(candy2.Weight); });

            foreach (Candy aPart in CandyList)
            {
                Console.WriteLine(aPart + ", " + aPart.Weight);
            }
        }

        public void SortBySugarPercentage()
        {
            Console.WriteLine();
            CandyList.Sort(delegate (Candy candy1, Candy candy2)
            { return candy1.Sugar.CompareTo(candy2.Sugar); });

            foreach (Candy aPart in CandyList)
            {
                Console.WriteLine(aPart + ", " + aPart.Sugar + "%");
            }
        }

        public void FindCandy(int startValue, int finishValue)
        {
            foreach (Candy aPart in CandyList)
            {
                if (aPart.Sugar*100 > startValue && aPart.Sugar*100 < finishValue)
                {
                    Console.WriteLine(aPart + ", " + aPart.Sugar * 100 + "%");
                }
            }
        }
    }
}
