namespace MySQL_Editor_Project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.title_panel = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.main_tab = new System.Windows.Forms.TabControl();
            this.main_tabpage1 = new System.Windows.Forms.TabPage();
            this.search_book_listview = new System.Windows.Forms.ListView();
            this.search_book_listview_columnHeader0 = new System.Windows.Forms.ColumnHeader();
            this.search_book_listview_columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.search_book_listview_columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.search_book_listview_columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.search_book_listview_columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.search_book_listview_columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.search_book_listview_columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.main_tabpage2 = new System.Windows.Forms.TabPage();
            this.mybook_listview = new System.Windows.Forms.ListView();
            this.mybook_columnHeader0 = new System.Windows.Forms.ColumnHeader();
            this.mybook_columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.mybook_columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.mybook_columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.mybook_columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.mybook_columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.mybook_columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.mybook_columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.mybook_columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.main_tabpage3 = new System.Windows.Forms.TabPage();
            this.title_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            this.main_tab.SuspendLayout();
            this.main_tabpage1.SuspendLayout();
            this.main_tabpage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_panel
            // 
            this.title_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("title_panel.BackgroundImage")));
            this.title_panel.Controls.Add(this.exit_btn);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_panel.Location = new System.Drawing.Point(0, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(1033, 37);
            this.title_panel.TabIndex = 0;
            this.title_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.title_panel_Paint);
            this.title_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseDown);
            this.title_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseMove);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.Location = new System.Drawing.Point(993, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(37, 37);
            this.exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_btn.TabIndex = 0;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // main_tab
            // 
            this.main_tab.Controls.Add(this.main_tabpage1);
            this.main_tab.Controls.Add(this.main_tabpage2);
            this.main_tab.Controls.Add(this.main_tabpage3);
            this.main_tab.Location = new System.Drawing.Point(12, 45);
            this.main_tab.Name = "main_tab";
            this.main_tab.SelectedIndex = 0;
            this.main_tab.Size = new System.Drawing.Size(1009, 540);
            this.main_tab.TabIndex = 1;
            // 
            // main_tabpage1
            // 
            this.main_tabpage1.Controls.Add(this.search_book_listview);
            this.main_tabpage1.Controls.Add(this.search_btn);
            this.main_tabpage1.Controls.Add(this.search_txt);
            this.main_tabpage1.Location = new System.Drawing.Point(4, 24);
            this.main_tabpage1.Name = "main_tabpage1";
            this.main_tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.main_tabpage1.Size = new System.Drawing.Size(1001, 512);
            this.main_tabpage1.TabIndex = 0;
            this.main_tabpage1.Text = "책 대출하기";
            this.main_tabpage1.UseVisualStyleBackColor = true;
            // 
            // search_book_listview
            // 
            this.search_book_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.search_book_listview_columnHeader0,
            this.search_book_listview_columnHeader1,
            this.search_book_listview_columnHeader2,
            this.search_book_listview_columnHeader3,
            this.search_book_listview_columnHeader4,
            this.search_book_listview_columnHeader5,
            this.search_book_listview_columnHeader6});
            this.search_book_listview.Location = new System.Drawing.Point(13, 42);
            this.search_book_listview.MultiSelect = false;
            this.search_book_listview.Name = "search_book_listview";
            this.search_book_listview.Size = new System.Drawing.Size(978, 464);
            this.search_book_listview.TabIndex = 2;
            this.search_book_listview.UseCompatibleStateImageBehavior = false;
            this.search_book_listview.View = System.Windows.Forms.View.Details;
            // 
            // search_book_listview_columnHeader0
            // 
            this.search_book_listview_columnHeader0.Text = "책 인덱스";
            this.search_book_listview_columnHeader0.Width = 100;
            // 
            // search_book_listview_columnHeader1
            // 
            this.search_book_listview_columnHeader1.Text = "이름";
            this.search_book_listview_columnHeader1.Width = 150;
            // 
            // search_book_listview_columnHeader2
            // 
            this.search_book_listview_columnHeader2.Text = "글쓴이";
            this.search_book_listview_columnHeader2.Width = 100;
            // 
            // search_book_listview_columnHeader3
            // 
            this.search_book_listview_columnHeader3.Text = "장르";
            this.search_book_listview_columnHeader3.Width = 100;
            // 
            // search_book_listview_columnHeader4
            // 
            this.search_book_listview_columnHeader4.Text = "설명";
            this.search_book_listview_columnHeader4.Width = 420;
            // 
            // search_book_listview_columnHeader5
            // 
            this.search_book_listview_columnHeader5.Text = "고유번호";
            this.search_book_listview_columnHeader5.Width = 110;
            // 
            // search_book_listview_columnHeader6
            // 
            this.search_book_listview_columnHeader6.Text = "현재 남은 재고";
            this.search_book_listview_columnHeader6.Width = 95;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(921, 9);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(70, 24);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(13, 10);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(902, 23);
            this.search_txt.TabIndex = 0;
            this.search_txt.Text = "책 이름, 책 글쓴이, 책 설명, 책 고유번호의 일부를 입력 후 검색을 눌러주세요.";
            // 
            // main_tabpage2
            // 
            this.main_tabpage2.Controls.Add(this.mybook_listview);
            this.main_tabpage2.Location = new System.Drawing.Point(4, 24);
            this.main_tabpage2.Name = "main_tabpage2";
            this.main_tabpage2.Padding = new System.Windows.Forms.Padding(3);
            this.main_tabpage2.Size = new System.Drawing.Size(1001, 512);
            this.main_tabpage2.TabIndex = 1;
            this.main_tabpage2.Text = "내가 빌린 도서 목록";
            this.main_tabpage2.UseVisualStyleBackColor = true;
            // 
            // mybook_listview
            // 
            this.mybook_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mybook_columnHeader0,
            this.mybook_columnHeader1,
            this.mybook_columnHeader2,
            this.mybook_columnHeader3,
            this.mybook_columnHeader4,
            this.mybook_columnHeader5,
            this.mybook_columnHeader6,
            this.mybook_columnHeader7,
            this.mybook_columnHeader8});
            this.mybook_listview.Location = new System.Drawing.Point(12, 6);
            this.mybook_listview.Name = "mybook_listview";
            this.mybook_listview.Size = new System.Drawing.Size(977, 500);
            this.mybook_listview.TabIndex = 3;
            this.mybook_listview.UseCompatibleStateImageBehavior = false;
            this.mybook_listview.View = System.Windows.Forms.View.Details;
            // 
            // mybook_columnHeader0
            // 
            this.mybook_columnHeader0.Text = "책 인덱스";
            this.mybook_columnHeader0.Width = 100;
            // 
            // mybook_columnHeader1
            // 
            this.mybook_columnHeader1.Text = "이름";
            this.mybook_columnHeader1.Width = 150;
            // 
            // mybook_columnHeader2
            // 
            this.mybook_columnHeader2.Text = "글쓴이";
            this.mybook_columnHeader2.Width = 100;
            // 
            // mybook_columnHeader3
            // 
            this.mybook_columnHeader3.Text = "장르";
            this.mybook_columnHeader3.Width = 220;
            // 
            // mybook_columnHeader4
            // 
            this.mybook_columnHeader4.Text = "설명";
            this.mybook_columnHeader4.Width = 110;
            // 
            // mybook_columnHeader5
            // 
            this.mybook_columnHeader5.Text = "고유번호";
            this.mybook_columnHeader5.Width = 150;
            // 
            // mybook_columnHeader6
            // 
            this.mybook_columnHeader6.Text = "상태";
            this.mybook_columnHeader6.Width = 150;
            // 
            // mybook_columnHeader7
            // 
            this.mybook_columnHeader7.Text = "대출 날짜";
            // 
            // mybook_columnHeader8
            // 
            this.mybook_columnHeader8.Text = "반납 날짜";
            // 
            // main_tabpage3
            // 
            this.main_tabpage3.Location = new System.Drawing.Point(4, 24);
            this.main_tabpage3.Name = "main_tabpage3";
            this.main_tabpage3.Size = new System.Drawing.Size(1001, 512);
            this.main_tabpage3.TabIndex = 2;
            this.main_tabpage3.Text = "관리자";
            this.main_tabpage3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 597);
            this.Controls.Add(this.main_tab);
            this.Controls.Add(this.title_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서관";
            this.title_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            this.main_tab.ResumeLayout(false);
            this.main_tabpage1.ResumeLayout(false);
            this.main_tabpage1.PerformLayout();
            this.main_tabpage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel title_panel;
        private PictureBox exit_btn;
        private TabControl main_tab;
        private TabPage main_tabpage1;
        private TabPage main_tabpage2;
        private TabPage main_tabpage3;
        private Button search_btn;
        private TextBox search_txt;
        private ListView search_book_listview;
        private ColumnHeader search_book_listview_columnHeader0;
        private ColumnHeader search_book_listview_columnHeader1;
        private ColumnHeader search_book_listview_columnHeader2;
        private ColumnHeader search_book_listview_columnHeader3;
        private ColumnHeader search_book_listview_columnHeader4;
        private ColumnHeader search_book_listview_columnHeader5;
        private ColumnHeader search_book_listview_columnHeader6;
        private ListView mybook_listview;
        private ColumnHeader mybook_columnHeader0;
        private ColumnHeader mybook_columnHeader1;
        private ColumnHeader mybook_columnHeader2;
        private ColumnHeader mybook_columnHeader3;
        private ColumnHeader mybook_columnHeader4;
        private ColumnHeader mybook_columnHeader5;
        private ColumnHeader mybook_columnHeader6;
        private ColumnHeader mybook_columnHeader7;
        private ColumnHeader mybook_columnHeader8;
    }
}