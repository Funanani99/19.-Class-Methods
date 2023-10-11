using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "John", 15);
            Student student2 = new Student(40, "Tim", 10);

            Console.WriteLine(student1.IsObese());
            Console.WriteLine(student2.IsObese());
            Console.ReadLine();

        }
    }


    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int aAge)
        {
            this.weight = weight;// the word this is an explicit way of ma
            this.name = name;
            this.age = age;
        }
        //You now have onee stop shop to test Obesity of your students and
        public bool IsObese()
        {
            if (weight > 60)
            {
                return true;
            }
            else return false;
        }
    }
}