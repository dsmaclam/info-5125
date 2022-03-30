using System;

namespace _11_MVC
{
    class Program
    {
        static Student LoadFromDb()
        {   
            Student student = new Student();

            student.setName("Bob");
            student.setId("1");

            return student;
        }

        static void Main(string[] args)
        {
            Student model = LoadFromDb();
            //View view = new View();
            //Controller controller = new Controller(model, view);

            //controller.UpdateView();
            
            //model.setName("Sam");
            //model.setId("123");
            //controller.UpdateView();
        }
        
    }
}
