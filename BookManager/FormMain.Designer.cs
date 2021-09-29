
namespace BookManager
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ISBN;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOverdueBooks = new System.Windows.Forms.Label();
            this.lblRentBooks = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBorrowedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.borrowedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ISBN = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.Location = new System.Drawing.Point(40, 29);
            ISBN.Name = "ISBN";
            ISBN.Size = new System.Drawing.Size(39, 15);
            ISBN.TabIndex = 8;
            ISBN.Text = "ISBN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도서관리ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도서관리ToolStripMenuItem
            // 
            this.도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem";
            this.도서관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.도서관리ToolStripMenuItem.Text = "도서관리";
            this.도서관리ToolStripMenuItem.Click += new System.EventHandler(this.도서관리ToolStripMenuItem_Click);
            // 
            // 사용자관리ToolStripMenuItem
            // 
            this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
            this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.사용자관리ToolStripMenuItem.Text = "사용자 관리";
            this.사용자관리ToolStripMenuItem.Click += new System.EventHandler(this.사용자관리ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOverdueBooks);
            this.groupBox1.Controls.Add(this.lblRentBooks);
            this.groupBox1.Controls.Add(this.lblTotalUsers);
            this.groupBox1.Controls.Add(this.lblTotalBooks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서관 현황";
            // 
            // lblOverdueBooks
            // 
            this.lblOverdueBooks.AutoSize = true;
            this.lblOverdueBooks.Location = new System.Drawing.Point(164, 108);
            this.lblOverdueBooks.Name = "lblOverdueBooks";
            this.lblOverdueBooks.Size = new System.Drawing.Size(140, 15);
            this.lblOverdueBooks.TabIndex = 7;
            this.lblOverdueBooks.Text = "<lblOverdueBooks>";
            // 
            // lblRentBooks
            // 
            this.lblRentBooks.AutoSize = true;
            this.lblRentBooks.Location = new System.Drawing.Point(164, 84);
            this.lblRentBooks.Name = "lblRentBooks";
            this.lblRentBooks.Size = new System.Drawing.Size(114, 15);
            this.lblRentBooks.TabIndex = 6;
            this.lblRentBooks.Text = "<lblRentBooks>";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Location = new System.Drawing.Point(94, 60);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(111, 15);
            this.lblTotalUsers.TabIndex = 5;
            this.lblTotalUsers.Text = "<lblTotalUsers>";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Location = new System.Drawing.Point(114, 36);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(116, 15);
            this.lblTotalBooks.TabIndex = 4;
            this.lblTotalBooks.Text = "<lblTotalBooks>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "연제 중인 도서의 수 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "대출 중인 도서의 수 :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "사용자 수 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "전체 도서 수 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(ISBN);
            this.groupBox2.Location = new System.Drawing.Point(297, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여/반납";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 43);
            this.button2.TabIndex = 15;
            this.button2.Text = "반납";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "대여";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "사용자 ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "도서 이름";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 195);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도서현황";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.isBorrowedDataGridViewCheckBoxColumn,
            this.borrowedAtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(761, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(12, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 174);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "사용자 현황";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.userBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(762, 143);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "사용자 ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "시용자명";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BookManager.User);
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.isbnDataGridViewTextBoxColumn.Width = 68;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "책이름";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 81;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "출판사";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            this.publisherDataGridViewTextBoxColumn.Width = 81;
            // 
            // pageDataGridViewTextBoxColumn
            // 
            this.pageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
            this.pageDataGridViewTextBoxColumn.HeaderText = "쪽수";
            this.pageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
            this.pageDataGridViewTextBoxColumn.ReadOnly = true;
            this.pageDataGridViewTextBoxColumn.Width = 66;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "대출 사용자 ID";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 93;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "대출 사용자명";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 93;
            // 
            // isBorrowedDataGridViewCheckBoxColumn
            // 
            this.isBorrowedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isBorrowedDataGridViewCheckBoxColumn.DataPropertyName = "isBorrowed";
            this.isBorrowedDataGridViewCheckBoxColumn.HeaderText = "대출여부";
            this.isBorrowedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isBorrowedDataGridViewCheckBoxColumn.Name = "isBorrowedDataGridViewCheckBoxColumn";
            this.isBorrowedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isBorrowedDataGridViewCheckBoxColumn.Width = 52;
            // 
            // borrowedAtDataGridViewTextBoxColumn
            // 
            this.borrowedAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.borrowedAtDataGridViewTextBoxColumn.DataPropertyName = "BorrowedAt";
            this.borrowedAtDataGridViewTextBoxColumn.HeaderText = "대출시간";
            this.borrowedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borrowedAtDataGridViewTextBoxColumn.Name = "borrowedAtDataGridViewTextBoxColumn";
            this.borrowedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowedAtDataGridViewTextBoxColumn.Width = 75;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BookManager.Book);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 572);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "도서관 관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOverdueBooks;
        private System.Windows.Forms.Label lblRentBooks;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBorrowedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}

