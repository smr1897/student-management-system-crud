using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDApplication.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int Age => CalculateAge();
        [Required]
        public string ClassRoom { get; set; }

        private int CalculateAge()
        {
            int Age = DateTime.Now.Year - DateOfBirth.Year;
            if(DateOfBirth > DateTime.Now.AddYears(-Age))
            {
                Age--;
            }
            return Age;
        }

    }
}
