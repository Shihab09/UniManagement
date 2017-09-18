using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnversityManagementSystem.Models
{
    public class Student
    {
         [Display(Name = "Student")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Name field must not be empty!")]
        [Display(Name = "Name")]
        public string StudentName { get; set; }

        //[Required(ErrorMessage = "Teacher Email Address is required")]
        //[EmailAddress(ErrorMessage = "Please enter a valid email address!")]
        
        //[Column(TypeName = "VARCHAR")]
        //[Index(IsUnique = true)]
        //[StringLength(50)]
        [Display(Name = "Email")]
        [Remote("IsStudentEmailAvailable", "Student", ErrorMessage = "This email already exist.")]
        
        public string Email { get; set; }

        [Phone(ErrorMessage = "Please provide correct Contact No format")]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }


        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department d { get; set; }

        [Display(Name = "Reg. No")]
        public virtual string RegistrationId { get; set; }
    }
}