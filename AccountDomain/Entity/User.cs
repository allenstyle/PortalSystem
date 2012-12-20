using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountDomain.Entity
{
    public class User: Base
    {
        public int Id { get; set; }
        public string UserAccount { get; set; }
        public string UserPassword { get; set; }
        public string UserNickName { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public int IsActive { get; set; }
        public int IsBlock { get; set; }
    }
}
