﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT3_16520339
{
    public class Hoa
    {
        [PrimaryKey, AutoIncrement]
        public int MaHoa { get; set; }
        public int MaLoai { get; set; }
        public string TenHoa { get; set; }
        public string Hinh { get; set; }
        public string MoTa { get; set; }
        public double Gia { get; set; }
    }
}
