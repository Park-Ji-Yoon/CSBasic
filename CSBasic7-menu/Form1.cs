using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSBasic7_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            상태표시줄ToolStripMenuItem.Checked = !상태표시줄ToolStripMenuItem.Checked;
            toolStrip1.Visible = 상태표시줄ToolStripMenuItem.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(progressBar2.Value + 10 < progressBar2.Maximum)
            {
                progressBar2.Value += 10;
            }
            else
            {
                progressBar2.Value = progressBar2.Maximum;
            }
            
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fake 메모장!!", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
