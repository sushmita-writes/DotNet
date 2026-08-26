using System.ComponentModel.DataAnnotations;

namespace Lab_10.Models
{
    public class StudentModel
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Grade { get; set; }
        public long PhoneNumber {  get; set; }

    }
}
