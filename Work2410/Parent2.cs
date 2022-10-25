using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work2410
{
    public partial class Parent2 : Form
    {
        public Parent2()
        {
            InitializeComponent();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            Child2 child2 = new Child2();
            child2.ClearList();
            listProducts.Items.Clear();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            Child2 child2 = new Child2();
            child2.RemoveProduct(listProducts.Items[listProducts.SelectedIndex].ToString());
            listProducts.Items.RemoveAt(listProducts.SelectedIndex);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Child2 child2 = new Child2();
            if (child2.ShowDialog() == DialogResult.OK)
            {
                listProducts.Items.Add(child2.MyString);
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Child2 child2 = new Child2();
            child2.EditProduct(listProducts.Items[listProducts.SelectedIndex].ToString());
            if (child2.ShowDialog() == DialogResult.OK)
            {
                listProducts.Items[listProducts.SelectedIndex]=child2.MyString;
            }
        }
    }
}
