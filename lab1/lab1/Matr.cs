using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace lab1
{
    class Matr
    {
        private int size;

        private int[] way;

        private int min_way;

        private int[,] matrix; // обрабатываемая матрица

        public Matr(int n)
        {
            this.size = n;
            this.matrix = new int[n, n];
            this.way = new int[n];
        }

        //строка для вывода кратчайшего пути
        public string getAllWay() {
            string res = "";
            for (int i = 0; i < size; i++)
                if (i != size - 1)
                    res = res + way[i].ToString() + " - ";
                else
                    res = res + way[i].ToString();
            return res;
        }

        //вывод расстояния для кратчайшего пути
        public int getWay()
        {
            return min_way;
        }

        /*если выбрано заполнение вручную, то оставляем заполнение для пользователя
          выше главной диагонали*/

        public void Select(DataGridView GrVw)
        {
            GrVw.ReadOnly = false;
            for (int i = 0; i < size; i++)
                for (int j = 0; j <= i; j++)
                    GrVw.Rows[i].Cells[j].ReadOnly = true;
        }

        //заполнение матрицы из DataGridView
        public void GridToMatrix(DataGridView GrVw)
        {
            DataGridViewCell txtCell;
            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    txtCell = GrVw.Rows[i].Cells[j];
                    string s = txtCell.Value.ToString();
                    if (s == "")
                        matrix[j, i] = matrix[i, j] = 0;
                    else
                        try
                        {
                            matrix[j, i] = matrix[i, j] = Int32.Parse(s);
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Неверный формат");
                        }
                }
            }
        }

        //заполнение матрицы рандомно
        public void RandomToMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    if (i == j)
                        matrix[j, i] = 0;
                    else
                        matrix[j, i] = matrix[i, j] = rand.Next(100);
                }
            }
        }

        //вывод матрицы в DataGridView
        public void MatrixToGrid(DataGridView GrVw, int count)
        {
            //установка размеров
            DataTable matr = new DataTable("Расстояние между городами");
            DataColumn[] cols = new DataColumn[count];

            for (int i = 0; i < count; i++)
            {
                cols[i] = new DataColumn((i + 1).ToString());
                matr.Columns.Add(cols[i]);
            }

            for (int i = 0; i < count; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            GrVw.DataSource = matr;
            for (int i = 0; i < count; i++)
            {
                GrVw.Columns[i].Width = 50;
                GrVw.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            // занесение значений
            DataGridViewCell Cell;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Cell = GrVw.Rows[i].Cells[j];
                    Cell.Value = matrix[i, j];
                }
            }

            GrVw.AllowUserToAddRows = false;
            GrVw.ReadOnly = true;
        }


        /*Работа с алгоритмами*/

        //меняем местами два элемента
        private void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        //первая перестановка
        private void MakeFirst(ref int[] P)
        {
            for (int i = 0; i < size; i++)
                P[i] = i + 1;
        }

        //получение следующей перестановки для лексикографического алгоритма
        private bool GetNext(int[] P, int[] Last)
        {
            // получаем первую перестановку
            bool ok = false;
            int i, j;
            i = size-1;

            while (i > 0 & P[i] < P[i - 1])
               i--;

            j = size-1;

            while (P[j] < P[i - 1])
                j--;

            Swap(ref P[i - 1], ref P[j]);
            for (j = 0; j < (size-1 - i + 1) / 2 - 1; j++)
                Swap(ref P[i + j] , ref P[size-1 - j]);
            
            //получили, проверяем последняя она или нет
            i = 0;
            while (i < size & !ok)
            {
                if (P[i] != Last[i])
                    //если не равен хотя бы один элемент, то перестановка не последняя, значит ок
                    ok = true;
                i++;
            }
            return ok;
        }

        private void FindMinWay(int[] P)
        {
            int my_way = 0;
            /* подсчёт пути */
            for (int i = 0; i < size; i++)
                if (i == size - 1)
                    my_way = my_way + matrix[P[i] - 1, P[0] - 1];
                else
                    my_way = my_way + matrix[P[i] - 1, P[i + 1] - 1];
            /* если путь меньше прошлого, то перезаписываем маршрут и значение */
            if (min_way > my_way)
            {
                min_way = my_way;
                Array.Copy(P, way, size);
            }
        }

        /* Количество перестановок формула p = n!*/
        private int CountP()
        {
            int cnt = 1;
            for (int i = 1; i <= size; i++)
                cnt = cnt * i;
            return cnt;
        }

        /* Перестановку в строку */
        private string PtoString(int[] P)
        {
            string res="";
            for (int i = 0; i < size; i++)
                res = res + Convert.ToString(P[i]);
            return res;
        }
        /* Лексикографический алгорим для перестановок */
        public string Leks()
        {
            min_way = 10000;

            /*засекаем время*/
            System.Diagnostics.Stopwatch sw1 = new System.Diagnostics.Stopwatch();
            sw1.Start();

            /* последняя перестановка*/
            int[] Last = new int[size];
            for (int i = 0; i < size; i++)
                Last[i] = size - i;

            /* первая перестановка */
            int[] P = new int[size];
            MakeFirst(ref P);

            /* пока перестановка НЕпоследняя, считаем путь для каждой, ищем кратчайший*/
            do
            {
                FindMinWay(P);
            }
            while (GetNext(P, Last));
            /* стоп-время */
            sw1.Stop();
            return (sw1.ElapsedMilliseconds / 100.0).ToString();
        }

        
        /* Алгоритм случайных перестановок */
        public string Rand()
        {
            min_way = 10000;
            /* Засекаем время */
            System.Diagnostics.Stopwatch sw2 = new System.Diagnostics.Stopwatch();
            sw2.Start();

            /* Чтобы рандом был максимально разным!!)))*/
            Random rand = new Random((DateTime.Now.Millisecond));

            /* Храним случайные перестановки, как строки */
            Dictionary<int, string> dict = new Dictionary<int, string>(CountP());

            /* Создаем первую перестановку */
            int[] P = new int[size];
            MakeFirst(ref P);

            int j = 1;

            /* Пока словарь не заполнен всеми перестановками */
            while (dict.Count < CountP())
            {
                /* Подсчет пути для перестановки */
                FindMinWay(P);

                /* Добавление перестановки в словарь */
                dict.Add(j, PtoString(P));

                /* Генерация новой случайной перестановки */
                if (dict.Count < CountP())
                {
                    while (dict.ContainsValue(PtoString(P)))
                    {
                        for (int k = size - 1; k >= 1; k--)
                        {
                            //int l = rand.Next(0, k);
                            int l = rand.Next(0, size);
                            Swap(ref P[l], ref P[k]);
                        }
                    }
                    j++;
                }
            }
             /* Стоп-время */
            sw2.Stop();
            return (sw2.ElapsedMilliseconds / 100.0).ToString();
        }
    }
}
