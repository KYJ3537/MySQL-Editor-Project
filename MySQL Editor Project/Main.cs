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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MySQL_Editor_Project
{
    public partial class Main : Form
    {
        private Point Drag = new Point();

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
            displayBookList_funtion();
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


                bookViewForm.ShowDialog();
            }
        }

        private void search_book_listview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
