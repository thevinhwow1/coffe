using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_app_cf_đồ_án_tốt_nghiệp
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát","thông báo",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
           {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table_messenger f = new table_messenger();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
