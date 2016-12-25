using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Model
{
    public partial class Branch
    {
        /// <summary>
        /// Branch ID
        /// </summary>
        public int BranchID { get; set; }
        /// <summary>
        /// Branch Yearly Sales
        /// </summary>
        public decimal Sales { get; set; }
        /// <summary>
        /// Branch Annual Profit
        /// </summary>
        public decimal Profit { get; set; }
        /// <summary>
        /// Productss in the Branch
        /// </summary>
        public int ProductListID { get; set; }
    }
}
