using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models.Entities
{
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }

        

    }
}