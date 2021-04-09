using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class ChiTietGiao
    {
        public int Id { get; set; }
        public string SoPhieuGiao { get; set; }
        public string MaThucPham { get; set; }
        public float SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public PhieuGiao PhieuGiao { get; set; }
        public ThucPham ThucPham { get; set; }
    }
}
