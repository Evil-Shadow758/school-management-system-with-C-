using ConsoleApp12.data;
using ConsoleApp12.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.logic
{
    public class EnrollmentService
    {
        SchoolSystemDBcontext _db = new SchoolSystemDBcontext();

        public void StudentEnrollCourse()
        {
            Console.WriteLine("StudentID: ");
            int studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("CourseID: ");
            int courseId = int.Parse(Console.ReadLine());

            Enroll enrollment = new Enroll()
            {
                StudentId = studentId,
                CourseId = courseId
            };

            _db.Enrolls.Add(enrollment);
            _db.SaveChanges();

            Console.WriteLine("Student enrolled Successfully");
        }

        public void AllStudentEnrollments()
        {
            Console.WriteLine("StudentID: ");
            int studentId = int.Parse(Console.ReadLine());

            var enrollments = _db.Enrolls.Where(s => s.StudentId == studentId).ToList();

            foreach (var enrollment in enrollments)
            {
                var course = _db.Courses.Where(c => c.Id == enrollment.CourseId).FirstOrDefault();

                if(course != null)
                {
                    Console.WriteLine($"Subject: {course.Subject}, Price: {course.Price}, Time: {course.Time}");
                }
            }
        }
    }
}
