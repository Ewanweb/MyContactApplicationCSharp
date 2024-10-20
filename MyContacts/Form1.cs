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
    }
}
