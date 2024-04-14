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

        private bool Login_funtion()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();
                int login_status = 0;
                string loginid = txt_Login_id.Text;
                string loginpwd = txt_Login_pw.Text;

                string send_login_query = "SELECT * FROM accounts WHERE id = '" + loginid + "' ";

                MySqlCommand Selectcommand = new MySqlCommand(send_login_query, connection);
                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["id"] && loginpwd == (string)userAccount["password"])
                    {
                        login_status = 1;
                    }
                }

                userAccount.Close();

                if (login_status == 1) //로그인 성공시
                {
                    //현재 시간 string 변수로 lastlogin 컬럼 데이터 규격에 맞게 변환
                    DateTime currentTime = DateTime.Now;
                    string nowTime = currentTime.ToString("yyyy-MM-dd hh:mm:ss");

                    //라스트 로그인 UPDATE문
                    string updateQuery = "UPDATE accounts SET lastlogin = '" + nowTime + "' WHERE id = '" + loginid + "'";

                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("마지막 로그인 업데이트 실패");
                        return false;
                    }

                }
                else
                {
                    connection.Close();
                    return false;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        private bool Register_funtion()
        {
            try
            {

                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                // 해당 아이디가 이미 존재하는지 확인하는 쿼리
                string checkQuery = "SELECT COUNT(*) FROM accounts WHERE id = \'" + txt_register_id.Text + "\' ";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                // 아이디가 존재하면 회원가입 거부 후 반환
                if (count > 0)
                {
                    connection.Close();
                    MessageBox.Show("이미 존재하는 아이디입니다.");
                    return false;
                }

                // 생년월일을 birthday 컬럼 데이터 규격에 맞게 변환
                timepicker_birth.CustomFormat = "yyyy-MM-dd hh:mm:ss";

                //현재 시간 string 변수로 lastlogin 컬럼 데이터 규격에 맞게 변환
                DateTime currentTime = DateTime.Now;
                string nowTime = currentTime.ToString("yyyy-MM-dd hh:mm:ss");

                string insertQuery = "INSERT INTO accounts (id, password, email, birthday, lastlogin) VALUES ('" + txt_register_id.Text +
                                                                                                  "', '" + txt_register_pw.Text +
                                                                                                  "', '" + txt_register_email.Text +
                                                                                                  "', '" + timepicker_birth.Text +
                                                                                                  "', '" + nowTime + "');";

                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("회원가입 오류 발생");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_Login_id.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }
            else if (txt_Login_pw.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                return;
            }

            if (Login_funtion() == true)
            {
                MessageBox.Show("로그인 성공");

                // Main 윈도우 폼 생성
                Main mainForm = new Main();
                mainForm.main_id_label.Text = txt_Login_id.Text + "님 환영합니다.";
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("로그인 실패");
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

            if (Register_funtion() == true)
            {
                MessageBox.Show("회원가입 완료");
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
