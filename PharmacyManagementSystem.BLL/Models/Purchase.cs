using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.BLL.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int Product_ID { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey("Supplier")]
        public int Supplier_ID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public DateTime Purchase_Date { get; set; }
        public int Product_Quantity { get; set; }
        public int Total {  get; set; }
    }
}
