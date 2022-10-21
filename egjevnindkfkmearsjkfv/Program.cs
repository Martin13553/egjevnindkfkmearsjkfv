

namespace Segjevnindkfkmearsjkfv
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 1;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                Console.Clear();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
            }

            string file_name = "Zametka.txt";
            string state = null;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("Запуск.......");
            DateTime now = DateTime.Now;

            Console.WriteLine($"Время: {now.ToString("f")}");
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (System.IO.File.Exists(Convert.ToString(Path.GetFullPath(file_name))) == false)
                Console.WriteLine("Не найден файл zametka.txt. . он будет создан автоматически . .");
            Console.WriteLine("Готово . .");
            while (state != "3")



            {
                try
                {
                    Console.WriteLine(" 1 - добавить ученика в базу  2 - найти ученика в базе  3 - выход");
                    state = Console.ReadLine();
                    switch (state)

                    {
                        case "1":

                            Employee temp = new Employee();
                            Console.WriteLine("Введите имя: ");
                            temp.Name = Console.ReadLine();
                            Console.WriteLine("Введите пол: ");
                            temp.Gender = Console.ReadLine();
                            Console.WriteLine("Введите номер телефона: ");
                            temp.Phone = Console.ReadLine();
                            Console.WriteLine("Введите курс: ");
                            temp.Adress = Console.ReadLine();
                            Console.WriteLine("Введите номер группы: ");
                            temp.BirthDate = Console.ReadLine();
                            temp.WriteEmployee();
                            break;
                        case "2":
                            string n = null;
                            Console.WriteLine("Введите имя ученика,которого ищем: ");
                            n = Console.ReadLine();
                            Employee.DisplayEmployee(n);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Работа завершена . . Нажмите клавишу для выхода . .");
            Console.ReadLine();
        }


    }

    public class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string BirthDate { get; set; }
        public Employee() { }
        public void WriteEmployee()
        {
            using (StreamWriter sw = File.AppendText("Zametka.txt"))
            {
                sw.WriteLine(this.Name);
                sw.WriteLine(this.Gender);
                sw.WriteLine(this.Phone);
                sw.WriteLine(this.Adress);
                sw.WriteLine(this.BirthDate);
            }
        }
        public static void DisplayEmployee(string name)
        {
            using (StreamReader sr = File.OpenText("Zametka.txt"))
            {
                string temp = null;
                while ((temp = sr.ReadLine()) != name && temp != null) ;
                if (temp == name)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Полное имя: " + temp);
                    Console.WriteLine(String.Format("Пол: " + sr.ReadLine()));
                    Console.WriteLine(String.Format("Телефон: " + sr.ReadLine()));
                    Console.WriteLine(String.Format("Курс: " + sr.ReadLine()));
                    Console.WriteLine(String.Format("Группа: " + sr.ReadLine()));
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                    Console.WriteLine("Такой ученик не найден . .");
            }
        }

    }
}



/* int position = 1;
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.key == ConsoleKey.UpArrow)
    {
        position--;
    }
    else if (key.key == ConsoleKey.DownArrow)
    {
        position++;
    }
    Console.Clear();
    Console.SetCursorPosition(0, position);
    Console.WriteLine("-->");
}

static void Menu()
{
    Console.WriteLine("1 - добавить ученика в базу ");
    Console.WriteLine("2 - найти ученика в базе ");
    Console.WriteLine("3 - выход ");
}
