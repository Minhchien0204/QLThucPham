using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class PhieuKiemKe
    {
        public string SoPhieuKiemKe { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public string GhiChu { get; set; }
        public NhanVien NhanVien { get; set; }
        public ICollection<ChiTietKiemKe> ChiTietKiemKes { get; set; }
    }
}
