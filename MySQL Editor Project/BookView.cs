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

namespace MySQL_Editor_Project
{
    public partial class BookView : Form
    {
        private Point Drag = new Point();
        public string bv_user_id = "";

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
