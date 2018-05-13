using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using RandomNameGenerator;

namespace Module_09_2.Task5
{
    public enum Category
    {
        Person =1, Organization=2, Friend=3
    }
    public abstract class Phonebook
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        protected Random Rnd = new Random();
        public Category Category { get; set; }
        public virtual void RandomlyGenerateData()
        {
            this.Name = NameGenerator.GenerateLastName().ToLower();

            this.PhoneNumber = $"+7({Rnd.Next(100, 1000)})-" +
                          $"{Rnd.Next(100, 1000)}-" +
                          $"{Rnd.Next(10, 100)}-" +
                          $"{Rnd.Next(10, 100)}";

            //Получение адреса рандомно
            DirectoryInfo directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent?.Parent;
            XDocument xdoc = XDocument.Load(directory?.FullName + "/Task5/Addresses.xml");
            List<string> elem = xdoc.Root?.Elements().Elements().Select(s => s.Value).ToList();
            this.Address = elem?[Rnd.Next(elem.Count)];
            Thread.Sleep(30);
        }

        public virtual bool Find(string lastName, Category category)
            => this.Name == lastName && this.Category == category;
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Имя : {this.Name}\n" +
                              $"Телефонный номер : {this.PhoneNumber}\n" +
                              $"Адрес : {this.Address}\n" +
                              $"Тип контакта : {Category}");
        }
    }
}
