using Google.Protobuf;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MySQL_Editor_Project
{
    public partial class Main : Form
    {
        private Point Drag = new Point();
        private List<ListViewItem> filteredItems;

        string userId = "";

        private void FilterUser_function()
        {
            filteredItems = new List<ListViewItem>(); // 필터링 저장을 위한 리스트

            foreach (ListViewItem item in admin_user_list.Items)
            {
                if (item.SubItems.Count > 5 && item.SubItems[5].Text == "연체")
                {  
                }
                else
                {
                    filteredItems.Add(item); // 연체된 사용자 필터링 리스트에 추가
                    admin_user_list.Items.Remove(item); // 연체되지 않은 사용자 삭제
                }
            }
        }

        private void RestoreUserFilter_function()
        {
            if (filteredItems == null)
                return;

            foreach (ListViewItem item in filteredItems)
            {
                admin_user_list.Items.Add(item); // 저장된 필터링 리스트를 다시 리스트에 추가하기
            }

            filteredItems = null; // filteredItems 초기화
        }

        //도서관 책 리스트
        public void DisplayBookList_funtion()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                string query = "SELECT `index`, `name`, `writer`, `genre`, `title`, `code`, `remain`, `image` FROM book_list";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                search_book_listview.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["index"].ToString());
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["writer"].ToString());
                    item.SubItems.Add(reader["genre"].ToString());
                    item.SubItems.Add(reader["title"].ToString());
                    item.SubItems.Add(reader["code"].ToString());
                    item.SubItems.Add(reader["remain"].ToString());
                    item.SubItems.Add(reader["image"].ToString());

                    search_book_listview.Items.Add(item);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //나의 빌린 책 리스트
        public void GetBorrowList_funtion()
        {
            try
            {

                mybook_listview.Items.Clear();

                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                string query = "SELECT `bookindex`, `bookcode`, `start`, `stop` FROM book_borrow WHERE `id` = '" + userId + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["bookindex"].ToString()); // 0 인덱스
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add(reader["bookcode"].ToString()); // 4 고유코드
                    item.SubItems.Add("");
                    item.SubItems.Add(reader["start"].ToString()); // 7 대여시작
                    item.SubItems.Add(reader["stop"].ToString());
                    mybook_listview.Items.Add(item);
                }

                reader.Close();
                connection.Close();
                GetborrowList_funtion2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        //2번째
        public void GetborrowList_funtion2()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                foreach (ListViewItem listItem in mybook_listview.Items)
                {
                    string index = listItem.SubItems[0].Text; // 첫 번째 열의 데이터(인덱스) 가져오기

                    // book_list 테이블에서 해당 인덱스에 해당하는 책 정보 가져오기
                    string query = "SELECT `name`, `writer`, `genre`, `title` FROM book_list WHERE `index` = '" + index + "'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader(); // 결과값 가져오기

                    if (reader.Read()) // 결과값이 있는 경우
                    {
                        // 가져온 책 정보를 각 열에 추가
                        listItem.SubItems[1].Text = reader["name"].ToString(); // 2 책 이름
                        listItem.SubItems[2].Text = reader["writer"].ToString(); // 3 작가
                        listItem.SubItems[3].Text = reader["genre"].ToString(); // 4 장르
                        listItem.SubItems[4].Text = reader["title"].ToString(); // 5 제목

                        //// 대여 시간 가져오기
                        string dateString = listItem.SubItems[8].Text.Split(' ')[0]; // 문자열에서 시간 부분을 제거하여 날짜 부분만 추출
                        DateTime stopDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture); // yyyy-MM-dd 형식으로 날짜 파싱

                        // 현재 시간과 비교하여 연체 여부 판단
                        if (DateTime.Now > stopDate)
                        {
                            listItem.SubItems[6].Text = "연체"; // 7 연체인 경우
                        }
                        else
                        {
                            listItem.SubItems[6].Text = "대여중"; // 7 연체가 아닌 경우
                        }
                    }

                    reader.Close();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 빌린책
        public void GetBorrowList_funtion_Admin()
        {
            try
            {

                admin_user_list.Items.Clear();

                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                string query = "SELECT `id`, `bookindex`, `bookcode`, `start`, `stop` FROM book_borrow";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["bookindex"].ToString());
                    item.SubItems.Add(reader["bookcode"].ToString());
                    item.SubItems.Add(reader["start"].ToString());
                    item.SubItems.Add(reader["stop"].ToString());
                    string dateString = reader["stop"].ToString().Split(' ')[0]; // 문자열에서 시간 부분을 제거하여 날짜 부분만 추출
                    DateTime stopDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture); // yyyy-MM-dd 형식으로 날짜 파싱

                    // 현재 시간과 비교하여 연체 여부 판단
                    if (DateTime.Now > stopDate)
                    {
                        item.SubItems.Add("연체");
                    }
                    else
                    {
                    }
                    admin_user_list.Items.Add(item);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void SearchUserList_function_Admin(string searchText)
        {
            // searchText 비어있으면 GetBorrowList_funtion_Admin 호출해서 모든 리스트 불러오기
            if (string.IsNullOrEmpty(searchText))
            {
                GetBorrowList_funtion_Admin();
                return;
            }

            // 리스트뷰 전체 아이템 검색 시작
            foreach (ListViewItem item in admin_user_list.Items)
            {
                bool found = false;

                if (item.SubItems[0].Text == searchText)
                {
                    found = true;
                }

                // found 참이 아니면 그 행은 지우기
                if (!found)
                {
                    admin_user_list.Items.Remove(item);
                }
            }
        }

        private void SearchBookList_function(string searchText)
        {
            // searchText 비어있으면 displayBookList 호출해서 모든 리스트 불러오기
            if (string.IsNullOrEmpty(searchText))
            {
                DisplayBookList_funtion();
                return;
            }

            // 리스트뷰 전체 아이템 검색 시작
            foreach (ListViewItem item in search_book_listview.Items)
            {
                bool found = false;

                // 2~6번째 북리스트뷰의 열 반복
                for (int i = 1; i <= 5; i++)
                {
                    // searchText랑 같다면
                    if (item.SubItems[i].Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        found = true;
                        break;
                    }
                }

                // found 참이 아니면 그 행은 지우기
                if (!found)
                {
                    search_book_listview.Items.Remove(item);
                }
            }
        }

        private bool InsertBook_function_Admin()
        {
            try
            {
                if (admin_id_txt.Text == "" || 
                    admin_write_txt.Text == "" ||
                    admin_genre_txt.Text == "" ||
                    admin_contents_txt.Text == "" ||
                    admin_number_txt.Text == "" ||
                    admin_remain_txt.Text == "" ||
                    admin_image_txt.Text == "")
                {
                    MessageBox.Show("입력해주세요.");
                    return false;
                }

                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                // 해당 책 이름이 존재하는지 확인
                string checkQuery = "SELECT COUNT(*) FROM book_list WHERE name = \'" + admin_id_txt.Text + "\' ";
                MySqlCommand checkBookNameCommand = new MySqlCommand(checkQuery, connection);

                int count = Convert.ToInt32(checkBookNameCommand.ExecuteScalar());

                // 책 이름이 존재하면 거부 후 반환
                if (count > 0)
                {
                    connection.Close();
                    MessageBox.Show("이미 존재하는 책 이름입니다.");
                    return false;
                }

                // 해당 고유번호가 존재하는지 확인
                checkQuery = "SELECT COUNT(*) FROM book_list WHERE code = \'" + admin_number_txt.Text + "\' ";
                MySqlCommand checkBookNumberCommand = new MySqlCommand(checkQuery, connection);

                count = Convert.ToInt32(checkBookNumberCommand.ExecuteScalar());

                // 고유번호가 존재하면 거부 후 반환
                if (count > 0)
                {
                    connection.Close();
                    MessageBox.Show("이미 존재하는 고유번호입니다.");
                    return false;
                }

                string insertQuery = "INSERT INTO book_list (name, writer, genre, title, code, remain, image) VALUES ('" + admin_id_txt.Text +
                                                                                                  "', '" + admin_write_txt.Text +
                                                                                                  "', '" + admin_genre_txt.Text +
                                                                                                  "', '" + admin_contents_txt.Text +
                                                                                                  "', '" + admin_number_txt.Text +
                                                                                                  "', '" + admin_remain_txt.Text +
                                                                                                  "', '" + admin_image_txt.Text + "');";

                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    DisplayBookList_funtion();
                    MessageBox.Show("해당 책을 진열합니다.");
                    connection.Close();
                    return true;
                }
                else
                {
                    DisplayBookList_funtion();
                    connection.Close();
                    MessageBox.Show("책 등록 오류 발생");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void AddBookRemain_funtion_Admin(string book_number)
        {
            try
            {
                if (book_number == "")
                {
                    MessageBox.Show("입력해주세요.");
                    return;
                }

                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                // 현재 remain 데이터 문자화해서 가져오기
                string selectQuery = "SELECT remain FROM book_list WHERE code = '" + book_number + "'";
                MySqlCommand getCurrentRemainCommand = new MySqlCommand(selectQuery, connection);

                // 오류발생 방지하기, 비어있는지 체크
                object result = getCurrentRemainCommand.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("책을 찾을 수 없습니다.");
                    return;
                }

                string currentRemain = result.ToString();

                //현재 재고 수 인트 형식으로 +1 해서 저장
                int remainIntValue = int.Parse(currentRemain) + 1;

                //int 형식 다시 문자열로 변환
                string addRemain = remainIntValue.ToString();

                string updateQuery = "UPDATE book_list SET remain = '" + addRemain + "' WHERE code = '" + book_number + "'";

                MySqlCommand command = new MySqlCommand(updateQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("재고 수량을 1개 늘렸습니다.");
                }
                else
                {
                    MessageBox.Show("재고 증가 실패");
                }
                DisplayBookList_funtion();
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void IncreaseUserBookTime_funtion_Admin(string userid, string num, string time)
        {
            try
            {
                if (userid == "" || num == "" || time == "")
                {
                    MessageBox.Show("입력해주세요.");
                    return;
                }

                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                // stop 데이터 문자화해서 가져오기
                string selectQuery = "SELECT stop FROM book_borrow WHERE bookcode = '" + num + "' AND id = '" + userid + "'";
                MySqlCommand getStopCommand = new MySqlCommand(selectQuery, connection);

                // 오류발생 방지하기, 오브젝트에 결과 넣고 비어있는지 체크
                object result = getStopCommand.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("사용자 정보를 찾을 수 없습니다.");
                    return;
                }

                //날짜 파싱날짜 연 월 일까지만 데이터 담기
                string userstop = result.ToString().Split(' ')[0];

                // 데이터 형식 변환
                DateTime stopDate = DateTime.ParseExact(userstop, "yyyy-MM-dd", CultureInfo.InvariantCulture); 

                // 입력한 일 수만큼 늘리기
                stopDate = stopDate.AddDays(int.Parse(time));

                // 늘어난 날짜를 다시 문자열로 변환하여 저장
                userstop = stopDate.ToString("yyyy-MM-dd hh:mm:ss");

                string updateQuery = "UPDATE book_borrow SET stop = '" + userstop + "' WHERE bookcode = '" + num + "' AND id = '" + userid + "'";

                MySqlCommand command = new MySqlCommand(updateQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(userid + "님의 " + num + "책 대여 기간을 " + time + "일만큼 늘렸습니다.\r\n\r\n반납 기한 : " + userstop);
                }
                else
                {
                    MessageBox.Show("기한 늘리기 실패");
                }
                GetBorrowList_funtion_Admin();
                GetBorrowList_funtion();
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public Main()
        {
            InitializeComponent();

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

        private void title_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SearchBookList_function(search_txt.Text);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string[] parts = main_id_label.Text.Split(new string[] { "님" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 0)
            {
                userId = parts[0];
            }

            DisplayBookList_funtion();
            GetBorrowList_funtion();
            GetBorrowList_funtion_Admin();
        }

        private void search_book_listview_DoubleClick(object sender, EventArgs e)
        {
            if (search_book_listview.SelectedItems.Count > 0)
            {
                // 선택된 아이템의 정보 가져오기
                ListViewItem selectedItem = search_book_listview.SelectedItems[0];

                // BookView 윈도우 폼 생성 및 전달
                BookView bookViewForm = new BookView(this);

                // BookView 윈도우 폼의 label에 정보 전달
                bookViewForm.bv_title_label.Text = selectedItem.SubItems[1].Text + " - (" + selectedItem.SubItems[0].Text + ")"; // name (index)
                bookViewForm.bv_writer_label.Text = selectedItem.SubItems[2].Text; // writer
                bookViewForm.bv_genrn_label.Text = selectedItem.SubItems[3].Text; // genre
                bookViewForm.bv_contents_label.Text = selectedItem.SubItems[4].Text; // contents
                bookViewForm.bv_number_label.Text = selectedItem.SubItems[5].Text; // code
                bookViewForm.bv_last_label.Text = "남은 재고 수 : " + selectedItem.SubItems[6].Text; // remain
                bookViewForm.bv_image_txt.Text = selectedItem.SubItems[7].Text; // image
                

                bookViewForm.bv_user_id = userId;

                bookViewForm.ShowDialog();
            }
        }

        private void search_book_listview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mybook_listview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void main_tabpage1_Click(object sender, EventArgs e)
        {

        }

        private void refresh_booklist_btn_Click(object sender, EventArgs e)
        {
            DisplayBookList_funtion();
            GetBorrowList_funtion();
            GetBorrowList_funtion_Admin();
        }

        private void admin_refresh_userlist_btn_Click(object sender, EventArgs e)
        {
            DisplayBookList_funtion();
            GetBorrowList_funtion();
            GetBorrowList_funtion_Admin();
        }

        private void admin_borrow_check_CheckedChanged(object sender, EventArgs e)
        {
            if (admin_borrow_check.Checked)
            {
                FilterUser_function();
            }
            else
            {
                RestoreUserFilter_function();
            }
        }

        private void admin_search_btn_Click(object sender, EventArgs e)
        {
            SearchUserList_function_Admin(admin_search_txt.Text);
        }

        private void admin_upload_book_btn_Click(object sender, EventArgs e)
        {
            InsertBook_function_Admin();
        }

        private void admin_add_remain_btn_Click(object sender, EventArgs e)
        {
            AddBookRemain_funtion_Admin(admin_add_remain_number.Text);
        }

        private void admin_add_time_btn_Click(object sender, EventArgs e)
        {
            IncreaseUserBookTime_funtion_Admin(admin_addtime_id_txt.Text, admin_addtime_booknum_txt.Text, admin_addtime_time_txt.Text);
        }

        private void admin_user_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
