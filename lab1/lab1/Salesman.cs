using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Salesman : Form
    {
        Matr matr;
        int count;
        public Salesman()
        {
            InitializeComponent();
            this.count = 0;
            but_wayOK.Enabled = but_alg.Enabled = pan_select.Enabled = false;
        }

        private void but_countOK_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(num_count.Value);
            if (count<2)
                MessageBox.Show("Ошибка ввода. Введите число больше 1");
            else
            {
                pan_select.Enabled = true;
                matr = new Matr(count);
                matr.MatrixToGrid(GrVw, count);
            }
        }


        private void but_selectOK_Click(object sender, EventArgs e)
        {
            but_wayOK.Enabled = but_alg.Enabled = true;
            if (radBut_hand.Checked)
            {
                matr.GridToMatrix(GrVw);
                matr.MatrixToGrid(GrVw, count);
                return;
            }
            if (radBut_rand.Checked)
            {
                matr.RandomToMatrix();
                matr.MatrixToGrid(GrVw, count);
                return;
            }
        }

        private void radBut_hand_CheckedChanged(object sender, EventArgs e)
        {
            matr.Select(GrVw);
        }

        private void but_wayOK_Click(object sender, EventArgs e)
        {
             matr.Rand();
             MessageBox.Show("Кратчайший путь по маршруту " + matr.getAllWay() + " равен " + matr.getWay().ToString());
        }

        private void but_alg_Click(object sender, EventArgs e)
        {
            string timeLeks = matr.Leks();
            string timeRand = matr.Rand();
            MessageBox.Show("Скорость работы лексикографического алгоритма - " + timeLeks + "\nСкорость работы случайного алгоритма - " + timeRand);
        }
    }

}
