enum BankAccountType
{
    Current,
    Savings
}

struct BankAccount
{
    public string Number;
    public BankAccountType Type;
    public double Balance;
}

enum VUZ
{
    KGU,
    KAI,
    KHTI
}

struct Rabotnik
{
    public string Name;
    public VUZ University;
}

enum WagonType
{
    Platzkart,
    Kupe,
    SV,
    Lux
}

struct Ticket
{
    public string FIO;
    public int TrainNumber;
    public string Date;
    public string Time;
    public WagonType Wagon;
    public double Price;
}

enum CarClass
{
    Economy,
    Comfort,
    Business,
    Premium
}

struct Rent
{
    public string ClientName;
    public string CarBrand;
    public CarClass Class;
    public string StartDate;
    public string EndDate;
    public double PricePerDay;
}

enum Faculty
{
    IT,
    Economy,
    Law,
    Design
}

struct StudentCard
{
    public string FIO;
    public string RecordBookNumber;
    public Faculty Fac;
    public int Course;
    public double AverageMark;
    public string EnrollmentDate;
}

class Program
{
    static void Main()
    {
        // Упражнение 3.1
        System.Console.WriteLine("Упражнение 3.1");
        BankAccountType account = BankAccountType.Savings;
        System.Console.WriteLine(account);
        System.Console.WriteLine();

        // Упражнение 3.2
        System.Console.WriteLine("Упражнение 3.2");
        BankAccount bank;
        bank.Number = "12345";
        bank.Type = BankAccountType.Current;
        bank.Balance = 1000;
        System.Console.WriteLine(bank.Number);
        System.Console.WriteLine(bank.Type);
        System.Console.WriteLine(bank.Balance);
        System.Console.WriteLine();

        // Домашнее задание 3.1
        System.Console.WriteLine("ДЗ 3.1");
        Rabotnik worker;
        worker.Name
 = "Иванов";
        worker.University
 = VUZ.KAI;
        System.Console.WriteLine(worker.Name
);
        System.Console.WriteLine(worker.University
);
        System.Console.WriteLine();

        // Проект 1, Задание 0
        System.Console.WriteLine("Проект 1, Задание 0");
        byte oxygenLevel = 250;
        byte extraOxygen = 10;
        byte resultByte = (byte)(oxygenLevel + extraOxygen);
        System.Console.WriteLine("oxygenLevel: " + oxygenLevel);
        System.Console.WriteLine("extraOxygen: " + extraOxygen);
        System.Console.WriteLine("result (byte): " + resultByte);
        System.Console.WriteLine("Сумма без приведения (int): " + (oxygenLevel + extraOxygen));
        System.Console.WriteLine();

        // Проект 1, Задание 1
        System.Console.WriteLine("Проект 1, Задание 1. Анкета космонавта");
        System.Console.Write("Введите имя: ");
        string astroName = System.Console.ReadLine();
        System.Console.Write("Введите возраст: ");
        int astroAge = int.Parse(System.Console.ReadLine());
        System.Console.Write("Введите рост: ");
        double astroHeight = double.Parse(System.Console.ReadLine());
        System.Console.Write("Введите вес: ");
        double astroWeight = double.Parse(System.Console.ReadLine());
        System.Console.Write("Введите любимый фильм: ");
        string astroFilm = System.Console.ReadLine();
        System.Console.WriteLine("Имя: " + astroName + ", Возраст: " + astroAge + ", Рост: " + astroHeight + ", Вес: " + astroWeight + ", Фильм: " + astroFilm);
        System.Console.WriteLine();

        // Проект 1, Задание 2
        System.Console.WriteLine("Проект 1, Задание 2. Билет на поезд");
        Ticket ticket;
        System.Console.Write("ФИО: ");
        ticket.FIO = System.Console.ReadLine();
        System.Console.Write("Номер поезда: ");
        ticket.TrainNumber = int.Parse(System.Console.ReadLine());
        System.Console.Write("Дата: ");
        ticket.Date
 = System.Console.ReadLine();
        System.Console.Write("Время: ");
        ticket.Time = System.Console.ReadLine();
        System.Console.Write("Тип вагона (0-Плацкарт, 1-Купе, 2-СВ, 3-Люкс): ");
        ticket.Wagon = (WagonType)int.Parse(System.Console.ReadLine());
        System.Console.Write("Цена: ");
        ticket.Price = double.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Билет: " + ticket.FIO + ", Поезд: " + ticket.TrainNumber + ", Дата: " + ticket.Date
 + ", Время: " + ticket.Time + ", Вагон: " + ticket.Wagon + ", Цена: " + ticket.Price);
        System.Console.WriteLine();

        // Проект 1, Задание 3
        System.Console.WriteLine("Проект 1, Задание 3. Аренда автомобиля");
        Rent rent;
        System.Console.Write("Имя клиента: ");
        rent.ClientName = System.Console.ReadLine();
        System.Console.Write("Марка авто: ");
        rent.CarBrand = System.Console.ReadLine();
        System.Console.Write("Класс (0-Эконом, 1-Комфорт, 2-Бизнес, 3-Премиум): ");
        rent.Class = (CarClass)int.Parse(System.Console.ReadLine());
        System.Console.Write("Дата начала: ");
        rent.StartDate = System.Console.ReadLine();
        System.Console.Write("Дата окончания: ");
        rent.EndDate = System.Console.ReadLine();
        System.Console.Write("Стоимость за сутки: ");
        rent.PricePerDay = double.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Аренда: " + rent.ClientName + ", Авто: " + rent.CarBrand + ", Класс: " + rent.Class + ", С " + rent.StartDate + " по " + rent.EndDate + ", Цена/сутки: " + rent.PricePerDay);
        System.Console.WriteLine();

        // Проект 1, Задание 4
        System.Console.WriteLine("Проект 1, Задание 4. Данные студента");
        StudentCard student;
        System.Console.Write("ФИО: ");
        student.FIO = System.Console.ReadLine();
        System.Console.Write("Номер зачетки: ");
        student.RecordBookNumber = System.Console.ReadLine();
        System.Console.Write("Факультет (0-ИТ, 1-Экономика, 2-Юриспруденция, 3-Дизайн): ");
        student.Fac = (Faculty)int.Parse(System.Console.ReadLine());
        System.Console.Write("Курс: ");
        student.Course = int.Parse(System.Console.ReadLine());
        System.Console.Write("Средний балл: ");
        student.AverageMark = double.Parse(System.Console.ReadLine());
        System.Console.Write("Дата зачисления: ");
        student.EnrollmentDate = System.Console.ReadLine();
        System.Console.WriteLine("Студент: " + student.FIO + ", Зачетка: " + student.RecordBookNumber + ", Факультет: " + student.Fac + ", Курс: " + student.Course + ", Средний балл: " + student.AverageMark + ", Дата зачисления: " + student.EnrollmentDate);
        System.Console.WriteLine();

        // Проект 3, Задача 1
        System.Console.WriteLine("Проект 3, Задача 1");
        System.Console.WriteLine("byte: " + byte.MinValue + " " + byte.MaxValue);
        System.Console.WriteLine("int: " + int.MinValue + " " + int.MaxValue);
        System.Console.WriteLine("long: " + long.MinValue + " " + long.MaxValue);
        System.Console.WriteLine("float: " + float.MinValue + " " + float.MaxValue);
        System.Console.WriteLine("double: " + double.MinValue + " " + double.MaxValue);
        System.Console.WriteLine();

        // Проект 3, Задача 2
        System.Console.WriteLine("Проект 3, Задача 2");
        System.Console.Write("Введите имя: ");
        string name = System.Console.ReadLine();
        System.Console.Write("Введите город: ");
        string city = System.Console.ReadLine();
        System.Console.Write("Введите возраст: ");
        int age = int.Parse(System.Console.ReadLine());
        System.Console.Write("Введите PIN: ");
        string pin = System.Console.ReadLine();
        System.Console.WriteLine("Имя: " + name + " Город: " + city + " Возраст: " + age + " PIN: " + pin);
        System.Console.WriteLine();

        // Проект 3, Задача 3
        System.Console.WriteLine("Проект 3, Задача 3");
        System.Console.Write("Введите строку: ");
        string text = System.Console.ReadLine();
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
                result = result + char.ToLower(text[i]);
            else
                result = result + char.ToUpper(text[i]);
        }
        System.Console.WriteLine(result);
        System.Console.WriteLine();

        // Проект 3, Задача 4
        System.Console.WriteLine("Проект 3, Задача 4");
        System.Console.Write("Строка: ");
        string str = System.Console.ReadLine();
        System.Console.Write("Подстрока: ");
        string sub = System.Console.ReadLine();
        int count = 0;
        for (int i = 0; i <= str.Length - sub.Length; i++)
        {
            if (str.Substring(i, sub.Length) == sub)
                count++;
        }
        System.Console.WriteLine("Вхождений: " + count);
        System.Console.WriteLine();

        // Проект 3, Задача 5
        System.Console.WriteLine("Проект 3, Задача 5");
        System.Console.Write("Обычная цена: ");
        int normPrice = int.Parse(System.Console.ReadLine());
        System.Console.Write("Цена со скидкой: ");
        int salePrice = int.Parse(System.Console.ReadLine());
        System.Console.Write("Стоимость отпуска: ");
        int holidayPrice = int.Parse(System.Console.ReadLine());
        int save = normPrice - salePrice;
        int bottles = holidayPrice / save;
        System.Console.WriteLine("Бутылок: " + bottles);
        System.Console.WriteLine();

        // Проект 3, Задача 6
        System.Console.WriteLine("Проект 3, Задача 6");

        string name1 = "Иванов"; string drink1 = "Водка"; double vol1 = 1.5; double percent1 = 40;
        string name2 = "Петров"; string drink2 = "Пиво"; double vol2 = 2.0; double percent2 = 5;
        string name3 = "Сидоров"; string drink3 = "Вино"; double vol3 = 0.7; double percent3 = 12;
        string name4 = "Кузнецов"; string drink4 = "Пиво"; double vol4 = 0.0; double percent4 = 5;
        string name5 = "Смирнов"; string drink5 = "Водка"; double vol5 = 0.5; double percent5 = 40;

        double totalVol = vol1 + vol2 + vol3 + vol4 + vol5;
        double totalAlc = (vol1 * percent1 / 100) + (vol2 * percent2 / 100) + (vol3 * percent3 / 100) + (vol4 * percent4 / 100) + (vol5 * percent5 / 100);

        System.Console.WriteLine("Всего выпито: " + totalVol);
        System.Console.WriteLine("Всего алкоголя: " + totalAlc);

        System.Console.WriteLine(name1 + " выпил " + vol1 + " (" + (vol1 * 100 / totalVol) + "% жидкости)");
        System.Console.WriteLine(name2 + " выпил " + vol2 + " (" + (vol2 * 100 / totalVol) + "% жидкости)");
        System.Console.WriteLine(name3 + " выпил " + vol3 + " (" + (vol3 * 100 / totalVol) + "% жидкости)");
        System.Console.WriteLine(name4 + " выпил " + vol4 + " (" + (vol4 * 100 / totalVol) + "% жидкости)");
        System.Console.WriteLine(name5 + " выпил " + vol5 + " (" + (vol5 * 100 / totalVol) + "% жидкости)");

        System.Console.ReadKey();
    }
}