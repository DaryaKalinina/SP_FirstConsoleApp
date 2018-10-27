using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Домашка:
namespace SP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User {Name="Иван", Age = 31, Sex ="Male" ,Balance = 400 },
                new User {Name="Женя", Age = 24, Sex ="Male" ,Balance = 21000 },
                new User {Name="Даша", Age = 22, Sex ="Female" ,Balance = 570 },
                new User {Name="Леша", Age = 25, Sex ="Male" ,Balance = 14756 },
                new User {Name="Соня", Age = 27, Sex ="Female" ,Balance = 4792 },
                
            };

            //1.Найти самого старшего, богатого, старшего и богатого
            var selectedUsers_task1 = from user in users
                                      where user.Age == users.Max(n => n.Age) || user.Balance == users.Max(n => n.Balance) || (user.Age == users.Max(n => n.Age) && user.Balance == users.Max(n => n.Balance))
                                      //если это конъюнкция, то в базе нет человека который и старший, и самый богатый одновременно
                                      //where user.Age == users.Max(n => n.Age) && user.Balance == users.Max(n => n.Balance)
                                      select user;
            foreach (User user in selectedUsers_task1)
                Console.WriteLine("{0} | {1} | {2}", user.Name, user.Age, user.Balance);

            //2.Определить, сколько людей имеют баланс выше 4000 рублей
          
            var selectedUsers_task2 = from user in users
                                    where user.Balance > 400
                                    select user;
            int total_amount = selectedUsers_task2.Count();
            Console.WriteLine($"{total_amount} пользователя имеют баланс больше 400 рублей.\n");
          
            //3.Отсортировать по возрасту, по полу, по балансу
            Console.WriteLine("Пользователи отсортированы по возрасту, полу и балансу.\n");
            var selectedUsers_task3 = from user in users
                                      orderby user.Age, user.Sex, user.Balance
                                      select user;
            foreach (User user in selectedUsers_task3)
                Console.WriteLine("{0} | {1} | {2} | {3} ", user.Name, user.Age, user.Sex, user.Balance);
            Console.ReadKey();
                }
            }
    }
    
   
