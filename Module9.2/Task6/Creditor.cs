using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9._2.Task6
{
    public class Creditor:Client
    {
        public int CreditPersent { get; set; }
        public int Credit { get; set; }
        public double Ostatok { get; set; }

        public override void GenerateRandData()
        {
            base.GenerateRandData();
            this.CreditPersent = random.Next(5, 70);
            this.Credit = random.Next(1000, 100000);
            this.Ostatok = random.Next(0, Credit);
        }

        public Creditor()
        {
            Category = Type.Creditor;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Размер кредита : {this.Credit}\n" +
                              $"Процент по кредиту : {this.CreditPersent}\n" +
                              $"Остаток долга : {this.Ostatok}\n");
        }
    }
}
