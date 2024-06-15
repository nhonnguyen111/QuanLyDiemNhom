using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyDiemNhom.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemNhom
{
    public partial class LapDuChi : DevExpress.XtraEditors.XtraForm
    {
        public LapDuChi()
        {
            InitializeComponent();
            this.dttungay.Text = DateTime.Today.ToString();
            this.dtdenngay.Text = DateTime.Today.ToString();
        }
        void CalculateTotalChiPhi()
        {
            GridView gridView = dtgvhangmuc.MainView as GridView;

            if (gridView != null)
            {
                float totalChiPhi = 0;

                for (int i = 0; i < gridView.RowCount; i++)
                {
                    object valueTienDuChi = gridView.GetRowCellValue(i, "TienDuChi");
                    object valueLoaiTien = gridView.GetRowCellValue(i, "LoaiTien");

                    if (valueTienDuChi != null && valueTienDuChi != DBNull.Value && valueLoaiTien != null && valueLoaiTien != DBNull.Value)
                    {
                        float tienduchi = Convert.ToSingle(valueTienDuChi);
                        string loaitien = valueLoaiTien.ToString();

                        if (loaitien == "USD")
                        {
                            tienduchi *= 25400;
                        }

                        totalChiPhi += tienduchi;
                    }
                }

                txttongchiphi.Text = totalChiPhi.ToString();
            }
        }

        void LoadHangMuc()
        {
            dtgvhangmuc.DataSource = KeHoachDuChiDAO.Instance.GetHangMucNull();
        }
        private void btnthemhangmuc_Click(object sender, EventArgs e)
        {
            string tenhangmuc = txthangmuc.Text;
            float tienduchi = float.Parse(txtchiphi.Text);
            string loaitien = cbloaitien.Text;
            if(loaitien == "Chọn loại tiền")
            {
                MessageBox.Show("Vui lòng chọn loại tiền");
                return;
            }
            else
            {
                if (KeHoachDuChiDAO.Instance.InsertHangMuc(tenhangmuc, tienduchi, loaitien))
                {
                    this.txthangmuc.Clear();
                    this.txtchiphi.Text = "0";
                    this.cbloaitien.Text = "Chọn loại tiền";
                    LoadHangMuc();
                    CalculateTotalChiPhi();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            
        }

        

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idhangmuc = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdHangMucDuChi"));
                if (KeHoachDuChiDAO.Instance.DeleteHangMuc(idhangmuc))
                {
                    LoadHangMuc();
                    CalculateTotalChiPhi();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnluuphieu_Click(object sender, EventArgs e)
        {
            string tenkehoach = txttenduan.Text;
            DateTime ngaybatdau = DateTime.Parse(dttungay.Text);
            DateTime ngayketthuc = DateTime.Parse(dtdenngay.Text);
            string quanly1 = txtquanly1.Text;
            string quanly2 = txtquanly2.Text;
            float tongchiphi =float.Parse( txttongchiphi.Text);
            string mota = txtmota.Text;
            int newIdKeHoach = KeHoachDuChiDAO.Instance.InsertKeHoach(tenkehoach, ngaybatdau, ngayketthuc, quanly1, quanly2, tongchiphi, mota);

            if (newIdKeHoach > 0)
            {
                MessageBox.Show("Tạo kế hoạch mới thành công");

                GridView gridView = dtgvhangmuc.MainView as GridView;

                if (gridView != null)
                {
                    for (int i = 0; i < gridView.RowCount; i++)
                    {
                        int idhangmuc = Convert.ToInt32(gridView.GetRowCellValue(i, "IdHangMucDuChi"));
                        KeHoachDuChiDAO.Instance.UpdateHangMuc(newIdKeHoach, idhangmuc);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo kế hoạch mới thất bại");
            }
        }

        private void btndong_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đóng không?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                if (KeHoachDuChiDAO.Instance.DeleteHangMucNull())
                {
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Lỗi không thể đóng thất bại");
                }

               
            }
        }
    }
}