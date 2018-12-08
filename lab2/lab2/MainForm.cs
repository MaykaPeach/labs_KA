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
            addForm = new AddForm();
            item_ = new Item("", 0, 0);
            items = new List<Item>();
            btn_Task.Enabled = false;
        }

        private void brn_add_Click(object sender, EventArgs e)
        {
            if (addForm.addItem())
            {
                item_ = addForm.item;
                items.Add(new Item(item_.name, item_.weigth, item_.price));
                LstVw.Items.Add(new ListViewItem(new string[] { item_.name, item_.weigth.ToString(), item_.price.ToString() }));
                btn_Task.Enabled = true;
            }
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
            if (num_size.Value == 0)
            {
                MessageBox.Show("Максимальный вес рюкзака не может быть равен 0!");
            }
            else
            {
                Backpack bp = new Backpack(Convert.ToInt32(num_size.Value));
                bp.makeAllSets(items);
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
    }
}
