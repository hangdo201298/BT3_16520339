using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT3_16520339
{
    public class LoaiHoa
    {
        [PrimaryKey, AutoIncrement]
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
    }
}
