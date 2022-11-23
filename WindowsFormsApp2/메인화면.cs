using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class 메인화면 : Form
    {
        public 메인화면()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("F"); // label1에 현재날짜시간 표시, F:자세한 전체 날짜/시간
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; //타이머 간격 100ms
            timer1.Start();  //타이머 시작          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            투표화면 dlg = new 투표화면(); 
            dlg.Owner = this;
            dlg.ShowDialog();
            dlg.Dispose();
        }

        private void 메뉴관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            메뉴관리화면 dlg = new 메뉴관리화면();
            dlg.Owner = this;
            dlg.ShowDialog();
            dlg.Dispose();
        }

        private void 투표관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            투표관리화면 dlg = new 투표관리화면();
            dlg.Owner = this;
            dlg.ShowDialog();
            dlg.Dispose();
        }

        private void 메뉴통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            메뉴통계화면 dlg = new 메뉴통계화면();
            dlg.Owner = this;
            dlg.ShowDialog();
            dlg.Dispose();
        }

        private void 투표통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            투표통계화면 dlg = new 투표통계화면();
            dlg.Owner = this;
            dlg.ShowDialog();
            dlg.Dispose();
        }
    }
}
