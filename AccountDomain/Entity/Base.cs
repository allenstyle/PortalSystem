using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountDomain.Entity
{
    public class Base
    {
        public string TenantId { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
