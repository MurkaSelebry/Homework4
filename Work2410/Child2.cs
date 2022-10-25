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
   //
    public partial class Child2 : Form
    {
        public Product MyProduct { get { return new Product(textBox1.Text, textBox2.Text, Convert.ToDecimal(textBox3.Text)); } }
        public string MyString { get { return textBox1.Text; } }
        static List<Product> Products = new List<Product>();
        private Product t_prod=null;

        public Child2()
        {
            InitializeComponent();
        }
        
        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (!Products.Contains(MyProduct))
            {
                if (t_prod != null) RemoveProduct(t_prod.Name);
                Products.Add(MyProduct);
            }

            this.DialogResult = DialogResult.OK;
        }
        public void RemoveProduct(string s)
        {
            foreach (var el in Products)
                if (el.Name == s) {  Products.Remove(el); break; }
        }
        public void EditProduct(string s)
        {
            
            foreach (var el in Products)
                if (el.Name == s)
                {
                    textBox1.Text = el.Name;
                    textBox2.Text = el.Country;
                    textBox3.Text = el.Price.ToString();
                    break;
                }
            t_prod = MyProduct;
        }
        public void ClearList()
        {
            Products.Clear();
        }
        private void bt_cl_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
    }
}
