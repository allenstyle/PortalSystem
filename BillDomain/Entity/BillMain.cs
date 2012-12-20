using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillDomain.Entity
{
    public class BillMain: Base
    {        
        public int Id { get; set; }
        public string BillDate { get; set; }
        public string BillMemo { get; set; }
    }
}
