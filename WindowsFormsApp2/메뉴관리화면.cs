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
    public partial class 메뉴관리화면 : Form
    {
        public 메뉴관리화면()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void 메인화면ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            메인화면 dlg = new 메인화면();
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
