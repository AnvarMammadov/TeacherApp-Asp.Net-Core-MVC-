using System.ComponentModel.DataAnnotations;

namespace TeacherAp.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }
        public int Age { get; set; }
    }
}
