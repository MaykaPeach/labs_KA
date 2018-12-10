using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Backpack
    {
        private List<Item> bestItems = new List<Item>();

        private int maxW;

        private int bestPrice;

        private int[,] m;

        public Backpack(int _maxW)
        {
            maxW = _maxW;
        }

        /*формируем матрицу m[items.Count+1, maxW+1] - это максимальная стоимость предметов, 
        которые можно уложить в рюкзак вместимости maxW, используя только 
        items.Count(кол-во в списке) предметов.*/

        public void dinamicAlg(List<Item> items)
        {
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
        }

        //заполняем список вещами, которые лежат в рюкзаке
        public void thingsInBackpack(int cnt, List<Item> items, int max) {
            if (m[cnt, max] == 0)
                return;

            if (m[cnt - 1, max] == m[cnt, max])
                thingsInBackpack(cnt - 1, items, max);
            else {
                thingsInBackpack(cnt - 1, items, max - items[cnt - 1].weigth);
                bestItems.Add(items[cnt - 1]);
            }
        }

        //возвращает решение задачи (набор предметов)
        public List<Item> getBestSet()
        {
            return bestItems;
        }
    }
}
