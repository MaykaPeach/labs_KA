using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Backpack
    {
        private List<Item> bestItems = null;

        private int maxW;

        private int bestPrice;

        public Backpack(int _maxW)
        {
            maxW = _maxW;
        }

        //создание всех наборов перестановок значений
        public void makeAllSets(List<Item> items)
        {
            if (items.Count > 0)
                checkSet(items);

            for (int i = 0; i < items.Count; i++)
            {
                List<Item> newSet = new List<Item>(items);
                newSet.RemoveAt(i);           
                makeAllSets(newSet);
            }

        }

        //проверка, является ли данный набор лучшим решением задачи
        private void checkSet(List<Item> items)
        {
            if (bestItems == null)
            {
                if (calcWeigth(items) <= maxW)
                {
                    bestItems = items;
                    bestPrice = calcPrice(items);
                }
            }
            else
            {
                if (calcWeigth(items) <= maxW && calcPrice(items) > bestPrice)
                {
                    bestItems = items;
                    bestPrice = calcPrice(items);
                }
            }
        }

        //вычисляет общий вес набора предметов
        private int calcWeigth(List<Item> items)
        {
            int sumW = 0;

            foreach (Item i in items)
            {
                sumW += i.weigth;
            }

            return sumW;
        }

        //вычисляет общую стоимость набора предметов
        private int calcPrice(List<Item> items)
        {
            int sumPrice = 0;

            foreach (Item i in items)
            {
                sumPrice += i.price;
            }

            return sumPrice;
        }

        //возвращает решение задачи (набор предметов)
        public List<Item> getBestSet()
        {
            return bestItems;
        }
    }
}
