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

        public string getAllWay() {
            string res = "";
            for (int i = 0; i < size; i++)
                if (i != size - 1)
                    res = res + way[i].ToString() + " - ";
                else
                    res = res + way[i].ToString();
            return res;
        }

        public int getWay()
        {
            return min_way;
        }

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
        /*----------------------------------------------------------*/
        private void swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        private  void GetNext(int[] P)
        {
            int i, j;
            i = size-1;

            while (i > 0 & P[i] < P[i - 1])
               i--;

            j = size-1;

            while (P[j] < P[i - 1])
                j--;

            swap(ref P[i - 1], ref P[j]);
            for (j = 0; j < (size-1 - i + 1) / 2 - 1; j++)
                swap(ref P[i + j] , ref P[size-1 - j]);
        }

        private bool Eq(int[] arr1, int[] arr2, int size)
        {
            bool ok = true;
            int i = 0;
            while (i < size & ok)
            {
                if (arr1[i] != arr2[i])
                    ok = false;
                i++;
            }
            return ok;
        }

        public string Leks()
        {
            min_way = 10000;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            /* последняя перестановка*/
            int[] Last = new int[size];
            for (int i = 0; i < size; i++)
                Last[i] = size - i;
            /* первая перестановка */
            int[] P = new int[size];
            for (int i = 0; i < size; i++)
                P[i] = i+1;

            int my_way;

            while (!Eq(P, Last, size))
            {
                my_way = 0;
                for (int i = 0; i < size; i++)
                    if (i == size - 1)
                        my_way = my_way + matrix[P[i]-1, P[0]-1];
                    else
                        my_way = my_way + matrix[P[i]-1, P[i + 1]-1];
                if (min_way > my_way)
                {
                    min_way = my_way;
                    Array.Copy(P,way, size);
                }
                GetNext(P);
            }
            sw.Stop();
            return (sw.ElapsedMilliseconds / 100.0).ToString();
        }
        

        public string Rand()
        {
            min_way = 10000;
            System.Diagnostics.Stopwatch sw1 = new System.Diagnostics.Stopwatch();
            sw1.Start();
            Random rand = new Random();

            int[] P = new int[size];
            for (int i = 0; i < size; i++)
                P[i] = i + 1;

            int my_way;

            for (int k = size - 1; k >= 1; k--)
            {
                //проверка перестановки на уникальность
                my_way = 0;
                for (int i = 0; i < size; i++)
                    if (i == size - 1)
                        my_way = my_way + matrix[P[i] - 1, P[0] - 1];
                    else
                        my_way = my_way + matrix[P[i] - 1, P[i + 1] - 1];
                if (min_way > my_way)
                {
                    min_way = my_way;
                    Array.Copy(P, way, size);
                }

                int j = rand.Next(0, k);
                swap(ref P[j], ref P[k]);
            }

            sw1.Stop();
            return (sw1.ElapsedMilliseconds / 100.0).ToString();
        }
    }
}
