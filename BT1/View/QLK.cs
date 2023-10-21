using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT1
{
    public partial class QLK : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=(local);Database=QUANLYKHO;User Id=trang;Password=123456;");
        public QLK()
        {
            InitializeComponent();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            lstView.Items.RemoveAt(0);
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Kho (MaKho, TenKho, DiaChi) VALUES(N'" + txtMaKho.Text + "',N'" + txtTenKho.Text + "',N'" + txtDiaChi.Text + "')", conn);
                cmd.ExecuteNonQuery();
                ListViewItem lvi = new ListViewItem(txtMaKho.Text);
                lvi.SubItems.Add(txtTenKho.Text);
                lvi.SubItems.Add(txtDiaChi.Text);

                lstView.Items.Add(lvi);
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            // Xóa nội dung trong TextBox sau khi insert
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from Kho where MaKho='" + txtMaKho.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                conn.Close();

                lstView.Items.RemoveAt(lstView.SelectedIndices[0]);
            }
        }
        private void btnload_Click(object sender, EventArgs e)
        {
            lstView.Items.Clear();  // sau khi load không bị trùng lặp 

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Kho", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader.GetString(0).ToString());
                    lv.SubItems.Add(reader.GetString(1));
                    lv.SubItems.Add(reader.GetString(2));
                    lstView.Items.Add(lv);
                }
                conn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        // Khi ấn vào dữ liệu nó sẽ hiện lên các text box
       
        private void btnsua_Click_1(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("update Kho set TenKho= N'" + txtTenKho.Text + "',DiaChi=N'" + txtDiaChi.Text + "'where MaKho= '" + txtMaKho.Text + "'", conn);
                cmd.ExecuteNonQuery();
                ListViewItem lvi = new ListViewItem(txtMaKho.Text);
                lvi.SubItems.Add(txtTenKho.Text);
                lvi.SubItems.Add(txtDiaChi.Text);

                lstView.Items.Add(lvi);
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //Dọn dẹp sạch sẽ sau khi đã tìm kiếm
        public void clear()
        {
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Kho where MaKho = @makho", conn);
            cmd.Parameters.AddWithValue("@makho", txtTimKiem.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                ListViewItem lv1 = new ListViewItem(reader.GetString(0).ToString());
                lv1.SubItems.Add(reader.GetString(1));
                lv1.SubItems.Add(reader.GetString(2));
                lstView.Items.Add(lv1);

            }
            conn.Close();
            clear(); //Dọn dẹp sạch sẽ sau khi đã tìm kiếm
        }

        private void lstView_Click(object sender, EventArgs e)
        {
            txtMaKho.Text = lstView.SelectedItems[0].SubItems[0].Text;
            txtTenKho.Text = lstView.SelectedItems[0].SubItems[1].Text;
            txtDiaChi.Text = lstView.SelectedItems[0].SubItems[2].Text;
        }
    }
}
