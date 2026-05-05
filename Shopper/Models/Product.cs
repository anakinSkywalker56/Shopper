using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Shopper.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        [ValidateNever]
        public Category Category { get; set; }
    }
}
