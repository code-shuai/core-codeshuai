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
        public string LabelCode { get; set; }
        public string LabelName { get; set; }
        public DateTime AddTime { get; set; }
        public int State { get; set; }
    }
}
