﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWinForm
{
    class HangHoa
    {
        public string MaHang { get; set; }

        public string TenHang { get; set; }

        public string DVT { get; set; }

        public string SoLuong { get; set; }

        public string DonGia { get; set; }

        public HangHoa()
        {

        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaHang, TenHang, DVT, SoLuong, DonGia);
        }
    }
}
