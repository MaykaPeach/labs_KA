using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Backpack
    {
        /* Методом динамичесого программирования*/
        private List<Item> bestItemsDin = new List<Item>();

        /* Жадным алгоритмом */
        private List<Item> bestItemsGreedy = new List<Item>();

        private int maxW;

        private int[,] m;

        public Backpack(int _maxW)
        {
            maxW = _maxW;
        }

        /*формируем матрицу m[items.Count+1, maxW+1] - это максимальная стоимость предметов, 
        которые можно уложить в рюкзак вместимости maxW, используя только 
        items.Count(кол-во в списке) предметов.*/

        public int dinamicAlg(List<Item> items, out string time)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            m = new int[items.Count+1, maxW+1];

            for (int j = 0; j <= maxW; j++) 
                m[0, j] = 0;

            for (int j = 0; j <= items.Count; j++)
                m[j, 0] = 0;

            for (int i = 1; i <= items.Count; i++)
            {
                for (int j = 0; j <= maxW; j++)
                {
                    if (items[i-1].weigth > j)
                        m[i, j] = m[i - 1, j];
                    else
                        m[i, j] = Math.Max(m[i - 1, j], m[i - 1, j - items[i-1].weigth] + items[i-1].price);
                }
            }

            sw.Stop();
            time = (sw.ElapsedMilliseconds / 100.0).ToString();

            return m[items.Count, maxW];         
        }

        //заполняем список вещами, которые лежат в рюкзаке
        public void thingsInBackpack(int cnt, List<Item> items, int max) {
            if (m[cnt, max] == 0)
                return;

            if (m[cnt - 1, max] == m[cnt, max])
                thingsInBackpack(cnt - 1, items, max);
            else {
                thingsInBackpack(cnt - 1, items, max - items[cnt - 1].weigth);
                bestItemsDin.Add(items[cnt - 1]);
            }
        }

        /* Жадный алгоритм */
        public int greedyAlg(List<Item> items, out string time)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            /*сначала максимальный вес в рюкзаке*/
            int max = maxW;

            /* суммарная стоимость вещей в рюкзаке */
            int sum = 0;

            /* Сортировка по цене за единицу веса - от бОльшей к мЕньшей*/
            ComparerUnitPrice com = new ComparerUnitPrice();
            items.Sort(com);

            for (int i = 0; i < items.Count; i++) 
            {
                if (max >= items[i].weigth)
                {
                    sum += items[i].price;
                    max -= items[i].weigth;
                    bestItemsGreedy.Add(items[i]);
                }
            }

            sw.Stop();
            time = (sw.ElapsedMilliseconds / 100.0).ToString();

            return sum;
        }

        //возвращает решение задачи динамическим программированием (набор предметов)
        public List<Item> getBestSetDin()
        {
            return bestItemsDin;
        }

        //возвращает решение задачи жадным алгоримом (набор предметов)
        public List<Item> getBestSetGreedy()
        {
            return bestItemsGreedy;
        }

        /* возвращает сумму веса вещей в списке */
        public int getWeight(List<Item> items)
        {
            int weight = 0;
            for (int i = 0; i < items.Count(); i++)
                weight = weight + items[i].weigth;
            return weight;
        }

    }
}
