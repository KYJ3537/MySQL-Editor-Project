namespace MySQL_Editor_Project
{
    partial class FindPassword
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.findpw_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timepicker_findpw_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_findpw_email = new System.Windows.Forms.TextBox();
            this.txt_findpw_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySQL_Editor_Project.Properties.Resources.login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // findpw_btn
            // 
            this.findpw_btn.Location = new System.Drawing.Point(13, 240);
            this.findpw_btn.Name = "findpw_btn";
            this.findpw_btn.Size = new System.Drawing.Size(285, 83);
            this.findpw_btn.TabIndex = 28;
            this.findpw_btn.Text = "비밀번호 찾기";
            this.findpw_btn.UseVisualStyleBackColor = true;
            this.findpw_btn.Click += new System.EventHandler(this.findpw_btn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "생년월일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "이메일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "아이디";
            // 
            // timepicker_findpw_birth
            // 
            this.timepicker_findpw_birth.Location = new System.Drawing.Point(70, 209);
            this.timepicker_findpw_birth.Name = "timepicker_findpw_birth";
            this.timepicker_findpw_birth.Size = new System.Drawing.Size(227, 23);
            this.timepicker_findpw_birth.TabIndex = 24;
            this.timepicker_findpw_birth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txt_findpw_email
            // 
            this.txt_findpw_email.Location = new System.Drawing.Point(70, 180);
            this.txt_findpw_email.Name = "txt_findpw_email";
            this.txt_findpw_email.Size = new System.Drawing.Size(227, 23);
            this.txt_findpw_email.TabIndex = 23;
            // 
            // txt_findpw_id
            // 
            this.txt_findpw_id.Location = new System.Drawing.Point(70, 151);
            this.txt_findpw_id.Name = "txt_findpw_id";
            this.txt_findpw_id.Size = new System.Drawing.Size(227, 23);
            this.txt_findpw_id.TabIndex = 22;
            // 
            // FindPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 337);
            this.Controls.Add(this.findpw_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timepicker_findpw_birth);
            this.Controls.Add(this.txt_findpw_email);
            this.Controls.Add(this.txt_findpw_id);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FindPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "비밀번호 찾기";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button findpw_btn;
        private Label label5;
        private Label label4;
        private Label label1;
        private DateTimePicker timepicker_findpw_birth;
        private TextBox txt_findpw_email;
        private TextBox txt_findpw_id;
    }
}