using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class NhaCungCap
    {
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public ICollection<PhieuCungCap> PhieuCungCaps { get; set; }
        public ICollection<PhieuGiao> PhieuGiaos { get; set; }
    }
}
