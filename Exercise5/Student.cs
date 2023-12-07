using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Student
    {
        private string name;
        private int age;
        private string major;

        public Student(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {name}, I am {age} years old, and I am Majoring in {major}. ");
        }
    }
}
