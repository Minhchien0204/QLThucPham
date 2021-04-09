using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class ChiTietCungCap
    {
        public int Id { get; set; }
        public string SoPhieuCungCap { get; set; }
        public string MaThucPham { get; set; }
        public float SoLuong { get; set; }
        public PhieuCungCap PhieuCungCap { get; set; }
        public ThucPham ThucPham { get; set; }
    }
}
