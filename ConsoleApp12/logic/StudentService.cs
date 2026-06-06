using ConsoleApp12.data;
using ConsoleApp12.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.logic
{
    public class StudentService
    {
        SchoolSystemDBcontext _db = new SchoolSystemDBcontext();
        public void AddStudent()
        {
            Console.Write("name: ");
            string name = Console.ReadLine();

            Console.Write("age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("email: ");
            string email = Console.ReadLine();


            Student student = new Student()
            {
                Name = name,
                Age = age,
                Email = email
            };
            
            _db.Students.Add(student);
            _db.SaveChanges();

            Console.WriteLine("Student Added Successfully");
        }

        public void UpdateStudent()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            var student = _db.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                Console.Write("name: ");
                string UpdatedName = Console.ReadLine();

                student.Name = UpdatedName;
                _db.Students.Update(student);
                _db.SaveChanges();

                Console.WriteLine("Student updated Successfully");
            }
            else
            {
                Console.WriteLine("student is not exist");
            }
        }

        public void DeleteStudent()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            var student = _db.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();

                Console.WriteLine("Student Deleted Successfully");
            }
            else
            {
                Console.WriteLine("student is not exist");
            }
        }

        public void AllStudents()
        {
            var Student = _db.Students.ToList();
            foreach (var student in Student)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Email: {student.Email}");
            }
        }

        public void StudentByID()
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            var student = _db.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Email: {student.Email}");
            }
            else
            {
                Console.WriteLine("student is not exist");
            }
        }
    }
}
