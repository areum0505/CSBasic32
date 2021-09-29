using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class FormMain : Form
    {
        private Form FormBook;
        private Form FormUser;
        public FormMain()
        {
            InitializeComponent();

            // DataGridView
            dataGridView1.DataSource = DataManager.Books;
            dataGridView2.DataSource = DataManager.Users;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
            dataGridView2.CurrentCellChanged += dataGridView2_CurrentCellChanged;

            // Label
            lblTotalBooks.Text = DataManager.Books.Count.ToString();
            lblTotalUsers.Text = DataManager.Users.Count.ToString();
            lblRentBooks.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            lblOverdueBooks.Text = DataManager.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now;
            }).Count().ToString();

            // Button
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FormBook is null) { FormBook = new FormBook(); }
            FormBook.ShowDialog();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormUser is null) { FormUser = new FormUser(); }
            FormUser.ShowDialog();
        }
    }
}
