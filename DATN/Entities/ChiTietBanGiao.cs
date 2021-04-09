using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class ChiTietBanGiao
    {
        public int Id { get; set; }
        public string SoPhieuBanGiao { get; set; }
        public string MaThucPham { get; set; }
        public float SoLuong { get; set; }
        public PhieuBanGiao PhieuBanGiao { get; set; }
        public ThucPham ThucPham { get; set; }
    }
}
