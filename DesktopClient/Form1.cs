using Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient
{
    public partial class Form1 : Form
    {
        private static readonly IRepository repository = RepositoryFactory.GetRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillUsers();
            FillItems();
;
        }

        private void FillUsers()
        {
            CBUsers.DataSource = repository.GetUsers().ToList();
        }

        private void FillItems()
        {
            ListBoxItems.DataSource = repository.GetItems().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormValid())
            {
                repository.AddItem(new TodoItem{
                    Id = int.Parse(TbID.Text.Trim()),
                    Description = TbDesc.Text.Trim(),
                    Date = DtPDate.Value,
                    User = CBUsers.SelectedItem as User
                });
                FillItems();
                ClearForm();
            }

        }

        private void ClearForm()
        {
            TbID.Text = string.Empty;
            TbDesc.Text = string.Empty;
            DtPDate.Value = DateTime.Now;
        }

        private bool FormValid()
        {
            if (!int.TryParse(TbID.Text.Trim(), out int id))
            {
                MessageBox.Show("Id must be integer!");
                return false;
            }

            if (string.IsNullOrEmpty(TbDesc.Text.Trim()))
            {
                MessageBox.Show("Desc is obligatory!");
                return false;
            }

            return true;
        }
    }
}
