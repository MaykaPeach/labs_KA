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

        public AddForm()
        {
            InitializeComponent();
            item = new Item("", 0, 0);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.Trim() == "")
                MessageBox.Show("Название не указано!");
            else if (num_price.Value == 0 | num_weight.Value == 0)
                MessageBox.Show("Вес и/или Стоимость не могут равняться 0");
                else
                {
                    item.name = tb_name.Text.Trim();
                    item.weigth = Convert.ToInt32(num_weight.Value);
                    item.price = Convert.ToInt32(num_price.Value);
                }
            Close();

        }

        public bool addItem()
        {
            tb_name.Clear();
            num_weight.Value = num_price.Value = 0;
            return (ShowDialog() == DialogResult.OK & item.name != "" & item.weigth != 0 & item.price != 0);         
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
