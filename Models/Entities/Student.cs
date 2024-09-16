using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DemoMvc.Models.Entities
{    public class Student
    {
        
        [Key]
        public string StudentID { get; set; }
        public string FullName { get; set; }

    }
}