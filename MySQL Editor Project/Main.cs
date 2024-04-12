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
            ListViewItem list0 = new ListViewItem("행0");
            list0.SubItems.Add("행0의 열1");
            list0.SubItems.Add("행0의 열2");
            list0.SubItems.Add("행0의 열3");
            list0.SubItems.Add("행0의 열4");
            search_book_listview.Items.Add(list0);
        }
    }
}
