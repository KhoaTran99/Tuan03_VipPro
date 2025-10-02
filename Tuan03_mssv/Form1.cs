using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan03_mssv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // lấy thông tin ngày giờ
            var date = DateTime.Now.ToString("dd/MM/yyyy");
            var time = DateTime.Now.ToString("hh:mm:ss");

            toolStripStatusLabel1.Text = $"Hôm nay là ngày: {date} - {time}";
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // khởi tạo đối tượng mở file
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "File name|*.mp4";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFile.FileName;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // đóng file
        }
    }
}
