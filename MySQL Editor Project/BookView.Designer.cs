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
            this.bv_title_label = new System.Windows.Forms.Label();
            this.bv_genrn_label = new System.Windows.Forms.Label();
            this.bv_writer_label = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.bv_contents_label = new System.Windows.Forms.Label();
            this.bv_image = new System.Windows.Forms.PictureBox();
            this.checkOut_btn = new System.Windows.Forms.Button();
            this.exit_btn2 = new System.Windows.Forms.Button();
            this.bv_number_label = new System.Windows.Forms.Label();
            this.bv_last_label = new System.Windows.Forms.Label();
            this.bv_image_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            this.title_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bv_image)).BeginInit();
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
            // bv_title_label
            // 
            this.bv_title_label.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bv_title_label.Location = new System.Drawing.Point(12, 49);
            this.bv_title_label.Name = "bv_title_label";
            this.bv_title_label.Size = new System.Drawing.Size(519, 23);
            this.bv_title_label.TabIndex = 3;
            this.bv_title_label.Text = "제목";
            this.bv_title_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bv_genrn_label
            // 
            this.bv_genrn_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bv_genrn_label.Location = new System.Drawing.Point(12, 74);
            this.bv_genrn_label.Name = "bv_genrn_label";
            this.bv_genrn_label.Size = new System.Drawing.Size(519, 23);
            this.bv_genrn_label.TabIndex = 4;
            this.bv_genrn_label.Text = "장르";
            this.bv_genrn_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bv_writer_label
            // 
            this.bv_writer_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bv_writer_label.Location = new System.Drawing.Point(12, 97);
            this.bv_writer_label.Name = "bv_writer_label";
            this.bv_writer_label.Size = new System.Drawing.Size(519, 26);
            this.bv_writer_label.TabIndex = 5;
            this.bv_writer_label.Text = "글쓴이";
            this.bv_writer_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // bv_contents_label
            // 
            this.bv_contents_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bv_contents_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bv_contents_label.ForeColor = System.Drawing.Color.White;
            this.bv_contents_label.Location = new System.Drawing.Point(239, 143);
            this.bv_contents_label.Name = "bv_contents_label";
            this.bv_contents_label.Size = new System.Drawing.Size(292, 298);
            this.bv_contents_label.TabIndex = 7;
            this.bv_contents_label.Text = "책 내용";
            // 
            // bv_image
            // 
            this.bv_image.BackColor = System.Drawing.Color.White;
            this.bv_image.Location = new System.Drawing.Point(12, 143);
            this.bv_image.Name = "bv_image";
            this.bv_image.Size = new System.Drawing.Size(221, 298);
            this.bv_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bv_image.TabIndex = 8;
            this.bv_image.TabStop = false;
            this.bv_image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkOut_btn
            // 
            this.checkOut_btn.Location = new System.Drawing.Point(239, 449);
            this.checkOut_btn.Name = "checkOut_btn";
            this.checkOut_btn.Size = new System.Drawing.Size(192, 55);
            this.checkOut_btn.TabIndex = 9;
            this.checkOut_btn.Text = "대출하기";
            this.checkOut_btn.UseVisualStyleBackColor = true;
            this.checkOut_btn.Click += new System.EventHandler(this.checkOut_btn_Click);
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
            // bv_number_label
            // 
            this.bv_number_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bv_number_label.Location = new System.Drawing.Point(12, 478);
            this.bv_number_label.Name = "bv_number_label";
            this.bv_number_label.Size = new System.Drawing.Size(221, 26);
            this.bv_number_label.TabIndex = 11;
            this.bv_number_label.Text = "고유번호";
            this.bv_number_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bv_number_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // bv_last_label
            // 
            this.bv_last_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bv_last_label.Location = new System.Drawing.Point(12, 452);
            this.bv_last_label.Name = "bv_last_label";
            this.bv_last_label.Size = new System.Drawing.Size(221, 26);
            this.bv_last_label.TabIndex = 12;
            this.bv_last_label.Text = "남은 재고 수 : NULL";
            this.bv_last_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bv_image_txt
            // 
            this.bv_image_txt.Location = new System.Drawing.Point(12, 418);
            this.bv_image_txt.Name = "bv_image_txt";
            this.bv_image_txt.Size = new System.Drawing.Size(221, 23);
            this.bv_image_txt.TabIndex = 14;
            this.bv_image_txt.TextChanged += new System.EventHandler(this.bv_image_txt_TextChanged);
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 515);
            this.Controls.Add(this.bv_image_txt);
            this.Controls.Add(this.bv_last_label);
            this.Controls.Add(this.bv_number_label);
            this.Controls.Add(this.exit_btn2);
            this.Controls.Add(this.checkOut_btn);
            this.Controls.Add(this.bv_image);
            this.Controls.Add(this.bv_contents_label);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.bv_writer_label);
            this.Controls.Add(this.bv_genrn_label);
            this.Controls.Add(this.bv_title_label);
            this.Controls.Add(this.title_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "책 대출하기";
            this.Load += new System.EventHandler(this.BookView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            this.title_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bv_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox exit_btn;
        private Panel title_panel;
        private Label line1;
        private Button checkOut_btn;
        private Button exit_btn2;
        public Label bv_title_label;
        public Label bv_genrn_label;
        public Label bv_writer_label;
        public PictureBox bv_image;
        public Label bv_contents_label;
        public Label bv_last_label;
        public Label bv_number_label;
        public TextBox bv_image_txt;
    }
}