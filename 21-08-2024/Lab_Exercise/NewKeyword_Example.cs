    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace NewKeyword
    {
        public class Student1
        {
            public int Id { get; set; } = 1;
            public string Name { get; set; } = "John";
            public void display()
            {
                Console.WriteLine($"Hi I'm {Name} of Id {Id}");
            }
        }
        public class Student2 : Student1
        {
            public new void display()
            {
                Console.WriteLine($"Hi I'm {Name} of Id {Id}");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Student1 s1 = new Student1();
                s1.display();
                Student2 s2 = new Student2
                {
                    Id = 2,
                    Name = "Jane"
                };
                s2.display();
            }
        }
    }

