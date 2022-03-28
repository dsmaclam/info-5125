using System;

namespace _11_MVC
{
    class Program
    {
        static Student LoadFromDb()
        {   
            Student student = new Student();

            student.SetName("Bob");
            student.SetId("1");

            return student;
        }

        static void Main(string[] args)
        {
            Student model = LoadFromDb();
            View view = new View();
            Controller controller = new Controller(model);

            controller.UpdateView1();
            controller.UpdateView2();
            
            controller.SetStudentUId("123");
            controller.SetStudentName("Sally");
            controller.UpdateView1();
            controller.UpdateView2();
        }
        
    }
}
