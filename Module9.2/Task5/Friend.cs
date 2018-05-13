using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Module_09_2.Task5;

namespace Module9._2.Task5
{
    public class Friend:Phonebook
    {
        public Friend() => this.Category = Category.Friend;
        public DateTime Birthday { get; set; }
        public override void RandomlyGenerateData()
        {
            base.RandomlyGenerateData();
            int randYear = Rnd.Next(DateTime.Now.Year - 100, DateTime.Now.Year);
            int randMonth = Rnd.Next(1, 12);
            int randDay = Rnd.Next(1, DateTime.DaysInMonth(randYear, randMonth));
            this.Birthday = DateTime.Parse($"{randYear}-{randMonth}-{randDay}");
            
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"День рождения : {this.Birthday}\n");
        }
    }
}