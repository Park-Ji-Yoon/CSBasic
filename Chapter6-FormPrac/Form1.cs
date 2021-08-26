using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6_FormPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None;
            if (sender == btnMessageBox1)
            {
                result = MessageBox.Show("안녕하세요?");
            }else if(sender == btnMessageBox2)
            {
                result = MessageBox.Show("안녕하세요?", "환영인사");
            }
            else if (sender == btnMessageBox3)
            {
                result = MessageBox.Show("안녕하세요?", "환영인사",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question

                    );
            }

            switch (result)
            {
                case DialogResult.OK:
                case DialogResult.Yes:
                    MessageBox.Show("좋은 하루~", "시스템");
                    break;
                case DialogResult.No:
                    MessageBox.Show("가서 쉬세요!", "시스템");
                    break;
            }
        }

        private void btnModeless_Click(object sender, EventArgs e)
        {
            Form form = new FormCustom();
            if(sender == btnModeless)
            {
                form.Show();
            }else if(sender == btnModal)
            {
                form.ShowDialog();
            }
        }
    }
}
