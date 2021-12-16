using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammKogortaM
{
    class Human
    {
        private string Name, Family, ChildrenName1, ChildrenName2;
        private int children;


        public void Print()
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nКол-во детей: {2}\n", this.Name, this.Family, this.children);
            if (this.children == 2)
            {
                Console.WriteLine("Дети:\nИмя: {0}\nФамилия: {1}(a)\n", this.ChildrenName1, this.Family);
                Console.WriteLine("Имя: {0}\nФамилия: {1}(a)\n\n", this.ChildrenName2, this.Family);
            }
            else if(this.children == 1)
            {
                Console.WriteLine("Дети:\nИмя: {0}\nФамилия: {1}(a)\n\n", this.ChildrenName1, this.Family);
            }
        }

        public void Create(string Name, string Family, int children, string ChildrenName1, string ChildrenName2)
        {
            this.Name = Name;
            this.Family = Family;
            this.children = children;
            this.ChildrenName1 = ChildrenName1;
            this.ChildrenName2 = ChildrenName2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human Hum1 = new Human();
            Hum1.Create("Alexandr", "Erohin", 2, "Irina", "Slava");

            Human Hum2 = new Human();
            Hum2.Create("Elena", "Korneeva", 1, "Denis","");

            Hum1.Print();
            Hum2.Print();
            Console.ReadKey();
        }
    }
}
