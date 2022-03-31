using System;
using System.Collections.Generic;
using System.Text;

namespace _11_MVC
{
    internal class Controller
    {
        private Student model;
        
        public Controller(Student model)
        {
            this.model = model;
        }

        public void SetName(string name)
        {
            model.Name = name;
        }

        public void SetId(string id)
        {
            model.Id = id;
        }

        public void UpdateView()
        {
            new View().Print(model.Id, model.Name);
        }

        public void UpdateView2()
        {
            new View2().Print(model.Name);
        }

    }
}
