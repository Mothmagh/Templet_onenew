using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sim.EPL;

namespace sim.PL
{
    public partial class FFRM_CAT_ADD : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_CAT tb_cat = new TB_CAT();
        BL.Methods methods = new BL.Methods();

     

        public int id;
        public FFRM_CAT_ADD()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "name the category reguired";
                dialog.Show();
            }
            else
            {
                if (id == 0)
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_NAME = edt_name.Text;
                    tb_cat.CAT_COVER = methods.convert_byte();
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافة الصنف بنجاح";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_NAME = edt_name.Text;
                    tb_cat.ID = id;
                    tb_cat.CAT_COVER = methods.convert_byte();
                    db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل الصنف بنجاح";
                    toast.Show();
                    this.Close();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
