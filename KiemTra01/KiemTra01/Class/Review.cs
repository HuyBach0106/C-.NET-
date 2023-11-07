using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra01.Class
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }

        public Review() { }

        public Review(int reviewID, int productID, string customerName, string customerEmail, int rating, string comments)
        {
            ReviewID = reviewID;
            ProductID = productID;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            Rating = rating;
            Comments = comments;
        }

        public override string ToString()
        {
            return $"ReviewID: {ReviewID}, ProductID: {ProductID}, CustomerName: {CustomerName}, CustomerEmail: {CustomerEmail}, Rating: {Rating}, Comments: {Comments}";
        }

    }

}
