using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pro_Shop.Login_set.Worker_set
{
    public partial class Worker_Dash : Form
    {
        public Worker_Dash()
        {
            InitializeComponent();
            kryptonButton_Register.Click += KryptonButton_Register_Click;
            kryptonButton__Working_Time.Click += KryptonButton__Working_Time_Click;
            kryptonButton_Payment.Click += KryptonButton_Payment_Click;
            kryptonButton_Payment_Details.Click += KryptonButton_Payment_Details_Click;
        }

     

        private void KryptonButton_Payment_Details_Click(object sender, EventArgs e)
        {
            Payment_Details_Form frm = new Payment_Details_Form();
            FormInPanel(panel_W_D_Main, frm);
        }

        private void KryptonButton_Payment_Click(object sender, EventArgs e)
        {
            Payment_Form frm = new Payment_Form();
            FormInPanel(panel_W_D_Main, frm);
        }

        private void KryptonButton__Working_Time_Click(object sender, EventArgs e)
        {
            Working_Time_form frm = new Working_Time_form();
            FormInPanel(panel_W_D_Main, frm);
        }

        private void KryptonButton_Register_Click(object sender, EventArgs e)
        {
            Register_form frm = new Register_form();
            FormInPanel(panel_W_D_Main, frm);
        }

       

        

        public void FormInPanel(Panel panel_W_D_Main, Form Worker_Dash)
        {
            if (panel_W_D_Main.Controls.Count > 0)
                panel_W_D_Main.Controls.RemoveAt(0);

            panel_W_D_Main.BackColor = Color.AliceBlue;
            Worker_Dash.TopLevel = false;
            panel_W_D_Main.Controls.Add(Worker_Dash);

            Worker_Dash.Location = new Point((panel_W_D_Main.Width - Worker_Dash.Width) / 2, (panel_W_D_Main.Height - Worker_Dash.Height) / 2);
            panel_W_D_Main.Tag = Worker_Dash;
            Worker_Dash.Show();

        }
    }
}
