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
    public partial class AddForm : Form
    {
        public Item item;
        List<Item> items;
        ListView LstVw;

        public AddForm(List<Item> items_, ListView LstVw_)
        {
            InitializeComponent();
            item = new Item("", 0, 0);
            items = items_;
            LstVw = LstVw_;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (cmBox_name.Text.Trim() == "")
                MessageBox.Show("Название не указано!");
            else if (num_price.Value == 0 | num_weight.Value == 0)
                MessageBox.Show("Вес и/или Стоимость не могут равняться 0");
                else
                {
                    item.name = cmBox_name.Text.Trim();
                    item.weigth = Convert.ToInt32(num_weight.Value);
                    item.price = Convert.ToInt32(num_price.Value);

                    items.Add(new Item(item.name, item.weigth, item.price));
                    LstVw.Items.Add(new ListViewItem(new string[] { item.name, item.weigth.ToString(), item.price.ToString() }));

            }
            this.Visible = false;
            Empty();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Empty()
        {
            cmBox_name.Text = "";
            num_weight.Value = num_price.Value = 0;
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            if (cmBox_name.Text.Trim() == "")
                MessageBox.Show("Название не указано!");
            else if (num_price.Value == 0 | num_weight.Value == 0)
                MessageBox.Show("Вес и/или Стоимость не могут равняться 0");
            else
            {
                item.name = cmBox_name.Text.Trim();
                item.weigth = Convert.ToInt32(num_weight.Value);
                item.price = Convert.ToInt32(num_price.Value);

                items.Add(new Item(item.name, item.weigth, item.price));
                LstVw.Items.Add(new ListViewItem(new string[] { item.name, item.weigth.ToString(), item.price.ToString() }));

            }
            Empty();
        }
    }
}
