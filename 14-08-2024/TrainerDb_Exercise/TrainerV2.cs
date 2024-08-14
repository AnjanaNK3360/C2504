using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDotNetPractice
{
    internal class TrainerV2
    {
        private int id;
        private string name;
        private string skill;
        private string place;
        private float salary;

        public TrainerV2(int id, string name, string skill, string place, float salary)
        {
            this.id = id;
            this.name = name;
            this.skill = skill;
            this.place = place;
            this.salary = salary;
        }

        public TrainerV2()
        {
            this.id = 0;
            this.name = "";
            this.skill = "";
            this.place = "";
            this.salary = 0;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Skill { get => skill; set => skill = value; }
        public string Place { get => place; set => place = value; }
        public float Salary { get => salary; set => salary = value; }
    }
}
