using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class MonAn
    {
        public string MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public string MaNhanVien { get; set; }
        public ICollection<DinhLuongMonAn> DinhLuongMonAns { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
