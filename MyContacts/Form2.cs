using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyContacts.Repository;
using MyContacts.Services;

namespace MyContacts
{
    public partial class AddOrEdit : Form
    {
        IContactsRepository repository;
        public AddOrEdit()
        {
            InitializeComponent();
            repository = new ContactRepository();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddOrEdit_Load(object sender, EventArgs e)
        {
            this.Text = "افزودن شخص جدید";
        }

        bool validateInputs()
        {
           
            if (txtName.Text == "")
            {
                MessageBox.Show("لطفا نام را وارد کنید","هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("لطفا ایمیل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAge.Text == "0")
            {
                MessageBox.Show("لطفا سن را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("لطفا موبایل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("لطفا آدرس را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                int age;
                if (!int.TryParse(txtAge.Text, out age))
                {
                    MessageBox.Show("سن وارد شده معتبر نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool isSuccess = repository.Insert(txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, age, txtAddress.Text);
               if (isSuccess == true)
               {
                   MessageBox.Show("عملیات با موفقیت انجام شد", "اضافه شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   DialogResult = DialogResult.OK;
               }
               else
               {
                   MessageBox.Show("عملیات شکست خورد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }
    }
}
