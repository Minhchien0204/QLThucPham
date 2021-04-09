using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class ChiTietKiemKe
    {
        public int Id { get; set; }
        public string SoPhieuKiemKe { get; set; }
        public string MaThucPham { get; set; }
        public float SoLuong { get; set; }
        public string ChatLuong { get; set; }
        public PhieuKiemKe PhieuKiemKe { get; set; }
        public ThucPham ThucPham { get; set; }
    }
}
