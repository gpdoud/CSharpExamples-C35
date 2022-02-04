using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples {
    public class Student {

        public static int BootcampDaysRemaining { get; set; }

        private static decimal PI = 3.1415927m;

        private static int NextId = 1;
        public int Id { get; set; }
        public string Name { get; set; } // properties
        private bool IsVeteran { get; set; }
        public string Zipcode { get; set; }

        // methods : actions on the class
        public void Print() {
            Console.WriteLine($"Student's Id is {Id}, name is {Name}, and zip is {Zipcode}");
            Console.WriteLine($"Days remaining is {BootcampDaysRemaining}");
        }
        public string GetMessage(string caller) {
            return $"Student's name is {Name} and zip is {Zipcode} from {caller}";
        }

        // constructor
        public Student(string name, string zipcode) {
            this.Id = NextId;
            NextId++;
            this.Name = name;
            this.Zipcode = zipcode;
        }
        public Student(string name) {
            this.Id = NextId;
            NextId++;
            this.Name = name;
        }
        public Student() {
            this.Id = NextId;
            NextId++;

        }


        public static void Run() {

            Student.BootcampDaysRemaining = 65;

            Student Dawit = new Student("Dawit", "20202");

            Student Jeff = new Student("Jeff", "12345");

            Student Philip = new Student("Philip");
            Philip.Zipcode = "98765";

            Student Myla = new Student();
            Myla.Name = "Myla";
            Myla.Zipcode = "87374";

            Myla.Print();
            Dawit.Print();

            Student.BootcampDaysRemaining = 54;

            Philip.Print();
            Jeff.Print();

            string str = Philip.GetMessage("Myla");
            Console.WriteLine(str);
        }
    }
    public class Teacher {

        public static void Run() {

            Student Greg = new Student();
            Greg.Name = "Greg";
            //Greg.IsVeteran = true;

        }
        
    }
}
