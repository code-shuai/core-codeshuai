﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShuai.Models
{
    public class Bill
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public decimal Money { get; set; }
        public string Remark { get; set; }
        public string Lable { get; set; }
        public DateTime AddTime { get; set; }
    }
}