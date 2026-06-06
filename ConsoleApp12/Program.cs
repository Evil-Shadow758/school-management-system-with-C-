using SchoolSystem.logic;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO The School Mangement System!");

            while (true)
            {
                Console.WriteLine(@"Choose An Operation : 
                    1. Add Student
                    2. Update Student
                    3. Delete Student
                    4. Show All Students
                    5. Show A Student By ID
                    6. Add Course
                    7. Show All Courses
                    8. Enroll Student In Course
                    9. Show All Student Courses
                    10. Add Teacher
                    11. Update Teacher
                    12. Delete Teacher
                    13. Show All Teachers
                    14. Show A Teacher By ID
                    15. Exit
                    ");

                StudentService studentService = new StudentService();
                CourseService courseService = new CourseService();
                EnrollmentService enrollmentService = new EnrollmentService();
                TeacherService teacherService = new TeacherService();

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        studentService.AddStudent();
                        break;
                    case 2:
                        studentService.UpdateStudent();
                        break;
                    case 3:
                        studentService.DeleteStudent();
                        break;
                    case 4:
                        studentService.AllStudents();
                        break;
                    case 5:
                        studentService.StudentByID();
                        break;
                    case 6:
                        courseService.AddCourses();
                        break;
                    case 7:
                        courseService.AllCourses();
                        break;
                    case 8:
                        enrollmentService.StudentEnrollCourse();
                        break;
                    case 9:
                        enrollmentService.AllStudentEnrollments();
                        break;
                    case 10:
                        teacherService.AddTeacher();
                        break;
                    case 11:
                        teacherService.UpdateTeacher();
                        break;
                    case 12:
                        teacherService.DeleteTeacher();
                        break;
                    case 13:
                        teacherService.AllTeachers();
                        break;
                    case 14:
                        teacherService.TeacherById();
                        break;
                    case 15:
                        return;

                    default:
                        studentService.AllStudents();
                        break;

                }
            }
        }
    }
}
