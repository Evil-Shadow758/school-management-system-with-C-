using ConsoleApp12.data;
using ConsoleApp12.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.logic
{
    public class CourseService
    {
        SchoolSystemDBcontext _db = new SchoolSystemDBcontext();
        public void AddCourses()
        {
            Console.WriteLine("Subject: ");
            string subject = Console.ReadLine();

            Console.WriteLine("Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Time: ");
            string time = Console.ReadLine();

            Course course = new Course()
            {
                Subject = subject,
                Time = time,
                Price = price
            };

            _db.Courses.Add(course);
            _db.SaveChanges();

            Console.WriteLine("Course Added Successfully");
        }

        public void AllCourses()
        {
            var courses = _db.Courses.ToList();
            foreach (var course in courses)
            {
                Console.WriteLine($"Subject: {course.Subject}, Price: {course.Price}, Time: {course.Time}");
            }
        }
    }
}
