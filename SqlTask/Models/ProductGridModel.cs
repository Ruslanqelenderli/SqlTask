using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask.Models
{
   public class ProductGridModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice{ get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
