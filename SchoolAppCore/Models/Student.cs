namespace SchoolAppCore.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateOnly EnrollmentDate { get; set; }
    }
}
