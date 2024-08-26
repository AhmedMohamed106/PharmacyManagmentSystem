using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.BLL.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public string Generic_Name { get; set; }
        public string Type { get; set; }      
        public int Sale_Rate { get; set; }
        public int Purchase_Rate {  get; set; }
        public int Quantity { get; set; }


        [DataType(DataType.Date)]
        public DateTime Expire_Date {get; set;}
        public string Patch_Num { get; set; }
        public string Company {  get; set; }
        public string Pack_Size { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}
