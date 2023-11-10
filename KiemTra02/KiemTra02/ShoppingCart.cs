using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra02
{
    public class ShoppingCart
    {
        public int RecordID { get; set; }
        public int CartID { get; set; }

        public int Quantity { get; set; }

        public int ProductID { get; set; }

        public DateTime DateCreated { get; set; }

        public ShoppingCart() { }
        public ShoppingCart(int recordID, int cartID, int quantity, int productID, DateTime dateCrreated)
        {
            RecordID = recordID;
            CartID = cartID;
            Quantity = quantity;
            ProductID = productID;
            DateCreated = dateCrreated;
        }

        public override string ToString()
        {
            return $"RecordID: {RecordID}, CartID: {CartID}, Quantity: {Quantity}, ProductID: {ProductID}, DateCreated: {DateCreated}";
        }
    }
}
