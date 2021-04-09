using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class DinhLuongMonAn
    {
        public int Id { get; set; }
        public string MaMonAn { get; set; }
        public DateTime Ngay { get; set; }
        public string BuaAn { get; set; }
        public string MaThucPham { get; set; }
        public float SoLuong { get; set; }
        public MonAn MonAn { get; set; }
        public ThucPham ThucPham { get; set; }
    }
}
