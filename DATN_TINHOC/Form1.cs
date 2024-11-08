using DATN_TINHOC.Models;

namespace DATN_TINHOC
{
    public partial class Form1 : Form
    {
        private static List<ThongSoCot> thongSoCots = new List<ThongSoCot>();
        private int count = 1;
        public Form1()
        {
            InitializeComponent();
        }

        #region Form1_load
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            btn_huy.Enabled = false;

            dgv_thongso.DataSource = null;
            dgv_thongso.DataSource = thongSoCots;

            dgv_thongso.Columns[0].HeaderText = "STT";
            dgv_thongso.Columns[1].HeaderText = "Tên cột";
            dgv_thongso.Columns[2].HeaderText = "b (m)";
            dgv_thongso.Columns[3].HeaderText = "h (m)";
            dgv_thongso.Columns[4].HeaderText = "L (m)";
            dgv_thongso.Columns[5].HeaderText = "a (m)";
            dgv_thongso.Columns[6].HeaderText = "Mx (kNm)";
            dgv_thongso.Columns[7].HeaderText = "My (kNm)";
            dgv_thongso.Columns[8].HeaderText = "N (m)";
        }
        #endregion

        #region be_tong_changed
        private void cbb_betong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_betong.Text == "B12.5")
            {
                txt_rbbetong.Text = "7,5";
                txt_rbtbetong.Text = "0,66";
                txt_ebetong.Text = "21000";
            }
            else if (cbb_betong.Text == "B15")
            {
                txt_rbbetong.Text = "8,5";
                txt_rbtbetong.Text = "0,75";
                txt_ebetong.Text = "23000";
            }
            else if (cbb_betong.Text == "B20")
            {
                txt_rbbetong.Text = "8,5";
                txt_rbtbetong.Text = "0,75";
                txt_ebetong.Text = "23000";
            }
            else if (cbb_betong.Text == "B20")
            {
                txt_rbbetong.Text = "11,5";
                txt_rbtbetong.Text = "0,9";
                txt_ebetong.Text = "27000";
            }
            else if (cbb_betong.Text == "B25")
            {
                txt_rbbetong.Text = "14,5";
                txt_rbtbetong.Text = "1,05";
                txt_ebetong.Text = "30000";
            }
            else if (cbb_betong.Text == "B30")
            {
                txt_rbbetong.Text = "17";
                txt_rbtbetong.Text = "1,2";
                txt_ebetong.Text = "32500";
            }
            else if (cbb_betong.Text == "B35")
            {
                txt_rbbetong.Text = "19,5";
                txt_rbtbetong.Text = "1,3";
                txt_ebetong.Text = "34500";
            }
            else if (cbb_betong.Text == "B40")
            {
                txt_rbbetong.Text = "22";
                txt_rbtbetong.Text = "1,4";
                txt_ebetong.Text = "36000";
            }
        }
        #endregion

        #region thep_doc_changed
        private void cbb_thepdoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_thepdoc.Text == "CB 300-V")
            {
                txt_rsthepdoc.Text = "260";
                txt_rscthepdoc.Text = "260";
                txt_rswthepdoc.Text = "210";
                txt_ethepdoc.Text = "200000";
            }
            else if (cbb_thepdoc.Text == "CB 400-V")
            {
                txt_rsthepdoc.Text = "350";
                txt_rscthepdoc.Text = "350";
                txt_rswthepdoc.Text = "280";
                txt_ethepdoc.Text = "200000";
            }
            else if (cbb_thepdoc.Text == "CB 500-V")
            {
                txt_rsthepdoc.Text = "435";
                txt_rscthepdoc.Text = "435";
                txt_rswthepdoc.Text = "390";
                txt_ethepdoc.Text = "200000";
            }
        }
        #endregion

        #region thep_dai_changed
        private void cbb_thepdai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_thepdai.Text == "CB300-V")
            {
                txt_rsthepdai.Text = "260";
                txt_rscthepdai.Text = "260";
                txt_rswthepdai.Text = "210";
                txt_ethepdai.Text = "200000";
            }
            else if (cbb_thepdai.Text == "CB400-V")
            {
                txt_rsthepdai.Text = "350";
                txt_rscthepdai.Text = "350";
                txt_rswthepdai.Text = "280";
                txt_ethepdai.Text = "200000";
            }
            else if (cbb_thepdoc.Text == "CB500-V")
            {
                txt_rsthepdai.Text = "435";
                txt_rscthepdai.Text = "435";
                txt_rswthepdai.Text = "390";
                txt_ethepdai.Text = "200000";
            }
        }
        #endregion

        #region btn_luu_click
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_betong.Text)
                || string.IsNullOrEmpty(cbb_thepdoc.Text)
                || string.IsNullOrEmpty(cbb_thepdai.Text))
            {
                MessageBox.Show("Bạn chưa chọn xong vật liệu! Mời tiếp tục chọn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Đã lưu vật liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_luu.Enabled = false;
                btn_huy.Enabled = true;
                cbb_betong.Enabled = false;
                cbb_thepdoc.Enabled = false;
                cbb_thepdai.Enabled = false;
            }
        }
        #endregion

        #region btn_huy_click
        private void btn_huy_Click(object sender, EventArgs e)
        {
            cbb_betong.Text = "";
            cbb_thepdoc.Text = "";
            cbb_thepdai.Text = "";
            MessageBox.Show("Đã hủy vật liệu cũ thành công! Mời chọn lại vật liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_rbbetong.Clear();
            txt_rbtbetong.Clear();
            txt_ebetong.Clear();
            txt_rsthepdoc.Clear();
            txt_rscthepdoc.Clear();
            txt_ethepdoc.Clear();
            txt_rsthepdai.Clear();
            txt_rscthepdai.Clear();
            txt_ethepdai.Clear();
            txt_rswthepdai.Clear();
            txt_rswthepdoc.Clear();
            btn_luu.Enabled = true;
            btn_huy.Enabled = false;
        }
        #endregion

        #region btn_them_click
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tencot.Text)
                && string.IsNullOrEmpty(txt_berongb.Text)
                && string.IsNullOrEmpty(txt_chieucaoh.Text)
                && string.IsNullOrEmpty(txt_chieudail.Text)
                && string.IsNullOrEmpty(txt_lopbaove.Text)
                && string.IsNullOrEmpty(txt_Mx.Text)
                && string.IsNullOrEmpty(txt_My.Text)
                && string.IsNullOrEmpty(txt_N.Text)
                )
            {
                MessageBox.Show("Bạn chưa điền đủ thông số của cột! Mời bạn nhập tiếp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv_thongso.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_thongso.Rows)
                {
                    if (row.Cells[1].Value != null && txt_tencot.Text == row.Cells[1].Value.ToString())
                    {
                        MessageBox.Show("Cột bạn thêm có tên bị trùng! Mời bạn nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            if (Convert.ToDouble(txt_Mx.Text) == 0 && Convert.ToDouble(txt_My.Text) == 0)
            {
                ThongSoCot thongSoCot = new ThongSoCot
                {
                    Id = count,
                    TenCot = txt_tencot.Text,
                    RongB = double.Parse(txt_berongb.Text),
                    CaoH = double.Parse(txt_chieucaoh.Text),
                    DaiL = double.Parse(txt_chieudail.Text),
                    BaoVeA = double.Parse(txt_lopbaove.Text),
                    Mx = double.Parse(txt_Mx.Text),
                    My = double.Parse(txt_My.Text),
                    N = double.Parse(txt_N.Text),
                };

                thongSoCots.Add(thongSoCot);

                dgv_thongso.DataSource = null;
                dgv_thongso.DataSource = thongSoCots;

                count++;

                MessageBox.Show("Đã thêm cột thành công! Mời bạn nhập tiếp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tencot.Clear();
                txt_berongb.Clear();
                txt_chieucaoh.Clear();
                txt_chieudail.Clear();
                txt_lopbaove.Clear();
                txt_Mx.Clear();
                txt_My.Clear();
                txt_N.Clear();
                dgv_thongso.ClearSelection();
                Form1_Load(null, null);
            }
            else if (Convert.ToDouble(txt_Mx.Text) > 10 * Convert.ToDouble(txt_My.Text)
                || Convert.ToDouble(txt_My.Text) > 10 * Convert.ToDouble(txt_Mx.Text))
            {
                ThongSoCot thongSoCot = new ThongSoCot
                {
                    Id = count,
                    TenCot = txt_tencot.Text,
                    RongB = double.Parse(txt_berongb.Text),
                    CaoH = double.Parse(txt_chieucaoh.Text),
                    DaiL = double.Parse(txt_chieudail.Text),
                    BaoVeA = double.Parse(txt_lopbaove.Text),
                    Mx = double.Parse(txt_Mx.Text),
                    My = double.Parse(txt_My.Text),
                    N = double.Parse(txt_N.Text),
                };

                thongSoCots.Add(thongSoCot);

                dgv_thongso.DataSource = null;
                dgv_thongso.DataSource = thongSoCots;

                count++;

                MessageBox.Show("Đã thêm cột thành công! Mời bạn nhập tiếp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tencot.Clear();
                txt_berongb.Clear();
                txt_chieucaoh.Clear();
                txt_chieudail.Clear();
                txt_lopbaove.Clear();
                txt_Mx.Clear();
                txt_My.Clear();
                txt_N.Clear();
                dgv_thongso.ClearSelection();
                Form1_Load(null, null);
            }
            else
            {
                MessageBox.Show("Chương trình chưa hỗ trợ tính toán cột nén lệch tâm xiên.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
