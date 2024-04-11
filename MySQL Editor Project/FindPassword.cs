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


        }
    }
}
