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

namespace CSBasic10_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button button = new Button();
            button.Text = "버튼";
            button.Click += delegate (object sender, EventArgs args)
            {
                MessageBox.Show("무명 델리케이터를 사용한 이벤트 연결입니다");
            };
            button.Click += (sender, args) =>
            {
                // MessageBox.Show("람다를 사용한 이벤트 연결입니다");
                saveFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt";
                saveFileDialog1.ShowDialog();
                MessageBox.Show(saveFileDialog1.FileName);
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            };
            Controls.Add(button);
        }
    }
}
