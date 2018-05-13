using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Module9._2.Task5;
using Module9._2.Task6;
using Module_09_2.Task5;
using RandomNameGenerator;
using Organization = Module9._2.Task5.Organization;

namespace Module9._2
{
    class Program
    {
        private static Random rnd = new Random();
        private static List<Phonebook> phonebooks = new List<Phonebook>();
        private static List<Client> clients = new List<Client>();
        private static void Task5()
        {
            Console.WriteLine("Идет генерация рандомных данных...");

            for (int i = 0; i < rnd.Next(100, 1500); i++)
            {
                switch (rnd.Next(0, 3))
                {
                    case 0:
                        {
                            Person p = new Person(); p.RandomlyGenerateData();
                            phonebooks.Add(p);
                            break;
                        }
                    case 1:
                        {
                            Organization org = new Organization(); org.RandomlyGenerateData();
                            phonebooks.Add(org);
                            break;
                        }
                    case 2:
                        {
                            Friend f = new Friend();
                            f.RandomlyGenerateData();
                            phonebooks.Add(f);
                            break;
                        }
                }
            }

            start:

            int choice = 0;
            Console.WriteLine("1 - Вывести всех\n2 - Поиск по фамилии и типу");
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    {
                        foreach (Phonebook item in phonebooks)
                            item.ShowInfo();
                        Console.WriteLine($"Всего : {phonebooks.Count} контактов");

                        Console.WriteLine("Go to Beginning  - w\nExit - any");
                        if (Console.ReadLine()?.ToLower() == "w")
                        {
                            goto start;
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("1 - Персона\n2 - Огранизация\n3 - Друг");
                        int catСhoice = 0;
                        int.TryParse(Console.ReadLine(), out catСhoice);
                        Console.WriteLine("Введите фамилию : ");

                        string lastName = Console.ReadLine();
                        switch (catСhoice)
                        {
                            case 1:
                                {
                                    int counter = 0;
                                    foreach (Phonebook p in phonebooks)
                                    {
                                        if (p.Find(lastName, (Category)choice))
                                        {
                                            p.ShowInfo();
                                            counter++;
                                        }
                                    }

                                    Console.WriteLine($"Всего : {counter} контактов подходящих по типу и фамилии");
                                    break;
                                }
                            case 2:
                                {
                                    int counter = 0;
                                    foreach (Phonebook p in phonebooks)
                                    {
                                        if (p.Find(lastName, (Category)choice))
                                        {
                                            p.ShowInfo();
                                            counter++;
                                        }
                                    }
                                    Console.WriteLine($"Всего : {counter} контактов подходящих по типу и фамилии");
                                    break;
                                }
                            case 3:
                                {
                                    int counter = 0;
                                    foreach (Phonebook p in phonebooks)
                                    {
                                        if (p.Find(lastName, (Category)choice))
                                        {
                                            p.ShowInfo();
                                            counter++;
                                        }
                                    }
                                    Console.WriteLine($"Всего : {counter} контактов подходящих по типу и фамилии");
                                    break;
                                }
                        }
                        Console.WriteLine("Go to Beginning  - w\nExit - any");
                        if (Console.ReadLine()?.ToLower() == "w")
                        {
                            goto start;
                        }
                        break;
                    }
            }
        }

        private static void Task6()
        {
            Console.WriteLine("Идет генерация рандомных данных...");

            for (int i = 0; i < rnd.Next(100, 1500); i++)
            {
                switch (rnd.Next(0, 3))
                {
                    case 0:
                        {
                            Creditor c = new Creditor(); c.GenerateRandData();
                            clients.Add(c);
                            break;
                        }
                    case 1:
                        {
                            Society org = new Society(); org.GenerateRandData();
                            clients.Add(org);
                            break;
                        }
                    case 2:
                        {
                            Investor investor = new Investor();
                            investor.GenerateRandData();
                            clients.Add(investor);
                            break;
                        }
                }
            }

            start:

            int choice = 0;
            Console.WriteLine("1 - Вывести всех\n2 - Поиск по дате");
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    {
                        foreach (Client item in clients)
                            item.PrintInfo();
                        Console.WriteLine($"Всего : {phonebooks.Count} клиентов");

                        Console.WriteLine("Go to Beginning  - w\nExit - any");
                        if (Console.ReadLine()?.ToLower() == "w")
                        {
                            goto start;
                        }
                        break;
                    }
                case 2:
                    { 
                        Console.WriteLine("Введите дату : ");
                        DateTime date;
                        DateTime.TryParse(Console.ReadLine(), out date);

                                int counter = 0;
                                foreach (Client item in clients)
                                {
                                    if (item.Search(date))
                                    {
                                        item.PrintInfo();
                                        counter++;
                                    }
                                }

                                Console.WriteLine($"Всего : {counter} клиентов, подходящих по дате");

                        Console.WriteLine("Go to Beginning  - w\nExit - any");
                        if (Console.ReadLine()?.ToLower() == "w")
                        {
                            goto start;
                        }
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Какое задание 5 или 6?");
            int choice = 0;
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 5:
                {
                    Task5();
                    break;
                }
                case 6:
                {
                    Task6();
                    break;
                }
            }
            
           
            Console.ReadLine();

        }
    }
}
