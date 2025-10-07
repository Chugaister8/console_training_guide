using System;
using System.Threading;

namespace CSharpLearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C# для початківців";

            bool running = true;
            while (running)
            {
                DisplayMainMenuWithLogo();
                string choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        DisplayTopicsMenu();
                        break;
                    case "2":
                        DisplayTest();
                        break;
                    case "3":
                        DisplayResources();
                        break;
                    case "4":
                        DisplayInfo();
                        break;
                    case "0":
                        running = false;
                        DisplayExitAnimation();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Помилка: Введіть 0-4!");
                        Console.ResetColor();
                        Thread.Sleep(600);
                        break;
                }
            }
        }

        static void DisplayMainMenuWithLogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string logo = @"+----------------------------------------------------------------+
|                                                                |
|                              C#                                |
|                     ОСНОВИ ПРОГРАМУВАННЯ                       |
|                                                                |
+----------------------------------------------------------------+";
            foreach (char c in logo)
            {
                Console.Write(c);
                Thread.Sleep(5);
            }
            Console.ResetColor();

            // Порожній рядок для відступу
            Console.WriteLine("\n");

            // Головне меню
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------=== МЕНЮ ===---------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[1] >> Зміст");
            Console.WriteLine("[2] >> Тестові та практичні завдання");
            Console.WriteLine("[3] >> Довідник");
            Console.WriteLine("[4] >> Про посібник");
            Console.WriteLine("\n[0] <- ВИХІД");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n------------------------------------------------------------------");
            Console.ResetColor();
            Console.Write("\nТвій вибір: ");
        }

        static void DisplayTopicsMenu()
        {
            bool inTopics = true;
            while (inTopics)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow; // Колір для анімації
                for (int i = 0; i <= 100; i += 5) // Крок 5% для плавного відображення 0-100%
                {
                    Console.SetCursorPosition(0, Console.CursorTop); // Повернення курсору на початок рядка
                    Console.Write($"Завантаження: {i}%");
                    Thread.Sleep(50); // Затримка для ефекту анімації
                }
                Console.ForegroundColor = ConsoleColor.Cyan; // Azure
                Console.WriteLine("\n---------------------------=== ЗМІСТ ===---------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[1] >> 1. Історія мов програмування;");
                Console.WriteLine("[2] >> 2. Інфраструктура C#;");
                Console.WriteLine("[3] >> 3. Коментарі;");
                Console.WriteLine("[4] >> 4. Константи та змінні;");
                Console.WriteLine("[5] >> 5. Типи даних;");
                Console.WriteLine("[6] >> 6. Оператори та вирази;");
                Console.WriteLine("[7] >> 7. Умовне керування потоком;");
                Console.WriteLine("\n[0] <- Назад до МЕНЮ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n-------------------------------------------------------------------");
                Console.ResetColor();
                Console.Write("\nТвій вибір: ");

                string choice = Console.ReadLine()?.Trim();
                switch (choice)
                {
                    case "1":
                        //Variables.RunLesson();
                        RunLessonPlaceholder("1. Історія мов програмування");
                        break;
                    case "2":
                        //Conditionals.RunLesson();
                        RunLessonPlaceholder("2. Інфраструктура C#");
                        break;
                    case "3":
                        //Loops.RunLesson();
                        RunLessonPlaceholder("3. Коментарі");
                        break;
                    case "4":
                        RunLessonPlaceholder("4. Константи та змінні");
                        break;
                    case "5":
                        RunLessonPlaceholder("5. Типи даних");
                        break;
                    case "6":
                        RunLessonPlaceholder("6. Оператори та вирази");
                        break;
                    case "7":
                        RunLessonPlaceholder("7. Умовне керування потоком");
                        break;
                    case "0":
                        inTopics = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Помилка: Введіть 0-7!");
                        Console.ResetColor();
                        Thread.Sleep(600);
                        break;
                }
            }
        }

        static void DisplayTest()
        {
            bool inTopics = true;
            while (inTopics)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow; // Колір для анімації
                for (int i = 0; i <= 100; i += 5) // Крок 5% для плавного відображення 0-100%
                {
                    Console.SetCursorPosition(0, Console.CursorTop); // Повернення курсору на початок рядка
                    Console.Write($"Завантаження: {i}%");
                    Thread.Sleep(50); // Затримка для ефекту анімації
                }
                Console.ForegroundColor = ConsoleColor.Cyan; // Azure
                Console.WriteLine("\n--------------------------=== ЗАВДАННЯ ===-------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[1] >> 1. Історія мов програмування;");
                Console.WriteLine("[2] >> 2. Інфраструктура C#;");
                Console.WriteLine("[3] >> 3. Коментарі;");
                Console.WriteLine("[4] >> 4. Константи та змінні;");
                Console.WriteLine("[5] >> 5. Типи даних;");
                Console.WriteLine("[6] >> 6. Оператори та вирази;");
                Console.WriteLine("[7] >> 7. Умовне керування потоком;");
                Console.WriteLine("\n[0] <- Назад до МЕНЮ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n-------------------------------------------------------------------");
                Console.ResetColor();
                Console.Write("\nТвій вибір: ");

                string choice = Console.ReadLine()?.Trim();
                switch (choice)
                {
                    case "1":
                        //Variables.RunLesson();
                        RunTestPlaceholder("1. Історія мов програмування");
                        break;
                    case "2":
                        //Conditionals.RunLesson();
                        RunTestPlaceholder("2. Інфраструктура C#");
                        break;
                    case "3":
                        //Loops.RunLesson();
                        RunTestPlaceholder("3. Коментарі");
                        break;
                    case "4":
                        RunTestPlaceholder("4. Константи та змінні");
                        break;
                    case "5":
                        RunTestPlaceholder("5. Типи даних");
                        break;
                    case "6":
                        RunTestPlaceholder("6. Оператори та вирази");
                        break;
                    case "7":
                        RunTestPlaceholder("7. Умовне керування потоком");
                        break;
                    case "0":
                        inTopics = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Помилка: Введіть 0-7!");
                        Console.ResetColor();
                        Thread.Sleep(600);
                        break;
                }
            }
        }

        static void DisplayResources()
        {
            bool inTopics = true;
            while (inTopics)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow; // Колір для анімації
                for (int i = 0; i <= 100; i += 5) // Крок 5% для плавного відображення 0-100%
                {
                    Console.SetCursorPosition(0, Console.CursorTop); // Повернення курсору на початок рядка
                    Console.Write($"Завантаження: {i}%");
                    Thread.Sleep(50); // Затримка для ефекту анімації
                }
                Console.ForegroundColor = ConsoleColor.Cyan; // Azure
                Console.WriteLine("\n--------------------------=== ДОВІДНИК ===-------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[1] >> Таблиця 1");
                Console.WriteLine("[2] >> Таблиця 2");
                Console.WriteLine("[3] >> Таблиця 3");
                Console.WriteLine("\n[0] <- Назад до МЕНЮ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n-------------------------------------------------------------------");
                Console.ResetColor();
                Console.Write("\nТвій вибір: ");

                string choice = Console.ReadLine()?.Trim();
                switch (choice)
                {
                    case "1":
                        //Variables.RunLesson();
                        RunResourcesPlaceholder("Таблиця 1");
                        break;
                    case "2":
                        //Conditionals.RunLesson();
                        RunResourcesPlaceholder("Таблиця 2");
                        break;
                    case "3":
                        //Loops.RunLesson();
                        RunResourcesPlaceholder("Таблиця 3");
                        break;
                    case "0":
                        inTopics = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Помилка: Введіть 0-3!");
                        Console.ResetColor();
                        Thread.Sleep(600);
                        break;
                }
            }
        }

        static void DisplayInfo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow; // Колір для анімації
            for (int i = 0; i <= 100; i += 5) // Крок 5% для плавного відображення 0-100%
            {
                Console.SetCursorPosition(0, Console.CursorTop); // Повернення курсору на початок рядка
                Console.Write($"Завантаження: {i}%");
                Thread.Sleep(50); // Затримка для ефекту анімації
            }
            Console.ForegroundColor = ConsoleColor.Cyan; // Azure
            Console.WriteLine("\n------------------------=== ПРО ПОСІБНИК ===-----------------------"); // Рамка шириною 18 символів
            Console.ResetColor();
            Console.WriteLine("Додаток: Вивчення C#");
            Console.WriteLine("Версія: 1.0 (2025)");
            Console.WriteLine("Опис: Курс C#.");
            Console.WriteLine("Розробники: C# Team");
            Console.WriteLine("Контакти: csharp@example.com");
            Console.WriteLine("\n[0] <- Назад до МЕНЮ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n-------------------------------------------------------------------");
            Console.ResetColor();
            Console.Write("\nТвій вибір: ");

            while (true)
            {
                string input = Console.ReadLine()?.Trim();
                if (input == "0")
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введіть 0!");
                Console.ResetColor();
                Thread.Sleep(600);
            }
        }

        static void DisplayExitAnimation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan; // Azure
            string goodbye = "Дякую! До зустрічі!";
            foreach (char c in goodbye)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }
            Console.ResetColor();
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nЗавершення...");
                Thread.Sleep(200);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', 12));
                Thread.Sleep(100);
            }
            Console.WriteLine("\nЗавершення...");
            Thread.Sleep(600);
        }

        static void RunLessonPlaceholder(string lessonName)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Тема {lessonName}");
            Console.ResetColor();
            Console.WriteLine("(Тут буде урок)");
            Console.WriteLine("\n[0] <- Назад до ЗМІСТу");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n-----");
            Console.ResetColor();
            Console.Write("\nТвій вибір: ");

            while (true)
            {
                string input = Console.ReadLine()?.Trim();
                if (input == "0")
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введіть 0!");
                Console.ResetColor();
                Thread.Sleep(600);
            }
        }

        static void RunTestPlaceholder(string testName)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Тема {testName}");
            Console.ResetColor();
            Console.WriteLine("(Тут буде тест)");
            Console.WriteLine("\n[0] <- Назад до ЗАВДАНЬ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n-----");
            Console.ResetColor();
            Console.Write("\nТвій вибір: ");

            while (true)
            {
                string input = Console.ReadLine()?.Trim();
                if (input == "0")
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введіть 0!");
                Console.ResetColor();
                Thread.Sleep(600);
            }
        }

        static void RunResourcesPlaceholder(string resourcesName)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Довідка: {resourcesName}");
            Console.ResetColor();
            Console.WriteLine("(Тут буде таблиця)");
            Console.WriteLine("\n[0] <- Назад до ДОВІДНИКА");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n-----");
            Console.ResetColor();
            Console.Write("\nТвій вибір: ");

            while (true)
            {
                string input = Console.ReadLine()?.Trim();
                if (input == "0")
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введіть 0!");
                Console.ResetColor();
                Thread.Sleep(600);
            }
        }
    }
}
