using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShuai.Models
{
    public class Label
    {
        public int ID { get; set; }
        public string LabelName { get; set; }
        public string LabelCode { get; set; }
        public string Remark { get; set; }
        public int State { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
