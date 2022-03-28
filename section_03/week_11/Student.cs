using System;
using System.Collections.Generic;
using System.Text;

namespace _11_MVC
{
    internal class Student
    {
        string id;
        string name;

        public string GetId() {return id;}
        public void SetId(string id) {this.id = id;}
        public string GetName() {return name;}
        public void SetName(string name) {this.name = name;}

        //can also have methods specific to manipulating this data model
    }
}
