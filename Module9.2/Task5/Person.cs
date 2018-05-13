using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_09_2.Task5;

namespace Module9._2.Task5
{
    public class Person : Phonebook
    {
        public Person() => this.Category = Category.Person;
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine();
        }
    }
}
