using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDApplication.Models
{
    public class AllocateClassRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassroomAllocationId { get; set; }

        [ForeignKey(nameof(TeacherID))]
        public int TeacherID { get; set; }

        public Teacher Teacher { get; set;}

        [ForeignKey(nameof(ClassRoomId))]
        public int ClassRoomId { get; set;}
        public ClassRoom classRoom { get; set;}
    }
}
