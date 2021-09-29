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
    public partial class Form1 : Form
    {
        private Form FormBook;
        private Form FormUser;
        public Form1()
        {
            InitializeComponent();

            lblTotalBooks.Text = DataManager.Books.Count.ToString();
            lblTotalUsers.Text = DataManager.Users.Count.ToString();
            lblRentBooks.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            lblOverdueBooks.Text = DataManager.Books.Where((x) => {
                // (빌린날짜 + 14)가 오늘보다 이르면(적으면) 연체된 거
                return x.isBorrowed && x.BorrowedAt.AddDays(14) < DateTime.Now;
            }).Count().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FormBook is null)
            {
                FormBook = new FormBook();
            }
            FormBook.ShowDialog();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormUser is null)
            {
                FormUser = new FormUser();
            }
            FormUser.ShowDialog();
        }
    }
}
