using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MySQL_Editor_Project
{
    public partial class FindPassword : Form
    {
        public FindPassword()
        {
            InitializeComponent();
        }

        private int FindPassword_funtion()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                // 사용자가 입력한 정보와 일치하는 계정을 조회하는 쿼리

                timepicker_findpw_birth.CustomFormat = "yyyy-MM-dd hh:mm:ss";

                string find_query = "SELECT password FROM accounts WHERE id = '" + txt_findpw_id.Text +
                                                              "' AND email = '" + txt_findpw_email.Text +
                                                              "' AND birthday = '" + timepicker_findpw_birth.Text +
                                                              "'";

                MySqlCommand command = new MySqlCommand(find_query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                // 일치하는 계정이 있는 경우 비밀번호 반환
                if (reader.Read())
                {
                    string password = reader.GetString("password");
                    MessageBox.Show("아이디 " + txt_findpw_id.Text + "의 비밀번호\r\n\r\n" + password);
                    connection.Close();
                    this.Close();
                    return 0;
                }
                else
                {
                    MessageBox.Show("일치하는 아이디가 없습니다.");
                    connection.Close();
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void findpw_btn_Click_1(object sender, EventArgs e)
        {
            if (txt_findpw_id.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }
            else if (txt_findpw_email.Text == "")
            {
                MessageBox.Show("이메일을 입력해주세요.");
                return;
            }

            FindPassword_funtion();
        }
    }
}
