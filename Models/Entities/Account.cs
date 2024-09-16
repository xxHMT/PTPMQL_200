using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models.Entities
{
    public class Account
    {
        [Key]
        public string AccountEmail { get; set; }
        public string AccountPassword { get; set; }
    }
}
