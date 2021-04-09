using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class PhieuCungCap
    {
        public string SoPhieuCugCap { get; set; }
        public string MaNhaCungCap { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public bool TrangThai { get; set; }
        public string GhiChu { get; set; }
        public NhanVien NhanVien { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public ICollection<ChiTietCungCap> ChiTietCungCaps { get; set; }

    }
}
