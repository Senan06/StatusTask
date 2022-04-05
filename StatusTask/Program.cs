using StatusTask.Models;
using System;
using System.Collections.Generic;

namespace StatusTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int button;
            Console.Write("UserName?:");
            User user = new User(Console.ReadLine());
            do
            {
                Console.WriteLine("1. Share status");
                Console.WriteLine("2. Get all statuses");
                Console.WriteLine("3. Get status by id");
                Console.WriteLine("4. Filter status by date");
                Console.WriteLine("0. Quit");
                button = Convert.ToInt32(Console.ReadLine());
                switch (button)
                {
                    case 1:
                        Console.Write("Title?");
                        string title = Console.ReadLine();
                        Console.Write("Cotent?");
                        string content = Console.ReadLine();
                        Status stat = new Status(title, content);
                        user.ShareStatus(stat);
                        break;
                    case 2:
                        List<Status> list = user.GetAllStatuses();
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        Console.WriteLine("id?:");
                        int id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(user.GetStatusById(id));
                        break;
                    case 4:
                        DateTime time = Convert.ToDateTime(Console.ReadLine());
                        List<Status> status = user.FilteredStatusByDate(time);
                        foreach (var item in status)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        break;
                }
            } while (button != 0);
        }
    }
}
