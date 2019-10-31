using System;
using System.Collections.Generic;
using System.Text;

namespace BT3_16520339
{
    public class DSHoaTheoLoai : List<Hoa>
    {
        public string TenLoai { get; set; }
        public DSHoaTheoLoai(string STenloai)
        {
            TenLoai = STenloai;
        }
    }
}
