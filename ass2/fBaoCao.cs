using ass2.DTO;
using ass2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass2
{
    public partial class fBaoCao : Form
    {
        public fBaoCao()
        {
            InitializeComponent();
            //testc();
            loadNV();

        }

        private void loadNV()
        {
            Employee em = EmployeeDAO.Instance.SelectNVByID(2);
            lbTenNV.Text = lbTenNV.Text+" "+ em.FName + " " + em.LName;
        }

        private void testc()
        {
            //pbItem.Image = Properties.Resources._1001;
            pbItem.Image = Image.FromFile(@"..\..\photo\1001.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbItem_TextChanged(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            try
            {
                if (GoodDAO.Instance.QRisValid(Convert.ToInt32(text)))
                {
                    Good good = GoodDAO.Instance.SelectGoodByQR(Convert.ToInt32(text));
                    tbSoluong.ReadOnly = false;
                    tbSoluong.Text = "1";
                    btAdd.Enabled = true;
                    pbItem.Image = Image.FromFile(@"../../photo/" + good.Image + ".jpg");
                    btAdd.Tag = good;
                }
                else 
                {
                    pbItem.Image = null;
                    tbSoluong.ReadOnly = true;
                    tbSoluong.Text = "";
                    btAdd.Enabled = false;
                }
            }
            catch { }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Good hasChosen = (sender as Button).Tag as Good;
            bool hasUpdated = false;
            foreach (ListViewItem item in this.lvItem.Items)
            {
                if (item.SubItems[0].Text == hasChosen.Name)
                {
                    int sl = (Convert.ToInt32(item.SubItems[1].Text)) + (Convert.ToInt32(tbSoluong.Text));
                    if (sl <= 0)
                    {
                        this.lvItem.Items.Remove(item);
                    }
                    item.SubItems[1].Text = sl.ToString();
                    item.SubItems[3].Text = (Convert.ToInt32(item.SubItems[2].Text) * sl).ToString();

                    hasUpdated =true;
                    break;
                }
            }
            if (hasUpdated == false)
            {
                if (Convert.ToInt32(tbSoluong.Text) <= 0)
                {
                    MessageBox.Show("Số lượng không phù hợp!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                ListViewItem lvItem = new ListViewItem(hasChosen.Name);
                lvItem.SubItems.Add(tbSoluong.Text);
                lvItem.SubItems.Add(hasChosen.Price.ToString());
                lvItem.SubItems.Add((Convert.ToInt32(tbSoluong.Text) * hasChosen.Price).ToString());
                this.lvItem.Items.Add(lvItem);
            }
            
            pbItem.Image = null;
            tbSoluong.ReadOnly = true;
            tbSoluong.Text = "";
            btAdd.Enabled = false;
            tbItem.Text = "";
        }

        private void btAddKH_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            f.ShowDialog();
        }

        private void lvItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
