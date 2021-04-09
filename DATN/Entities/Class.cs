using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Entities
{
    public class Class
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public virtual GiaoVien GiaoVien { get; set; }
    }
}
