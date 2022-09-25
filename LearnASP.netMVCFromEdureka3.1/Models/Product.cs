using System;

namespace LearnASP.netMVCFromEdureka3._1.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public DateTime MfgDate { get; set; }
    }
}
