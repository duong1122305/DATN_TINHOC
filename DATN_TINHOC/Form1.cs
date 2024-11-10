using DATN_TINHOC.ChuongTrinh;
using DATN_TINHOC.Models;
using System;

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

            TaoDGVThongSoCot(dgv_thongso);
            TaoDGVTinhToan(dgv_tinhtoan);
            TaoDGVCotThep(dgv_cotthep);
        }
        #endregion

        #region tao_cot_trong_dataGridView
        private void TaoDGVThongSoCot(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = thongSoCots;

            dgv.Columns[0].HeaderText = "STT";
            dgv.Columns[1].HeaderText = "Tên cột";
            dgv.Columns[2].HeaderText = "b (m)";
            dgv.Columns[3].HeaderText = "h (m)";
            dgv.Columns[4].HeaderText = "L (m)";
            dgv.Columns[5].HeaderText = "a (m)";
            dgv.Columns[6].HeaderText = "Mx (kNm)";
            dgv.Columns[7].HeaderText = "My (kNm)";
            dgv.Columns[8].HeaderText = "N (m)";
        }

        private void TaoDGVTinhToan(DataGridView dgv)
        {
            dgv.DataSource = null;

            while (dgv.Columns.Count < 11)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn());
            }

            dgv.Columns[0].HeaderText = "Tên cột";
            dgv.Columns[1].HeaderText = "Trường hợp\nTính toán";
            dgv.Columns[2].HeaderText = "b (m)";
            dgv.Columns[3].HeaderText = "h (m)";
            dgv.Columns[4].HeaderText = "L (m)";
            dgv.Columns[5].HeaderText = "Mx (kNm)";
            dgv.Columns[6].HeaderText = "My (kNm)";
            dgv.Columns[7].HeaderText = "Mtt (kNm)";
            dgv.Columns[8].HeaderText = "N (kN)";
            dgv.Columns[9].HeaderText = "As (cm2)";
            dgv.Columns[10].HeaderText = "µ (%)";
        }

        private void TaoDGVCotThep(DataGridView dgv)
        {
            dgv.DataSource = null;

            while (dgv.Columns.Count < 8)
            {
                dgv.Columns.Add(new DataGridViewTextBoxColumn());
            }

            dgv.Columns[0].HeaderText = "Tên cột";
            dgv.Columns[1].HeaderText = "Bố trí thép";
            dgv.Columns[2].HeaderText = "Astt (cm2)";
            dgv.Columns[3].HeaderText = "µ (%)";
            dgv.Columns[4].HeaderText = "Astc (cm2)";
            dgv.Columns[5].HeaderText = "Kiểm tra";
            dgv.Columns[6].HeaderText = "DK Thép đai";
            dgv.Columns[7].HeaderText = "Khoảng cách thép đai";
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

        #region btn_tinhtoan_click
        private void btm_tinhtoan_Click(object sender, EventArgs e)
        {
            dgv_tinhtoan.Rows.Clear();

            if (dgv_thongso.Rows.Count <= 0)
            {
                MessageBox.Show("Danh sách cột đang trống! Mời bạn nhập dữ liệu vào bảng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in dgv_thongso.Rows)
                {
                    if (Convert.ToInt64(row.Cells[6].Value) == 0 && Convert.ToInt64(row.Cells[7].Value) == 0)
                    {
                        double b = Convert.ToDouble(row.Cells[2].Value);
                        double h = Convert.ToDouble(row.Cells[3].Value);
                        double L = Convert.ToDouble(row.Cells[4].Value);
                        double N = Convert.ToDouble(row.Cells[8].Value);
                        double Rb = Convert.ToDouble(txt_rbbetong.Text);
                        double Rsc_Doc = Convert.ToDouble(txt_rscthepdoc.Text);
                        double Asttdungtam = 0;
                        double Mttdungtam = 0;
                        double Muyasdungtam = 0;

                        TinhToanSoLieu.Tinhascotnendungtam(b, h, L, N, Rb, Rsc_Doc, out Asttdungtam, out Mttdungtam, out Muyasdungtam);

                        dgv_tinhtoan.Rows.Add(
                            row.Cells[1].Value,
                            "Nén đúng tâm",
                            row.Cells[2].Value,
                            row.Cells[3].Value,
                            row.Cells[4].Value,
                            row.Cells[6].Value,
                            row.Cells[7].Value,
                            Mttdungtam,
                            row.Cells[8].Value,
                            Asttdungtam,
                            Muyasdungtam);

                    }
                    else if (Convert.ToInt64(row.Cells[6].Value) > 10 * Convert.ToInt64(row.Cells[7].Value) || Convert.ToInt64(row.Cells[7].Value) > 10 * Convert.ToInt64(row.Cells[6].Value))
                    {
                        double b = Convert.ToDouble(row.Cells[2].Value);
                        double h = Convert.ToDouble(row.Cells[3].Value);
                        double L = Convert.ToDouble(row.Cells[4].Value);
                        double a = Convert.ToDouble(row.Cells[5].Value);
                        double Mx = Convert.ToDouble(row.Cells[6].Value);
                        double My = Convert.ToDouble(row.Cells[7].Value);
                        double N = Convert.ToDouble(row.Cells[8].Value);
                        double Rb = Convert.ToDouble(txt_rbbetong.Text);
                        double Eb = Convert.ToDouble(txt_ebetong.Text);
                        double Es_Doc = Convert.ToDouble(txt_ethepdoc.Text);
                        double Rs_Doc = Convert.ToDouble(txt_rsthepdoc.Text);
                        double Rsc_Doc = Convert.ToDouble(txt_rscthepdoc.Text);
                        double Alpha_R = 0;
                        double Asttlechtam = 0;
                        double Mttlechtam = 0;
                        double Muyaslechtam = 0;

                        TinhToanSoLieu.XacDinhAlphaR(cbb_betong.Text, cbb_thepdoc.Text, out Alpha_R);
                        TinhToanSoLieu.Tinhascotlechtamphang(b, h, L, a, Mx, My, N, Rb, Eb, Es_Doc, Rs_Doc, Rsc_Doc, Alpha_R,
                            out Asttlechtam,
                            out Mttlechtam,
                            out Muyaslechtam);

                        dgv_tinhtoan.Rows.Add(row.Cells[1].Value,
                            "Nén lệch tâm phẳng",
                            row.Cells[2].Value,
                            row.Cells[3].Value,
                            row.Cells[4].Value,
                            row.Cells[6].Value,
                            row.Cells[7].Value,
                            Mttlechtam,
                            row.Cells[8].Value,
                            Asttlechtam,
                            Muyaslechtam);
                    }
                }

                MessageBox.Show("Đã tính toán xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_load.Enabled = true;
                dgv_thongso.ClearSelection();
                dgv_tinhtoan.ClearSelection();
            }
        }
        #endregion

        #region btn_load_click
        private void btn_load_Click(object sender, EventArgs e)
        {
            dgv_cotthep.Rows.Clear();
            if (dgv_tinhtoan.Rows.Count <= 0)
            {
                MessageBox.Show("Danh sách cột đang trống! Mời bạn nhập dữ liệu vào bảng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in dgv_tinhtoan.Rows)
            {
                dgv_cotthep.Rows.Add(row.Cells[0].Value, "", row.Cells[9].Value, "", "", "", "", "");
            }

            MessageBox.Show("Đã tải dữ liệu cột thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_thongso.ClearSelection();
            dgv_tinhtoan.ClearSelection();
            dgv_cotthep.ClearSelection();
        }
        #endregion

        #region btn_suaThep_click
        private void btn_suathep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_dkthep.Text) || string.IsNullOrEmpty(txt_soluongthep.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin thép! Mời bạn nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double b = Convert.ToDouble(dgv_thongso.Rows[0].Cells[2].Value);
            double h = Convert.ToDouble(dgv_thongso.Rows[0].Cells[3].Value);
            double a = Convert.ToDouble(dgv_thongso.Rows[0].Cells[5].Value);
            double _dkthep = Convert.ToDouble(cbb_dkthep.Text);
            double _soluongthep = Convert.ToDouble(txt_soluongthep.Text);
            double _Asbotri = 0;

            TinhToanSoLieu.TinhAs(_soluongthep, _dkthep, out _Asbotri);

            dgv_cotthep.Rows[0].Cells[1].Value = $"{txt_soluongthep.Text}Ø{cbb_dkthep.Text}";
            dgv_cotthep.Rows[0].Cells[3].Value = Math.Round(((_Asbotri / ((b * (h - a)) * 10000)) * 100), 2);
            dgv_cotthep.Rows[0].Cells[4].Value = _Asbotri;
            dgv_cotthep.Rows[0].Cells[5].Value = null;
            dgv_cotthep.Rows[0].Cells[6].Value = null;
            dgv_cotthep.Rows[0].Cells[7].Value = null;


            MessageBox.Show("Đã sửa thành công! Mời bạn tiếp tục thao tác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cbb_dkthep.Enabled = false;
            txt_soluongthep.Enabled = false;
            btn_suathep.Enabled = false;
            btn_xoathep.Enabled = false;
            btn_kiemtra.Enabled = true;
            dgv_thongso.ClearSelection();
            dgv_tinhtoan.ClearSelection();
            dgv_cotthep.ClearSelection();
        }
        #endregion

        #region btn_xoaThep_Click
        private void btn_xoathep_Click(object sender, EventArgs e)
        {
            dgv_thongso.Rows[0].Cells[1].Value = "";
            dgv_thongso.Rows[0].Cells[3].Value = "";
            dgv_thongso.Rows[0].Cells[4].Value = "";
            dgv_thongso.Rows[0].Cells[5].Value = "";
            dgv_thongso.Rows[0].Cells[6].Value = "";
            dgv_thongso.Rows[0].Cells[7].Value = "";

            MessageBox.Show("Đã xóa thành công! Mời bạn tiếp tục thao tác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cbb_dkthep.Enabled = false;
            txt_soluongthep.Enabled = false;
            btn_suathep.Enabled = false;
            btn_xoathep.Enabled = false;
            dgv_thongso.ClearSelection();
            dgv_tinhtoan.ClearSelection();
            dgv_cotthep.ClearSelection();
        }
        #endregion

        #region btn_kiemTra_click
        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_cotthep.Rows)
            {
                string _texts = row.Cells[1].Value.ToString();
                double _dkthep = 0;
                double _soluongthep = 0;
                double _Asbotri = 0;
                double _Astt = Convert.ToDouble(dgv_tinhtoan.Rows[0].Cells[9].Value);
                double b = Convert.ToDouble(dgv_tinhtoan.Rows[0].Cells[2].Value);
                double h = Convert.ToDouble(dgv_tinhtoan.Rows[0].Cells[3].Value);
                double a = Convert.ToDouble(dgv_thongso.Rows[0].Cells[5].Value);
                double _HamLuong = 0;
                TinhToanSoLieu.TachText(_texts, out _soluongthep, out _dkthep);
                TinhToanSoLieu.TinhAs(_soluongthep, _dkthep, out _Asbotri);
                _HamLuong = ((_Astt + _Asbotri) / ((b * (h - a)) * 10000)) * 100;
                if (_HamLuong > 0.5)
                {
                    if (_HamLuong < 3)
                    {
                        row.Cells[5].Value = "Thỏa mãn";
                        row.Cells[5].Style.BackColor = Color.MediumSpringGreen;
                        row.Cells[6].Value = "Ø8";
                        row.Cells[7].Value = "200";
                    }
                    else
                    {
                        if (_HamLuong < 0.5)
                        {
                            _Asbotri = (0.5 * b * (h - a)) / 10000;
                            row.Cells[5].Value = "Thỏa mãn";
                            row.Cells[5].Style.BackColor = Color.MediumSpringGreen;
                            row.Cells[6].Value = "Ø8";
                            row.Cells[7].Value = "200";
                        }
                        else
                        {
                            row.Cells[5].Value = "Không thỏa mãn";
                            row.Cells[5].Style.BackColor = Color.Tomato;
                        }
                    }
                }
                else
                {
                    if (_HamLuong < 0.5)
                    {
                        _Asbotri = (0.5 * b * (h - a)) / 10000;
                        row.Cells[5].Value = "Thỏa mãn";
                        row.Cells[5].Style.BackColor = Color.MediumSpringGreen;
                        row.Cells[6].Value = "Ø8";
                        row.Cells[7].Value = "200";
                    }
                    else
                    {
                        row.Cells[5].Value = "Không thỏa mãn";
                        row.Cells[5].Style.BackColor = Color.Tomato;
                    }
                }
            }

            MessageBox.Show("Đã kiểm tra xong! Mời bạn tiếp tục thao tác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cbb_dkthep.Text = "";
            txt_soluongthep.Clear();
            txt_soluongthep.Enabled = false;
            cbb_dkthep.Enabled = false;
            dgv_thongso.ClearSelection();
            dgv_tinhtoan.ClearSelection();
            dgv_cotthep.ClearSelection();
        }
        #endregion

        #region dgv_cotthep_CellClick
        private void dgv_cotthep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tencotthep.Text = Convert.ToString(dgv_cotthep.CurrentRow.Cells[0].Value);
            txt_thepbotri.Text = Convert.ToString(dgv_cotthep.CurrentRow.Cells[1].Value);
            cbb_dkthep.Enabled = true; txt_soluongthep.Enabled = true;
            btn_suathep.Enabled = true; btn_xoathep.Enabled = true;
        }
        #endregion

        #region dgv_thongso_CellClick
        private void dgv_thongso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tencot.Text = dgv_thongso.CurrentRow.Cells[1].Value.ToString();
            txt_berongb.Text = dgv_thongso.CurrentRow.Cells[2].Value.ToString();
            txt_chieucaoh.Text = dgv_thongso.CurrentRow.Cells[3].Value.ToString();
            txt_chieudail.Text = dgv_thongso.CurrentRow.Cells[4].Value.ToString();
            txt_lopbaove.Text = dgv_thongso.CurrentRow.Cells[5].Value.ToString();
            txt_Mx.Text = dgv_thongso.CurrentRow.Cells[6].Value.ToString();
            txt_My.Text = dgv_thongso.CurrentRow.Cells[7].Value.ToString();
            txt_N.Text = dgv_thongso.CurrentRow.Cells[8].Value.ToString();
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }
        #endregion

    }
}
