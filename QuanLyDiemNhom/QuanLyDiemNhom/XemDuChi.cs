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
    public partial class XemDuChi : DevExpress.XtraEditors.XtraForm
    {
        private int idkehoach;
        private string tenkehoach;
        private DateTime ngaybatdau;
        private DateTime ngayketthuc;
        private string quanly1;
        private string quanly2;
        private int tongchiphi;
        private string mota;
        public XemDuChi(int idkehoach, string tenkehoach, DateTime ngaybatdau, DateTime ngayketthuc, string quanly1, string quanly2, int tongchiphi, string mota)
        {
            InitializeComponent();
            this.idkehoach = idkehoach;
            this.tenkehoach = tenkehoach;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.quanly1 = quanly1;
            this.quanly2 = quanly2;
            this.tongchiphi = tongchiphi;
            this.mota = mota;
            this.txttenduan.Text = tenkehoach;
            this.txttongchiphi.Text = tongchiphi.ToString();
            this.dttungay.Text = ngaybatdau.ToString();
            this.dtdenngay.Text = ngayketthuc.ToString();
            this.txtquanly1.Text = quanly1;
            this.txtquanly2.Text = quanly2;
            this.txtmota.Text = mota;
            LoadHangMucByIdKeHoach();
            CalculateTotalChiPhi();
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
        void LoadHangMucByIdKeHoach()
        {
            dtgvhangmuc.DataSource = KeHoachDuChiDAO.Instance.GetHangMucByIdKeHoach(idkehoach);
        }

        private void btnthemhangmuc_Click(object sender, EventArgs e)
        {
            string tenhangmuc = txthangmuc.Text;
            float tienduchi = float.Parse(txtchiphi.Text);
            string loaitien = cbloaitien.Text;
            if (loaitien == "Chọn loại tiền")
            {
                MessageBox.Show("Vui lòng chọn loại tiền");
                return;
            }
            else
            {
                if (KeHoachDuChiDAO.Instance.InsertHangMucById(tenhangmuc, tienduchi, loaitien, idkehoach))
                {
                    this.txthangmuc.Clear();
                    this.txtchiphi.Text = "0";
                    this.cbloaitien.Text = "Chọn loại tiền";
                    LoadHangMucByIdKeHoach();
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
                    LoadHangMucByIdKeHoach();
                    CalculateTotalChiPhi();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluuphieu_Click(object sender, EventArgs e)
        {
            string tenkehoach = txttenduan.Text;
            DateTime ngaybatdau = DateTime.Parse(dttungay.Text);
            DateTime ngayketthuc = DateTime.Parse(dtdenngay.Text);
            float tongchiphi =  float.Parse(txttongchiphi.Text);
            string quanly1 = txtquanly1.Text;
            string quanly2 = txtquanly2.Text;
            string mota = txtmota.Text;
            if(KeHoachDuChiDAO.Instance.UpdateKeHoach(tenkehoach, ngaybatdau, ngayketthuc, quanly1,quanly2,mota,tongchiphi,idkehoach))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}