using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.BLL.Models
{
    public class Sale
    {
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int Product_ID { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey("Customer")]
        public int Customer_ID  { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime Sale_Date { get; set; }
        public int Product_Quantity { get; set; }
        public int Total {  get; set; }
    }
}
