using System;
using System.Collections.Generic;
using System.Text;

namespace _11_MVC
{
    internal class Controller
    {
        private Student model;

        public Controller(Student student)
        {
            this.model = student;
        }

        public void SetStudentName(String name)
        {
            model.SetName(name);
        }

        public void SetStudentUId(String id)
        {
            model.SetId(id);
        }

        public void UpdateView1()
        {
            new View().Print(model.GetName(), model.GetId());
        }

        public void UpdateView2()
        {
            new View2().Print(model.GetName());
        }

    }
}
