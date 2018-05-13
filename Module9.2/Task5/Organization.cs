using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_09_2.Task5;
using RandomNameGenerator;

namespace Module9._2.Task5
{
    public class Organization : Phonebook
    {
        public Organization() => this.Category = Category.Organization;
        public string Fax { get; set; }
        public string ContactFace { get; set; }

        public override void RandomlyGenerateData()
        {
            base.RandomlyGenerateData();

            this.Fax = $"+7(727)-" +
                          $"{Rnd.Next(100, 1000)}-" +
                          $"{Rnd.Next(10, 100)}-" +
                          $"{Rnd.Next(10, 100)}";
            this.ContactFace = NameGenerator.GenerateFirstName((Gender)Rnd.Next(0, 2)).ToLower();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Факс : {this.Fax}\n" +
                              $"Контактное лицо : {this.ContactFace}\n");
        }
    }
}
