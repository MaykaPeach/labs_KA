﻿using System;
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
                
                /* Динамическое программирование*/
                int maxSumDin = bp.dinamicAlg(items);
                bp.thingsInBackpack(items.Count, items, maxW);
                List<Item> solveDin = bp.getBestSetDin();

                /* Жадный алгорим */
                int maxSumGreedy = bp.greedyAlg(items);                
                List<Item> solveGreedy = bp.getBestSetGreedy();

                if (solveDin == null)
                {
                    MessageBox.Show("Нет решения!");
                }
                else
                {
                    /* Динамическое программирование*/
                    showItems(solveDin, LstVwDin);

                    /* Жадный алгорим */
                    showItems(solveGreedy, LstVwGreedy);

                    MessageBox.Show("Динамическим программированием - " + maxSumDin + "\nЖадным алгоримом - " + maxSumGreedy, "Максимальная стоимость рюкзака");
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

            LstVw.Items.Clear();
            LstVwDin.Items.Clear();
            LstVwGreedy.Items.Clear();
            items.Clear();
        }
    }
}
