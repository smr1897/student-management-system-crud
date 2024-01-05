using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDApplication.Models
{
    public class ClassRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassRoomId { get; set; }

        [Required]
        public string ClassRoomName { get; set; }

        //public ICollection<AllocateClassRoom> TeacherAllocations { get; set; }
    }
}
