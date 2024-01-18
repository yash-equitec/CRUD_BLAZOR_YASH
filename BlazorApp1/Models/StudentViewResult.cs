using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public partial class StudentViewResult
    {
        [Required(ErrorMessage = "Student Name is required")]
        public string ?Student_Name { get; set; }
        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime Student_DOB { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(1, 150, ErrorMessage = "Please enter a valid age between 1 and 150")]
        public int Student_Age { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string ?Student_Gender { get; set; }
        [Required(ErrorMessage = "Mobile number is required")]
        public int Student_Mobile { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string ?Student_Address { get; set; }
        public bool IsDeleted { get; set; }
        public int Student_ID { get; set; }
    }
}
