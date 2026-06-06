using ConsoleApp12.data;
using ConsoleApp12.models;
using Microsoft.Identity.Client;
using SchoolSystem.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SchoolSystem.logic
{
    public class TeacherService
    {
        SchoolSystemDBcontext _db = new SchoolSystemDBcontext();

        public void AddTeacher()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("CourseID: ");
            int courseId = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();


            Teacher teacher = new Teacher()
            {
                Name = name,
                CourseID = courseId,
                Email = email
            };

            _db.Teachers.Add(teacher);
            _db.SaveChanges();

            Console.WriteLine("Teacher Added Successfully");
        }

        public void UpdateTeacher()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            var teacher = _db.Teachers.FirstOrDefault(s => s.Id == id);

            if (teacher != null)
            {
                Console.Write("name: ");
                string UpdatedName = Console.ReadLine();

                teacher.Name = UpdatedName;
                _db.Teachers.Update(teacher);
                _db.SaveChanges();

                Console.WriteLine("Teacher updated Successfully");
            }
            else
            {
                Console.WriteLine("Teacher is not exist");
            }
        }

        public void DeleteTeacher()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            var teacher = _db.Teachers.FirstOrDefault(s => s.Id == id);

            if (teacher != null)
            {
                _db.Teachers.Remove(teacher);
                _db.SaveChanges();

                Console.WriteLine("Teacher Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Teacher is not exist");
            }
        }

        public void AllTeachers()
        {
            var Teacher = _db.Teachers.ToList();
            foreach (var teacher in Teacher)
            {
                Console.WriteLine($"Name: {teacher.Name}, CourseId: {teacher.CourseID}, Email: {teacher.Email}");
            }
        }

        public void TeacherById()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            var teacher = _db.Teachers.FirstOrDefault(s => s.Id == id);

            if (teacher != null)
            {
                Console.WriteLine($"Name: {teacher.Name}, CourseId: {teacher.CourseID}, Email: {teacher.Email}");
            }
            else
            {
                Console.WriteLine("Teacher is not exist");
            }
        }
    }
}
