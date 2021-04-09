using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class BoPhan
    {
        public string MaBoPhan { get; set; }
        public string TenBoPhan { get; set; }
        public ICollection<NhanVien> NhanViens { get; set; }
    }
}
