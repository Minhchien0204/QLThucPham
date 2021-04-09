using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class PhieuAn
    {
        public string SophieuAn { get; set; }
        public string MaGiaoVien { get; set; }
        public DateTime NgayLap { get; set; }
        public int SoLuong { get; set; }
        public bool TrangThai { get; set; }
        public string GhiChu { get; set; }
        public GiaoVien GiaoVien { get; set; }
    }
}
