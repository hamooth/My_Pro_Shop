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
    public partial class Add_Product_list_Form : Form
    {
        public Add_Product_list_Form()
        {
            InitializeComponent();
            kryptonButton_Add_product.Click += KryptonButton_Add_product_Click;
            kryptonButton_Purchase_List.Click += KryptonButton_Purchase_List_Click;
            kryptonButton_Purchase_Loge.Click += KryptonButton_Purchase_Loge_Click;
            kryptonButton_Return_List.Click += KryptonButton_Return_List_Click;
        }

        private void KryptonButton_Return_List_Click(object sender, EventArgs e)
        {
            Return_list_form frm = new Return_list_form();
            FormInPanel(panel_Main_Add_pro, frm);
        }

        private void KryptonButton_Purchase_Loge_Click(object sender, EventArgs e)
        {
            Purchase_list_form frm = new Purchase_list_form();
            FormInPanel(panel_Main_Add_pro, frm);
        }

        private void KryptonButton_Purchase_List_Click(object sender, EventArgs e)
        {
            Purchase_list_form frm = new Purchase_list_form();
            FormInPanel(panel_Main_Add_pro, frm);
        }

        private void KryptonButton_Add_product_Click(object sender, EventArgs e)
        {
            Add_product_Form frm = new Add_product_Form();
            FormInPanel(panel_Main_Add_pro, frm);
        }

     

 

        public void FormInPanel(Panel panel_Main_Add_pro, Form Add_Product_list_Form)
        {
            if (panel_Main_Add_pro.Controls.Count > 0)
                panel_Main_Add_pro.Controls.RemoveAt(0);

            panel_Main_Add_pro.BackColor = Color.AliceBlue;
            Add_Product_list_Form.TopLevel = false;
            panel_Main_Add_pro.Controls.Add(Add_Product_list_Form);

            Add_Product_list_Form.Location = new Point((panel_Main_Add_pro.Width - Add_Product_list_Form.Width) / 2, (panel_Main_Add_pro.Height - Add_Product_list_Form.Height) / 2);
            panel_Main_Add_pro.Tag = Add_Product_list_Form;
            Add_Product_list_Form.Show();

        }

        
    }
}
