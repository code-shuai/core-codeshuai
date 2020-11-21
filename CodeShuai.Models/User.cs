using System;

namespace CodeShuai.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
