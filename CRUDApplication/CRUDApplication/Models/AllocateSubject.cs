using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDApplication.Models
{
    public class AllocateSubject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectAllocationId { get; set; }

        [ForeignKey(nameof(TeacherID))]
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
