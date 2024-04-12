namespace MySQL_Editor_Project
{
    partial class BookView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookView));
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.title_panel = new System.Windows.Forms.Panel();
            this.book_title_label = new System.Windows.Forms.Label();
            this.book_genrn_label = new System.Windows.Forms.Label();
            this.book_writer_label = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.book_contents_label = new System.Windows.Forms.Label();
            this.book_image = new System.Windows.Forms.PictureBox();
            this.checkOut_btn = new System.Windows.Forms.Button();
            this.exit_btn2 = new System.Windows.Forms.Button();
            this.book_number_label = new System.Windows.Forms.Label();
            this.book_last_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            this.title_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_image)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.Location = new System.Drawing.Point(500, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(37, 37);
            this.exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_btn.TabIndex = 0;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // title_panel
            // 
            this.title_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("title_panel.BackgroundImage")));
            this.title_panel.Controls.Add(this.exit_btn);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_panel.Location = new System.Drawing.Point(0, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(543, 37);
            this.title_panel.TabIndex = 1;
            this.title_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseDown);
            this.title_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseMove);
            // 
            // book_title_label
            // 
            this.book_title_label.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_title_label.Location = new System.Drawing.Point(12, 49);
            this.book_title_label.Name = "book_title_label";
            this.book_title_label.Size = new System.Drawing.Size(519, 23);
            this.book_title_label.TabIndex = 3;
            this.book_title_label.Text = "제목";
            this.book_title_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // book_genrn_label
            // 
            this.book_genrn_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_genrn_label.Location = new System.Drawing.Point(12, 74);
            this.book_genrn_label.Name = "book_genrn_label";
            this.book_genrn_label.Size = new System.Drawing.Size(519, 23);
            this.book_genrn_label.TabIndex = 4;
            this.book_genrn_label.Text = "장르";
            this.book_genrn_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // book_writer_label
            // 
            this.book_writer_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_writer_label.Location = new System.Drawing.Point(12, 97);
            this.book_writer_label.Name = "book_writer_label";
            this.book_writer_label.Size = new System.Drawing.Size(519, 26);
            this.book_writer_label.TabIndex = 5;
            this.book_writer_label.Text = "글쓴이";
            this.book_writer_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.line1.Location = new System.Drawing.Point(12, 128);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(519, 2);
            this.line1.TabIndex = 6;
            this.line1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // book_contents_label
            // 
            this.book_contents_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.book_contents_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_contents_label.ForeColor = System.Drawing.Color.White;
            this.book_contents_label.Location = new System.Drawing.Point(239, 143);
            this.book_contents_label.Name = "book_contents_label";
            this.book_contents_label.Size = new System.Drawing.Size(292, 298);
            this.book_contents_label.TabIndex = 7;
            this.book_contents_label.Text = "책내용";
            // 
            // book_image
            // 
            this.book_image.BackColor = System.Drawing.Color.White;
            this.book_image.Location = new System.Drawing.Point(12, 143);
            this.book_image.Name = "book_image";
            this.book_image.Size = new System.Drawing.Size(221, 298);
            this.book_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.book_image.TabIndex = 8;
            this.book_image.TabStop = false;
            this.book_image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkOut_btn
            // 
            this.checkOut_btn.Location = new System.Drawing.Point(239, 449);
            this.checkOut_btn.Name = "checkOut_btn";
            this.checkOut_btn.Size = new System.Drawing.Size(192, 55);
            this.checkOut_btn.TabIndex = 9;
            this.checkOut_btn.Text = "대출하기";
            this.checkOut_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn2
            // 
            this.exit_btn2.Location = new System.Drawing.Point(437, 449);
            this.exit_btn2.Name = "exit_btn2";
            this.exit_btn2.Size = new System.Drawing.Size(94, 55);
            this.exit_btn2.TabIndex = 10;
            this.exit_btn2.Text = "취소";
            this.exit_btn2.UseVisualStyleBackColor = true;
            this.exit_btn2.Click += new System.EventHandler(this.exit_btn2_Click);
            // 
            // book_number_label
            // 
            this.book_number_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_number_label.Location = new System.Drawing.Point(12, 478);
            this.book_number_label.Name = "book_number_label";
            this.book_number_label.Size = new System.Drawing.Size(221, 26);
            this.book_number_label.TabIndex = 11;
            this.book_number_label.Text = "고유번호";
            this.book_number_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.book_number_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // book_last_label
            // 
            this.book_last_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_last_label.Location = new System.Drawing.Point(12, 452);
            this.book_last_label.Name = "book_last_label";
            this.book_last_label.Size = new System.Drawing.Size(221, 26);
            this.book_last_label.TabIndex = 12;
            this.book_last_label.Text = "남은 재고 수 : NULL";
            this.book_last_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 515);
            this.Controls.Add(this.book_last_label);
            this.Controls.Add(this.book_number_label);
            this.Controls.Add(this.exit_btn2);
            this.Controls.Add(this.checkOut_btn);
            this.Controls.Add(this.book_image);
            this.Controls.Add(this.book_contents_label);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.book_writer_label);
            this.Controls.Add(this.book_genrn_label);
            this.Controls.Add(this.book_title_label);
            this.Controls.Add(this.title_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "책 대출하기";
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            this.title_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.book_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox exit_btn;
        private Panel title_panel;
        private Label book_title_label;
        private Label book_genrn_label;
        private Label book_writer_label;
        private Label line1;
        private Label book_contents_label;
        private PictureBox book_image;
        private Button checkOut_btn;
        private Button exit_btn2;
        private Label book_number_label;
        private Label book_last_label;
    }
}