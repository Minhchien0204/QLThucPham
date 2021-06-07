﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Models.ChiTietCungCap
{
    public class ChiTietCungCapModel
    {
        public int Id { get; set; }
        public string SoPhieuCugCap { get; set; }
        public string MaThucPham { get; set; }
        public string TenThucPham { get; set; }
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public float SoLuong { get; set; }
    }
}
