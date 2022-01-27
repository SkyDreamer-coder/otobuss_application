using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobus_application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtbEnter_Click(object sender, EventArgs e)
        {
            
            if (TxtUser.Text=="admin"&& TxtPassword.Text=="123")
            {
                if (RbAdmin.Checked==true)
                {
                    AdminForm adminform = new AdminForm();
                    this.Hide();
                    adminform.Show();
                }
                else
                {
                    CustomerForm adminform = new CustomerForm();
                    this.Hide();
                    adminform.Show();
                    
                }
            }
            else if (TxtUser.Text == "yolcu" && TxtPassword.Text == "123")
            {
                if (RbAdmin.Checked == true)
                {
                    MessageBox.Show("Yolcu Olduğunuz İçin Bu Alana Giriş Yetkiniz Bulunmamaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    CustomerForm adminform = new CustomerForm();
                    this.Hide();
                    adminform.Show();

                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
