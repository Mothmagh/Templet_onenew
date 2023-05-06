using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace sim
{
    public partial class main : Form
    {
        FRM_FORMPAGE frm_home = new FRM_FORMPAGE();
        Category frm_cat = new Category();
        DB_SMPEntities db = new DB_SMPEntities();
        FRM_SUPP frm_supp = new FRM_SUPP();
        

        public main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_collabs_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 250)
            {
                pn_navbar.Width =50;
                pn_titlenavbar.Visible = false;
                pn_headernav.Height = 200;
            }
            else
            {
                pn_navbar.Width = 250;
                pn_titlenavbar.Visible = true;
                pn_headernav.Height = 149;
            }
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {

        }

        private void pn_cont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
        }

        private void main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cat.pn_cat);
            db = new DB_SMPEntities();
            
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_supp.pn_cat);
            db = new DB_SMPEntities();
        }
    }
}
