using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLaiSuat.NewFolder
{
    public class ClsOrders
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }  
    }
}
