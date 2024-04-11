using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MySQL_Editor_Project
{
    public partial class Invite : Form
    {
        public Invite()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_Login_id.Text == "")//
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            } else if (txt_Login_pw.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                return;
            }


        }

        private void register_btn_Click(object sender, EventArgs e)
        {

            if (txt_register_id.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }
            else if (txt_register_pw.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                return;
            }
            else if (txt_register_2ndpw.Text == "")
            {
                MessageBox.Show("비밀번호 재입력 칸에 입력해주세요.");
                return;
            }
            else if (txt_register_email.Text == "")
            {
                MessageBox.Show("이메일을 입력해주세요.");
                return;
            }

            if (txt_register_pw.Text != txt_register_2ndpw.Text)
            {
                MessageBox.Show("비밀번호와 비밀번호 재입력이 일치하지 않습니다.");
                return;
            }

        }

        private void label_find_id_Click(object sender, EventArgs e)
        {
            FindPassword findpassword = new FindPassword();
            findpassword.Show();
            findpassword.BringToFront();
        }

        private void Invite_Load(object sender, EventArgs e)
        {

        }
    }
}
