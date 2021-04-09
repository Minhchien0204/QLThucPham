using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class ThucPham
    {
        public string MaThuPham { get; set; }

        public string TenThucPham { get; set; }
        public string DonVi { get; set; }
        public ICollection<ChiTietYeuCau> ChiTietYeuCaus { get; set; }
        public ICollection<ChiTietCungCap> ChiTietCungCaps { get; set; }
        public ICollection<ChiTietKiemKe> ChiTietKiemKes { get; set; }
        public ICollection<ChiTietGiao> ChiTietGiaos { get; set; }
        public ICollection<ChiTietBanGiao> ChiTietBanGiaos { get; set; }
        public ICollection<DinhLuongMonAn> DinhLuongMonAns { get; set; }
    } 
}
