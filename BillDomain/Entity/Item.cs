using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillDomain.Entity
{
    public class Item: Base
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int ItemBudget { get; set; }
        public int ItemGroup { get; set; }
        public string ItemDescription { get; set; }
    }
}
