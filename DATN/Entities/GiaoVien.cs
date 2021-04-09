using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class GiaoVien
    {
        public string MaGV { get; set; }
        public string TrinhDo { get; set; }
        public DateTime NgayVao { get; set; }
        public int UserId { get; set; }
        public string MaLop { get; set; }
        public virtual User User { get; set; }
        public virtual Class Class { get; set; }
        public ICollection<PhieuAn> PhieuAns { get; set; }

    }
}
