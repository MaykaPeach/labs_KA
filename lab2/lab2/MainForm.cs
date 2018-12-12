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

        private void showItems(List<Item> _items)
        {
            LstVwTask.Items.Clear();

            foreach (Item i in _items)
            {
                LstVwTask.Items.Add(new ListViewItem(new string[] { i.name, i.weigth.ToString(),
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

                bp.dinamicAlg(items);
                bp.thingsInBackpack(items.Count, items, maxW);

                List<Item> solve = bp.getBestSet();

                if (solve == null)
                {
                    MessageBox.Show("Нет решения!");
                }
                else
                {
                    LstVwTask.Items.Clear();
                    showItems(solve);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            LstVw.Items.Clear();
            LstVwTask.Items.Clear();
            items.Clear();
        }
    }
}
