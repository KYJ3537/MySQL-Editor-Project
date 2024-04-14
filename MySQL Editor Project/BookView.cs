using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MySQL_Editor_Project
{
    public partial class BookView : Form
    {
        private Point Drag = new Point();
        public string bv_user_id = "";
        private string bv_account_index = "";
        private string bv_book_index = "";

        public BookView()
        {
            InitializeComponent();
            
        }

        private void pv_load_image_funtion()
        {
            // bv_image_label의 이미지 주소 가져오기
            string imageUrl = bv_image_txt.Text;

            // WebClient를 사용하여 이미지 다운로드
            using (WebClient webClient = new WebClient())
            {
                byte[] imageBytes = webClient.DownloadData(imageUrl);
                // 바이트 배열로부터 이미지 생성
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    // 이미지를 PictureBox에 설정
                    bv_image.Image = image;
                }
            }
        }

        private void borrow_funtion()
        {
            try
            {

                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                // accounts 테이블에서 primary key 값을 조회하여 bv_account_index에 할당
                string accountIndexQuery = "SELECT `index` FROM accounts WHERE id = '" + bv_user_id + "'";
                MySqlCommand accountIndexCommand = new MySqlCommand(accountIndexQuery, connection);
                object accountIndexResult = accountIndexCommand.ExecuteScalar();

                if (accountIndexResult != null)
                {
                    bv_account_index = accountIndexResult.ToString();
                } else
                {
                    MessageBox.Show("아이디 번호를 구할 수 없습니다.");
                    return;
                }

                // book_list 테이블에서 primary key 값을 조회하여 bv_book_index에 할당
                string bookIndexQuery = "SELECT `index` FROM book_list WHERE code = '" + bv_number_label.Text + "'";
                MySqlCommand bookIndexCommand = new MySqlCommand(bookIndexQuery, connection);
                object bookIndexResult = bookIndexCommand.ExecuteScalar();

                if (bookIndexResult != null)
                {
                    bv_book_index = bookIndexResult.ToString();
                }
                else
                {
                    MessageBox.Show("책 번호를 구할 수 없습니다.");
                    return;
                }

                // 해당 책을 이미 빌리고 있는지 확인하는 쿼리
                string checkQuery = "SELECT COUNT(*) FROM book_borrow WHERE id = '" + bv_user_id + "' AND bookcode = '" + bv_number_label.Text + "'";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                // 고유번호가 이미 bv_user_id로 빌리고 있다면 거부 후 반환
                if (count > 0)
                {
                    connection.Close();
                    MessageBox.Show("이미 대여 중인 책입니다.");
                    return;
                }

                // 현재 시간과 반납 시간을 birthday 컬럼 데이터 규격에 맞게 변환
                DateTime currentTime = DateTime.Now;
                DateTime addTime = currentTime.AddDays(7);
                string startTime = currentTime.ToString("yyyy-MM-dd hh:mm:ss");
                string stopTime = addTime.ToString("yyyy-MM-dd hh:mm:ss");

                string insertQuery = "INSERT INTO book_borrow (id, accountid, bookindex, bookcode, start, stop) VALUES ('" + bv_user_id + //아이디
                                                                                                  "', '" + bv_account_index + //아이디인덱스
                                                                                                  "', '" + bv_book_index + //북인덱스
                                                                                                  "', '" + bv_number_label.Text +//고유번호
                                                                                                  "', '" + startTime + //시작
                                                                                                  "', '" + stopTime + "');"; //반납

                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    connection.Close();
                    return;
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("오류 발생");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void title_panel_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = new Point(e.X, e.Y);
        }
        private void title_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (Drag.X - e.X), this.Top - (Drag.Y - e.Y));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkOut_btn_Click(object sender, EventArgs e)
        {
            borrow_funtion();
        }

        private void BookView_Load(object sender, EventArgs e)
        {
            pv_load_image_funtion();
        }

        private void bv_image_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
