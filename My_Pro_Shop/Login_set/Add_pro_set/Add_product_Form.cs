using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pro_Shop.Login_set.Add_pro_set
{
    public partial class Add_product_Form : Form
    {
        public Add_product_Form()
        {
            InitializeComponent();
            kryptonButton_Creat_Category.Click += KryptonButton_Creat_Category_Click;
        }

        private void KryptonButton_Creat_Category_Click(object sender, EventArgs e)
        {
            category_create frm = new category_create();
            frm.ShowDialog();
        }

     
    }
}
