using System;

namespace _11_MVC
{
    class Program
    {
        static Student LoadFromDb()
        {   
            Student student = new Student();

            student.Name = "bob";
            student.Id = "1";

            return student;
        }

        static void Main(string[] args)
        {
            Student model = LoadFromDb();
            Controller controller = new Controller(model);

            controller.UpdateView();
            
            controller.SetName("Sally");
            controller.SetId("2");
            
            controller.UpdateView2();
        }
        
    }
}
