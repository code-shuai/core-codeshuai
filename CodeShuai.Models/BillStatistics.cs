using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShuai.Models
{
    public class BillStatistics
    {
        public string LabelCode { get; set; }
        public string LabelName { get; set; }
        public int BillCount { get; set; }
        public decimal BillCountMoney { get; set; }
    }
}
