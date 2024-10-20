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
    public partial class Form1 : Form
    {
        private IContactsRepository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new ContactRepository();
        }


        private void BindGrid()
        {
            dgContact.AutoGenerateColumns = false;
            dgContact.DataSource = repository.SelectAll();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void tspInsert_Click(object sender, EventArgs e)
        {
            AddOrEdit frm = new AddOrEdit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgContact.CurrentRow != null)
            {
                string name = dgContact.CurrentRow.Cells[1].Value.ToString();
                string family = dgContact.CurrentRow.Cells[2].Value.ToString();
                string fullName = name + ' ' + family;
                if (MessageBox.Show($"آیا از حذف {fullName} مطمئن هستید؟","هشدار",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    int contactId = int.Parse(dgContact.CurrentRow.Cells[0].Value.ToString());
                    repository.Delete(contactId);
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را انتخاب کنید", "هشدار",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgContact.CurrentRow != null)
            {
                int contactId = int.Parse(dgContact.CurrentRow.Cells[0].Value.ToString());
                AddOrEdit frm = new AddOrEdit();
                frm.contactId = contactId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgContact.DataSource = repository.Search(txtSearch.Text);
        }
    }
}
