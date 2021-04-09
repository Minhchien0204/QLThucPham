using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public int UserId { get; set; }
        public string MaBoPhan { get; set; }
        public BoPhan BoPhan { get; set; }
        public virtual User User { get; set; }
        public ICollection<PhieuYeuCau> PhieuYeuCaus { get; set; }
        public ICollection<PhieuCungCap> PhieuCungCaps { get; set; }
        public ICollection<PhieuKiemKe> PhieuKiemKes { get; set; }
        public ICollection<PhieuGiao> PhieuGiaos { get; set; }
        public ICollection<PhieuBanGiao> PhieuBanGiaos { get; set; }
        public ICollection<MonAn> MonAns { get; set; }

    }
}
