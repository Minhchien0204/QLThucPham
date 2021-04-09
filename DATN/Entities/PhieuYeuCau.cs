using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class PhieuYeuCau
    {
        public string SoPhieuYeuCau { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public bool TrangThai { get; set; }
        public string GhiChu { get; set; }
        public NhanVien NhanVien { get; set; }
        public ICollection<ChiTietYeuCau> ChiTietYeuCaus { get; set; }
        public virtual PhieuBanGiao PhieuBanGiao { get; set; }
    }
}
