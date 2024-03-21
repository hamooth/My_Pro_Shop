using My_Pro_Shop.Login_set;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pro_Shop
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            
            kryptonButton_Login.Click += KryptonButton_Login_Click;
            pictureBox_password_eye.MouseHover += PictureBox_password_eye_MouseHover;
            pictureBox_password_eye.MouseLeave += PictureBox_password_eye_MouseLeave;
            
            kryptonButton_Exit.Click += KryptonButton_Exit_Click;
        }

        private void KryptonButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KryptonButton_Login_Click(object sender, EventArgs e)
        {
            string login_gole = comboBox_login_role.Text.Trim();
            string Uname = textBox_Username.Text.Trim();
            string Pwd = textBox_Password.Text.Trim();

            var _LS = new Services.Loginservices();
            var lr = _LS.ListAll().SingleOrDefault().login_role.ToLower();
            var un = _LS.ListAll().SingleOrDefault().Username.Trim();
            var pw = _LS.ListAll().SingleOrDefault().Password.Trim();


            if (login_gole == lr)
            {
                if (Uname == un && pw == Pwd)
                {
                    MessageBox.Show("Login Success", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var frm = new Dashboard();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Login Error\n Check UserName or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAll();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Select the correct Role For Login", "Select correct role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                comboBox_login_role.Select();
            }
        }

    

        private void PictureBox_password_eye_MouseLeave(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
        }

        private void PictureBox_password_eye_MouseHover(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = false;
        }

      


        private void ClearAll()
        {
            textBox_Password.Clear();
            textBox_Username.Clear();
            textBox_Username.Select();
        }
    }
}
