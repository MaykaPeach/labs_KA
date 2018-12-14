using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class MainForm : Form
    {
        AddForm addForm;
        Item item_;
        private List<Item> items;

        public MainForm()
        {
            InitializeComponent();
            item_ = new Item("", 0, 0);
            items = new List<Item>();
            addForm = new AddForm(items, LstVw);
            btn_Task.Enabled = false;

            GrVw.RowCount = 3;
            GrVw[0, 0].Value = "Макс. стоимость";
            GrVw[0, 1].Value = "Вес";
            GrVw[0, 2].Value = "Время";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (addForm.IsDisposed)
                addForm = new AddForm(items, LstVw);

            if (!addForm.Visible)
                addForm.Show();

            if (items != null) 
               btn_Task.Enabled = true;
        }

        private void showItems(List<Item> _items, ListView LstVw)
        {
            LstVw.Items.Clear();
            foreach (Item i in _items)
            {
                LstVw.Items.Add(new ListViewItem(new string[] { i.name, i.weigth.ToString(),
                    i.price.ToString() }));
            }
        }

        private void btn_Task_Click(object sender, EventArgs e)
        {
            int maxW = Convert.ToInt32(num_size.Value);
            if (maxW == 0)
            {
                MessageBox.Show("Максимальный вес рюкзака не может быть равен 0!");
            }
            else
            {
                Backpack bp = new Backpack(maxW);

                string timeDin, timeGreedy;

                /* Динамическое программирование*/
                int maxSumDin = bp.dinamicAlg(items, out timeDin);
                bp.thingsInBackpack(items.Count, items, maxW);
                List<Item> solveDin = bp.getBestSetDin();

                /* Жадный алгорим */
                int maxSumGreedy = bp.greedyAlg(items, out timeGreedy);                
                List<Item> solveGreedy = bp.getBestSetGreedy();

                if (solveDin == null)
                {
                    MessageBox.Show("Нет решения!");
                }
                else
                {               
                    /* Динамическое программирование*/
                    showItems(solveDin, LstVwDin);

                    GrVw[1, 0].Value = maxSumDin;
                    GrVw[1, 1].Value = bp.getWeight(solveDin);
                    GrVw[1, 2].Value = timeDin;

                    /* Жадный алгорим */
                    showItems(solveGreedy, LstVwGreedy);

                    GrVw[2, 0].Value = maxSumGreedy;
                    GrVw[2, 1].Value = bp.getWeight(solveGreedy);
                    GrVw[2, 2].Value = timeGreedy;

                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    GrVw[i, j].Value = "";

            LstVw.Items.Clear();
            LstVwDin.Items.Clear();
            LstVwGreedy.Items.Clear();
            items.Clear();
        }
    }
}
