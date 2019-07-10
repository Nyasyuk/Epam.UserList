using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.UserList.Entities;
using Epam.UserList.Logic;
using Epam.UserList.LogicContracts;

namespace Epam.UserList.ConsoleUI
{
    class Program
    {

        private static IUserLogic userLogic;
        private static IAwardLogic awardLogic;

        static Program()
        {
            userLogic = new UserLogic();
            awardLogic = new AwardLogic();
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1) Просмотреть перечень пользователей");
                Console.WriteLine("2) Создать пользователя");
                Console.WriteLine("3) Удалить пользователя");
                Console.WriteLine("4) Просмотреть награды");
                Console.WriteLine("5) Создать награду");
                Console.WriteLine("6) Выдать награду пользователю");
                Console.WriteLine("7) Выйти");

                ConsoleKeyInfo input = Console.ReadKey(intercept: true);
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        ShowList();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        AddUser();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        ShowList();
                        DelUser();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        ShowListAwards();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        AddAward();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D6:
                        GiveAwards();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D7:
                        return;
                }
            }
        }

        private static void GiveAwards()
        {
            ShowList();
            Console.WriteLine("Введите id пользователя:");
            string idUser = Console.ReadLine();
            ShowListAwards();
            Console.WriteLine("Введите id награды:");
            string idAward = Console.ReadLine();

            userLogic.GivAward(Convert.ToInt32(idUser), Convert.ToInt32(idAward));
        }

        private static void AddAward()
        {
            Console.WriteLine("Введите Название награды:");
            string title = Console.ReadLine();

            Award newAward = awardLogic.Save(title);
        }

        private static void ShowListAwards()
        {
            Award[] awards = awardLogic.GetAll();
            foreach (var award in awards)
            {
                Console.WriteLine($"id: {award.Id} Название: {award.Title}");
            }
            if (awards.Length == 0) Console.WriteLine("Спсок пуст");
        }

        private static void DelUser()
        {
            Console.WriteLine("Введите id пользователя:");
            string idUser = Console.ReadLine();

            User newUser = userLogic.Del(idUser);
        }

        private static void ShowList()
        {
            User[] users = userLogic.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine($"id: {user.Id} Имя: {user.Name} Дата рождения: {user.DateOfBirth} Возраст: {user.Age} лет");
                List<Award> awards = user.Awards;
                if (awards.Count>0)
                {
                    foreach (var award in user.Awards)
                    {
                        Console.WriteLine($"   {award.Title}\n");
                    }
                }
            }
            if (users.Length == 0) Console.WriteLine("Спсок пуст");
        }

        private static void AddUser()
        {
            Console.WriteLine("Введите Имя:");
            string userName = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            string dateOfBirth = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            string age = Console.ReadLine();


            User newUser = userLogic.Save(userName, Convert.ToDateTime(dateOfBirth), Convert.ToInt32(age));
        }
    }
}
