using My_Pro_Shop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pro_Shop.Login_set.Worker_set
{
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();
            linkLabel_Rgister_pic.Click += LinkLabel_Rgister_pic_Click;
            kryptonButton_clear_update_Rg.Click += KryptonButton_clear_update_Rg_Click;
        }

        private void KryptonButton_clear_update_Rg_Click(object sender, EventArgs e)
        {
            Worker_Register_services _col = new Worker_Register_services();

            var ms = new MemoryStream();
            pictureBox_Register.Image.Save(ms, pictureBox_Register.Image.RawFormat);
            byte[] img = ms.GetBuffer();
            ms.Close();

            _col.AddDataEntry(textBox_Worker_ID_Rg.Text, textBox_Fname_Rg.Text, textBox_Lname_Rg.Text, DateTime.Parse(dateTimePicker_DOB.Text), comboBox_grnder_Rg.Text, int.Parse(textBox_Pnumber_Rg.Text), textBox_NIC_Rg.Text, textBox_Address_Rg.Text, textBox_State_Rg.Text, textBox_City_Rg.Text, textBox_Email_Rg.Text, textBox_Qualification_Rg.Text, textBox_Extaskills_Rg.Text, img);
            MessageBox.Show("Data Register Successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAll();
            ListData();
        }

       

        private void LinkLabel_Rgister_pic_Click(object sender, EventArgs e)
        {
            var sa = new OpenFileDialog
            {
                Filter = "JPEG * .jpg|*.jpg|PNG *.png|*.png"
            };

            if (sa.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Register.Load(sa.FileName);
            }
            sa.Dispose();
        }


        void ClearAll()
        {
            textBox_Worker_ID_Rg.Clear();
            textBox_Fname_Rg.Clear();
            textBox_Lname_Rg.Clear();
            textBox_Pnumber_Rg.Clear();
            textBox_NIC_Rg.Clear();
            textBox_Address_Rg.Clear();
            textBox_State_Rg.Clear();
            textBox_City_Rg.Clear();
            textBox_Email_Rg.Clear();
            textBox_Qualification_Rg.Clear();
            textBox_Extaskills_Rg.Clear() ;

        }

        void ListData()
        {
            Worker_Register_services Data = new Worker_Register_services();
            dataGridView_Register_data.DataSource = Data.ListAll();
        }

        
    }
}
