using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module9._2.Task6
{
    public class Society:Client
    {
        public string BankAccount { get; set; }
        public double Balance { get; set; }

        public Society()
        {
            Category = Type.Society;
        }
        public override void GenerateRandData()
        {
            base.GenerateRandData();
            this.BankAccount = "KZ" + random.Next(1000000, 99999999);
            this.Balance = Math.Round(random.NextDouble() * random.Next(1000, 100000),2);
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Номер счета : {this.BankAccount}\n" +
                              $"Сумма на счету : {Balance}\n");
        }

    }
}
