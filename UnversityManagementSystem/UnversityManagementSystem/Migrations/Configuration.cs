using System.Collections.Generic;
using UnversityManagementSystem.Models;

namespace UnversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UnversityManagementSystem.Models.ProjectDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UnversityManagementSystem.Models.ProjectDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var departments = new List<Department>
            {
                new Department {DeptCode = "CSE", DeptName = "Computer Science and Engineering"},
                new Department {DeptCode = "EEE", DeptName = "Electrical and Electronics Engineering"},
                new Department {DeptCode = "BBA", DeptName = "Bachelor of Business Administrator"}
                   
            };
            departments.ForEach(s => context.Departments.AddOrUpdate(p => p.DeptCode, s));
            context.SaveChanges();


            var semesters = new List<Semester>
            {
                new Semester {SemesterName = "1st" },
                new Semester {SemesterName = "2nd" },
                new Semester {SemesterName = "3rd" },
                new Semester {SemesterName = "4th"},
                new Semester {SemesterName = "5th"},
                new Semester {SemesterName = "6th"},
                new Semester {SemesterName = "7th" },
                new Semester {SemesterName = "8th" }
            };
            semesters.ForEach(s => context.Semesters.AddOrUpdate(p => p.SemesterName, s));
            context.SaveChanges();

            var designations = new List<Designation>
            {
                new Designation {DesignationName = "Professor" },
                new Designation {DesignationName = "Asst. Professor" },
                new Designation {DesignationName = "Lecturer" }
                   
            };
            designations.ForEach(s => context.Designations.AddOrUpdate(p => p.DesignationName, s));
            context.SaveChanges();

            var grades = new List<Grade>
            {
                new Grade {GradeName = "A+" },
                new Grade {GradeName = "A" },
                new Grade {GradeName = "A-" },
                new Grade {GradeName = "B+" },
                new Grade {GradeName = "B" },
                new Grade {GradeName = "B-" },
                new Grade {GradeName = "C+" },
                new Grade {GradeName = "C" },
                new Grade {GradeName = "C-" },
                new Grade {GradeName = "D+" },
                new Grade {GradeName = "D" },
                new Grade {GradeName = "D-" },
                new Grade {GradeName = "F" }

          
            };
            grades.ForEach(s => context.Grades.AddOrUpdate(p => p.GradeName, s));
            context.SaveChanges();
            var rooms = new List<Room>
            {
                new Room {Name = "101" },
                new Room {Name = "102" },
                new Room {Name = "103" },
                new Room {Name = "201" },
                new Room {Name = "202" },
                new Room {Name = "203" },
                new Room {Name = "301" },
                new Room {Name = "302" },
                new Room {Name = "303" },
          
            };
            rooms.ForEach(s => context.Rooms.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var days = new List<Day>
            {
                new Day {Name = "Saturday"},
                new Day {Name = "Sunday"},
                new Day {Name = "Monday"},
                new Day {Name = "Tuesday"},
                new Day {Name = "Wednesday"},
                new Day {Name = "Thursday"},
                new Day {Name = "Friday"}
               
            };

            days.ForEach(d => context.Days.AddOrUpdate(p => p.Name, d));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course {CourseCode = "CSE-111", CourseName = "Computer Fundamental", Credit = 3.0, Description="Basic Computer Fundamental", DepartmentId=1, SemesterId=1, Status=true},
                new Course {CourseCode = "CSE-123", CourseName = "Programming with C", Credit = 3.0, Description="Basic Computer Programming with C", DepartmentId=1, SemesterId=2, Status=true},
                new Course {CourseCode = "CSE-222", CourseName = "Data Structure", Credit = 3.0, Description="Data Structure", DepartmentId=1, SemesterId=4, Status=true},
                new Course {CourseCode = "CSE-315", CourseName = "Engineering Mathematics", Credit = 3.0, Description="Engineering Mathematics", DepartmentId=1, SemesterId=5, Status=true},
                new Course {CourseCode = "CSE-321", CourseName = "Software Engineering", Credit = 3.0, Description="Software Engineering", DepartmentId=1, SemesterId=6, Status=true},
                new Course {CourseCode = "EEE-111", CourseName = "Electronic Device", Credit = 3.0, Description="Intruduction to Electronic Devices", DepartmentId=2, SemesterId=1, Status=true},
                new Course {CourseCode = "EEE-123", CourseName = "Digital Logic Design", Credit = 3.0, Description="Digital Logic Design", DepartmentId=2, SemesterId=2, Status=false},
                new Course {CourseCode = "EEE-222", CourseName = "Microcontroller", Credit = 3.0, Description="Introduction to Microcontroller", DepartmentId=2, SemesterId=4, Status=true},
                new Course {CourseCode = "BBA-111", CourseName = "Basic Accounting", Credit = 3.0, Description="Basic Accounting", DepartmentId=3, SemesterId=1, Status=true},
                new Course {CourseCode = "BBA-123", CourseName = "Micro Finance", Credit = 3.0, Description="Micro Finance", DepartmentId=3, SemesterId=2, Status=true},
                new Course {CourseCode = "BBB-222", CourseName = "Business Math", Credit = 3.0, Description="Business Math", DepartmentId=3, SemesterId=4, Status=true}
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.CourseCode, s));
            context.SaveChanges();
            var teachers = new List<Teacher>
            {
                new Teacher {TeacherName =  "Kamrul Islam", Address = "Jessore", Email = "kamrul@mail.com", ContactNo = "0174584858", DesignationId = 2, DepartmentId = 2, TakenCredit = 30, RemainingCredit = 30},
                new Teacher {TeacherName =  "Md. Shahidul Islam", Address = "Rajshahi", Email = "shahidul@mail.com", ContactNo = "019648875", DesignationId = 3, DepartmentId = 1, TakenCredit = 27, RemainingCredit = 27},
               new Teacher {TeacherName =  "Hafizur Rahman", Address = "Chittagong", Email = "hafiz@mail.com", ContactNo = "0155555558", DesignationId = 1, DepartmentId = 3, TakenCredit = 30, RemainingCredit = 30}
            };

            teachers.ForEach(t => context.Teachers.AddOrUpdate(tn => tn.TeacherName, t));
            context.SaveChanges();

            //var students = new List<Student>
            //{
            //    new Student {StudentName = "Md. Mahid Choudhury", Email = "mahid@mail.com", ContactNo = "01911111111", Date =2015-09-19, },

            //};

            //students.ForEach(s => context.Students.AddOrUpdate(sn => sn.StudentName, s));
            //context.SaveChanges();
        }
    }
}
