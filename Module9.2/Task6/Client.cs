using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RandomNameGenerator;

public enum Type
{
    Investor=1, Creditor=2, Society=3
}

namespace Module9._2.Task6
{
    public abstract class Client
    {
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public Type Category { get; set; }
        protected Random random = new Random();
        public virtual void GenerateRandData()
        {
            LastName = NameGenerator.GenerateLastName();
            int randYear = random.Next(DateTime.Now.Year - 100, DateTime.Now.Year);
            int randMonth = random.Next(1, 12);
            int randDay = random.Next(1, DateTime.DaysInMonth(randYear, randMonth));
            this.StartDate = DateTime.Parse($"{randYear}-{randMonth}-{randDay}");
            Thread.Sleep(30);
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Фамилия : {this.LastName}\n" +
                              $"Дата открытия вклада : {this.StartDate}\n" +
                              $"Клиент : {this.Category}");
        }

        public bool Search(DateTime date) => this.StartDate == date;
    }
}
