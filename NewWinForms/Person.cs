using System;
using System.Collections.Generic;
using System.Text;

namespace NewWinForms
{
    class Person
    {
        protected string name;
        protected string surname;
        protected int age;
        
        
        public Person(string name, string surname,int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public string GetInfo()
        {
            return ($"Name:{name}\nAge:{age}\n");
        }
        public String Name { get { return name; } set { name = value; } }
        public String Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } }
    }
}
