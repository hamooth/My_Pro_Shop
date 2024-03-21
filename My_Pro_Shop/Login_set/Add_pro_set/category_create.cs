using My_Pro_Shop.Login_set.Billing_set;
using My_Pro_Shop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace My_Pro_Shop.Login_set.Add_pro_set
{
    public partial class category_create : Form
    {
        public category_create()
        {
            InitializeComponent();

            kryptonButton_Dashboard.Click += KryptonButton_Dashboard_Click;
            kryptonButton_Add_Edit_ANC.Click += KryptonButton_Add_Edit_ANC_Click;

        }

        private void KryptonButton_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.ShowDialog();
        }

        private void KryptonButton_Add_Edit_ANC_Click(object sender, EventArgs e)
        {
            Category_create_Services _col = new Category_create_Services();



            /*Button btn = new Button();
            btn.Text = textBox_category_name.Text;
            btn.Dock = DockStyle.Fill;
            tableLayoutPanel_Category.Controls.Add(btn);
            MessageBox.Show("Create Success");*/


            _col.AddDataEntry1(kryptonTextBox_Name.Text);
            MessageBox.Show("Create Success");
            kryptonTextBox_Name.Clear();
            ListData();
        }     


        void ListData()
        {
            Category_create_Services data = new Category_create_Services();
            dataGridView_Add_New_Category.DataSource = data.ListAll();
        }


    }
}
