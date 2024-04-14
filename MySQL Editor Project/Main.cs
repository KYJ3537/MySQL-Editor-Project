using Google.Protobuf;
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

        string userId = "";

        //도서관 책 리스트
        private void displayBookList_funtion()
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
        private void getborrowList_funtion()
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
                getborrowList2_funtion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void admin_getborrowList_funtion()
        {
            try
            {

                admin_user_list.Items.Clear();

                MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3307;Database=sql_edit_db;Uid=root;Pwd=root;");
                connection.Open();

                string query = "SELECT `id`, `bookindex`, `bookcode`, `start`, `stop` FROM book_borrow WHERE `id` = '" + userId + "'";
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

        //2번째
        private void getborrowList2_funtion()
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

        }

        private void Main_Load(object sender, EventArgs e)
        {
            string[] parts = main_id_label.Text.Split(new string[] { "님" }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 0)
            {
                userId = parts[0];
            }

            displayBookList_funtion();
            getborrowList_funtion();
            admin_getborrowList_funtion();
        }

        private void search_book_listview_DoubleClick(object sender, EventArgs e)
        {
            if (search_book_listview.SelectedItems.Count > 0)
            {
                // 선택된 아이템의 정보 가져오기
                ListViewItem selectedItem = search_book_listview.SelectedItems[0];

                // BookView 윈도우 폼 생성
                BookView bookViewForm = new BookView();

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
            displayBookList_funtion();
            getborrowList_funtion();
            admin_getborrowList_funtion();
        }

        private void admin_refresh_userlist_btn_Click(object sender, EventArgs e)
        {
            displayBookList_funtion();
            getborrowList_funtion();
            admin_getborrowList_funtion();
        }
    }
}
