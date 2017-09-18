namespace UnversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssignCourses",
                c => new
                    {
                        AssignCourseId = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        TakenCredit = c.Double(nullable: false),
                        RemainingCredit = c.Double(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AssignCourseId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: false)
                .Index(t => t.DepartmentId)
                .Index(t => t.TeacherId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseCode = c.String(nullable: false, maxLength: 20),
                        CourseName = c.String(nullable: false),
                        Credit = c.Double(nullable: false),
                        Description = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        SemesterId = c.Int(nullable: false),
                        AssignTo = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .ForeignKey("dbo.Semesters", t => t.SemesterId, cascadeDelete: false)
                .Index(t => t.DepartmentId)
                .Index(t => t.SemesterId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DeptCode = c.String(nullable: false, maxLength: 7),
                        DeptName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        SemesterId = c.Int(nullable: false, identity: true),
                        SemesterName = c.String(),
                    })
                .PrimaryKey(t => t.SemesterId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(nullable: false),
                        Address = c.String(),
                        Email = c.String(),
                        ContactNo = c.String(),
                        DesignationId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        TakenCredit = c.Double(nullable: false),
                        RemainingCredit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .ForeignKey("dbo.Designations", t => t.DesignationId, cascadeDelete: false)
                .Index(t => t.DesignationId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        DesignationId = c.Int(nullable: false, identity: true),
                        DesignationName = c.String(),
                    })
                .PrimaryKey(t => t.DesignationId);
            
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        DayId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DayId);
            
            CreateTable(
                "dbo.EnrollCourses",
                c => new
                    {
                        EnrollCourseId = c.Int(nullable: false, identity: true),
                        RegistrationId = c.String(nullable: false),
                        CourseId = c.Int(nullable: false),
                        EnrollDate = c.DateTime(nullable: false),
                        GradeName = c.String(),
                        Student_StudentId = c.Int(),
                    })
                .PrimaryKey(t => t.EnrollCourseId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Students", t => t.Student_StudentId)
                .Index(t => t.CourseId)
                .Index(t => t.Student_StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false),
                        Email = c.String(),
                        ContactNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        Address = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        RegistrationId = c.String(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        GradeName = c.String(),
                    })
                .PrimaryKey(t => t.GradeId);
            
            CreateTable(
                "dbo.RoomAllocations",
                c => new
                    {
                        RoomAllocationId = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        DayId = c.Int(nullable: false),
                        StartTime = c.Int(nullable: false),
                        EndTime = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.RoomAllocationId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: false)
                .ForeignKey("dbo.Days", t => t.DayId, cascadeDelete: false)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: false)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: false)
                .Index(t => t.DepartmentId)
                .Index(t => t.CourseId)
                .Index(t => t.RoomId)
                .Index(t => t.DayId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomAllocations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.RoomAllocations", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.RoomAllocations", "DayId", "dbo.Days");
            DropForeignKey("dbo.RoomAllocations", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.EnrollCourses", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.EnrollCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.AssignCourses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.Teachers", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.AssignCourses", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.AssignCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters");
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.RoomAllocations", new[] { "DayId" });
            DropIndex("dbo.RoomAllocations", new[] { "RoomId" });
            DropIndex("dbo.RoomAllocations", new[] { "CourseId" });
            DropIndex("dbo.RoomAllocations", new[] { "DepartmentId" });
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropIndex("dbo.EnrollCourses", new[] { "Student_StudentId" });
            DropIndex("dbo.EnrollCourses", new[] { "CourseId" });
            DropIndex("dbo.Teachers", new[] { "DepartmentId" });
            DropIndex("dbo.Teachers", new[] { "DesignationId" });
            DropIndex("dbo.Courses", new[] { "SemesterId" });
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropIndex("dbo.AssignCourses", new[] { "CourseId" });
            DropIndex("dbo.AssignCourses", new[] { "TeacherId" });
            DropIndex("dbo.AssignCourses", new[] { "DepartmentId" });
            DropTable("dbo.Rooms");
            DropTable("dbo.RoomAllocations");
            DropTable("dbo.Grades");
            DropTable("dbo.Students");
            DropTable("dbo.EnrollCourses");
            DropTable("dbo.Days");
            DropTable("dbo.Designations");
            DropTable("dbo.Teachers");
            DropTable("dbo.Semesters");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
            DropTable("dbo.AssignCourses");
        }
    }
}
