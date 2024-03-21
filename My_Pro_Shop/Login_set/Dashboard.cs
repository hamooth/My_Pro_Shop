using My_Pro_Shop.Login_set.Add_pro_set;
using My_Pro_Shop.Login_set.Billing_set;
using My_Pro_Shop.Login_set.Worker_set;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pro_Shop.Login_set
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
            kryptonButton_worker.Click += KryptonButton_worker_Click;
            kryptonButton_add_pro.Click += KryptonButton_add_pro_Click;
            kryptonButton_billing.Click += KryptonButton_billing_Click;
        }

        private void KryptonButton_billing_Click(object sender, EventArgs e)
        {
            Add_View_Prodects_Form frm = new Add_View_Prodects_Form();
            FormInPanel(panel_Main_Dash, frm);
        }

        private void KryptonButton_add_pro_Click(object sender, EventArgs e)
        {
            Add_Product_list_Form frm = new Add_Product_list_Form();
            FormInPanel(panel_Main_Dash, frm);
        }

        private void KryptonButton_worker_Click(object sender, EventArgs e)
        {
            Worker_Dash frm = new Worker_Dash();
            FormInPanel(panel_Main_Dash, frm);
        }

        

        public void FormInPanel(Panel panel_Main_Dash, Form Dashboard)
        {
            if (panel_Main_Dash.Controls.Count > 0)
                panel_Main_Dash.Controls.RemoveAt(0);

            panel_Main_Dash.BackColor = Color.AliceBlue;
            Dashboard.TopLevel = false;
            panel_Main_Dash.Controls.Add(Dashboard);

            Dashboard.Location = new Point((panel_Main_Dash.Width - Dashboard.Width) / 2, (panel_Main_Dash.Height - Dashboard.Height) / 2);
            panel_Main_Dash.Tag = Dashboard;
            Dashboard.Show();

        }

       
    }
}
