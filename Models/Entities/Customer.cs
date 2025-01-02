using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models.Entities
{
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }
        public string FullName { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
    }
}