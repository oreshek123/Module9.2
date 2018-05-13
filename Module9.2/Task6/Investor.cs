using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module9._2.Task6
{
    public class Investor : Client
    {
        public double InvestAmount { get; set; }
        public int InvestPersent { get; set; }

        public Investor()
        {
            Category = Type.Investor;
        }
        public override void GenerateRandData()
        {
            base.GenerateRandData();
            this.InvestAmount = Math.Round(random.NextDouble() * random.Next(1000, 100000),2);
            this.InvestPersent = random.Next(1, 100);
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
           
            Console.WriteLine($"Размер вклада : {this.InvestAmount}\n" +
                              $"Процент по вкладу : {this.InvestPersent}\n");
        }
    }
}
