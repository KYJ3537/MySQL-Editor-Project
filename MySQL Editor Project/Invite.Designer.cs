namespace MySQL_Editor_Project
{
    partial class Invite
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_find_id = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_Login_pw = new System.Windows.Forms.TextBox();
            this.txt_Login_id = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timepicker_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_register_email = new System.Windows.Forms.TextBox();
            this.txt_register_2ndpw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_register_pw = new System.Windows.Forms.TextBox();
            this.txt_register_id = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(311, 317);
            this.tabControl1.TabIndex = 2;
            // 
            // tab
            // 
            this.tab.BackColor = System.Drawing.Color.White;
            this.tab.Controls.Add(this.pictureBox1);
            this.tab.Controls.Add(this.label6);
            this.tab.Controls.Add(this.label7);
            this.tab.Controls.Add(this.label_find_id);
            this.tab.Controls.Add(this.btn_login);
            this.tab.Controls.Add(this.txt_Login_pw);
            this.tab.Controls.Add(this.txt_Login_id);
            this.tab.Location = new System.Drawing.Point(4, 24);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(303, 289);
            this.tab.TabIndex = 0;
            this.tab.Text = "로그인";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySQL_Editor_Project.Properties.Resources.login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(88, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 133);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "패스워드";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "아이디";
            // 
            // label_find_id
            // 
            this.label_find_id.AutoSize = true;
            this.label_find_id.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label_find_id.ForeColor = System.Drawing.Color.Blue;
            this.label_find_id.Location = new System.Drawing.Point(91, 210);
            this.label_find_id.Name = "label_find_id";
            this.label_find_id.Size = new System.Drawing.Size(137, 15);
            this.label_find_id.TabIndex = 3;
            this.label_find_id.Text = "패스워드를 잊으셨나요?";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(7, 231);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(288, 52);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // txt_Login_pw
            // 
            this.txt_Login_pw.Location = new System.Drawing.Point(67, 174);
            this.txt_Login_pw.Name = "txt_Login_pw";
            this.txt_Login_pw.Size = new System.Drawing.Size(227, 23);
            this.txt_Login_pw.TabIndex = 1;
            // 
            // txt_Login_id
            // 
            this.txt_Login_id.Location = new System.Drawing.Point(67, 145);
            this.txt_Login_id.Name = "txt_Login_id";
            this.txt_Login_id.Size = new System.Drawing.Size(227, 23);
            this.txt_Login_id.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.timepicker_birth);
            this.tabPage2.Controls.Add(this.txt_register_email);
            this.tabPage2.Controls.Add(this.txt_register_2ndpw);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txt_register_pw);
            this.tabPage2.Controls.Add(this.txt_register_id);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(303, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "회원가입";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "생년월일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "이메일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "패스워드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "패스워드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "아이디";
            // 
            // timepicker_birth
            // 
            this.timepicker_birth.Location = new System.Drawing.Point(67, 161);
            this.timepicker_birth.Name = "timepicker_birth";
            this.timepicker_birth.Size = new System.Drawing.Size(227, 23);
            this.timepicker_birth.TabIndex = 8;
            // 
            // txt_register_email
            // 
            this.txt_register_email.Location = new System.Drawing.Point(67, 132);
            this.txt_register_email.Name = "txt_register_email";
            this.txt_register_email.Size = new System.Drawing.Size(227, 23);
            this.txt_register_email.TabIndex = 7;
            this.txt_register_email.Text = "이메일을 입력해주세요.";
            // 
            // txt_register_2ndpw
            // 
            this.txt_register_2ndpw.Location = new System.Drawing.Point(67, 103);
            this.txt_register_2ndpw.Name = "txt_register_2ndpw";
            this.txt_register_2ndpw.Size = new System.Drawing.Size(227, 23);
            this.txt_register_2ndpw.TabIndex = 6;
            this.txt_register_2ndpw.Text = "패스워드를 재입력해주세요";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_register_pw
            // 
            this.txt_register_pw.Location = new System.Drawing.Point(67, 74);
            this.txt_register_pw.Name = "txt_register_pw";
            this.txt_register_pw.Size = new System.Drawing.Size(227, 23);
            this.txt_register_pw.TabIndex = 4;
            this.txt_register_pw.Text = "패스워드를 입력해주세요";
            // 
            // txt_register_id
            // 
            this.txt_register_id.Location = new System.Drawing.Point(67, 45);
            this.txt_register_id.Name = "txt_register_id";
            this.txt_register_id.Size = new System.Drawing.Size(227, 23);
            this.txt_register_id.TabIndex = 3;
            this.txt_register_id.Text = "아이디를 입력해주세요";
            // 
            // Invite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 346);
            this.Controls.Add(this.tabControl1);
            this.Name = "Invite";
            this.Text = "Invite";
            this.tabControl1.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label_find_id;
        private Button btn_login;
        private TextBox txt_Login_pw;
        private TextBox txt_Login_id;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker timepicker_birth;
        private TextBox txt_register_email;
        private TextBox txt_register_2ndpw;
        private Button button1;
        private TextBox txt_register_pw;
        private TextBox txt_register_id;
    }
}