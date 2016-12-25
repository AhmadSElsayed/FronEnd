using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Model
{
    public partial class AllBranchData
    {
        public int BranchID { get; set; }

        public string Location { get; set; }

        public decimal Sales { get; set; }

        public decimal Profit { get; set; }

        public int MangerID { get; set; }

        public string Name { get; set; }

        public int ProductListID { get; set; }

        public string ProductListName { get; set; }
    }
}
