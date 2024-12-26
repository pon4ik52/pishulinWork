
namespace Tauzhanov_Evdokimova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        int криштьяноу = 5;
                        int роналду = 2;
                        int tablescount = 5;
                        string horseSet = "Роналду, Гау, Астольфо, Гарик, РОждественски";

                        if (криштьяноу > роналду)
                        {
                            Console.WriteLine("SIUUUUUUUUUUUUUU");
                        }
                        else if (криштьяноу == 5)
                        {
                            Console.WriteLine("CRISTIANOOOOOOOOOO");
                        }
                        else
                        {
                            Console.WriteLine("FUUUUU");
                        }

                        switch (криштьяноу)
                        {
                            case 1:
                                Console.WriteLine("GAY");
                                break;
                            case 2:
                                Console.WriteLine("Pak-Puk");
                                break;
                            case 3:
                                Console.WriteLine("e4kere");
                                break;
                            case 0:
                                Console.WriteLine("shlepa");
                                break;
                            default:
                                Console.WriteLine("52 да здравствует Санк Питербург этот город наш");
                                break;

                        }
                        int count1 = 25;
                        while (count1 > криштьяноу)
                        {
                            Console.WriteLine($"осталось {count1} раз сказать ечкере");
                            count1--;
                        }
                        do
                        {
                            Console.WriteLine($"Я хочу сказать 52 {++count1} раз");
                        }
                        while (count1 < 60);

                        for (int i = 0; i < count1; i++)
                        {
                            Console.WriteLine(i);
                        }
                        int[] number =
                        {
                                        1, 5, 86, 228, 7
                                    };
                        int[] number2 = new int[10];

                        number2[0] = 10;
                        string[,] strings =
                        {
                                        { "привет","ты", "мне","нртавишься" },
                                        { "привет","ты", "мне","нртавишся" },
                                        { "привет","ты", "мне","нртавишья" },
                                        { "привет","ты", "мне","нртавишьс" }
                                    };
                        string[,] strings2 = new string[5, 8];
                        string[][] adresses =
                        {
                                        ["артем", "бартем", "рартем","тем", "гау"],
                                        ["артем", "бартем",],
                                        ["артем", "бартем", "рартем","тем"],
                                        ["артем", "рартем","тем"],
                                    };
                        Console.WriteLine(adresses[0][4]);


                        Console.WriteLine("Сумма столов и стульев: 1 000 000 000.00 руб.");



                        double S, R;
                        Console.WriteLine("Чтобы найти площадь круга");
                        Console.WriteLine("Напишите чему равен радиус: ");
                        R = Convert.ToInt32(Console.ReadLine());

                        S = Math.Round(Math.PI * R * R, 2);
                        Console.Write("Площадь круга равна ");
                        Console.WriteLine(S);

                        string a;
                        Console.Write("Напишите любую букву русского алфавита: ");
                        a = Console.ReadLine();
                        if ("бвгджзклймнпрстфхцчшщьъ".Contains(a.ToLower()))
                        {
                            Console.WriteLine("Буква является согласной");
                        }
                        else if ("аеёиоуэыюя".Contains(a.ToLower()))
                        {
                            Console.WriteLine("Буквы является гласной");
                        }
                        else
                        {
                            Console.WriteLine("Чо сами умни?");
                        }



                        decimal g, c, f, C, F;
                        Console.WriteLine("Выберите что вы хотите преобразовать");
                        Console.WriteLine("1) Градусы из Фаренгейта в Цельсия");
                        Console.WriteLine("2) Градусы из Цельсия в Фаренгейта");
                        g = Convert.ToInt32(Console.ReadLine());
                        if (g == 1)
                        {
                            Console.WriteLine("Введите количество градусов по Фаренгейту");
                            f = Convert.ToDecimal(Console.ReadLine());
                            c = Math.Round((f - 32) * 5 / 9, 2);
                            Console.WriteLine("Полученое число градусов по цельсию");
                            Console.WriteLine(c);
                        }
                        else if (g == 2)
                        {
                            Console.WriteLine("Введите количество градусов по Цельсию");
                            C = Convert.ToDecimal(Console.ReadLine());
                            F = Math.Round(C * 9 / 5 + 32, 2);
                            Console.WriteLine("Полученое число градусов по Фаренгейту");
                            Console.WriteLine(F);
                        }

                        string p2;
                        Console.WriteLine("Напишите свое предложение которое вы хотите перевернуть");
                        p2 = Console.ReadLine();
                        p2 = new string(p2.Reverse().ToArray());
                        Console.WriteLine(p2);


                        string b;
                        int t1 = 0, t2 = 0, t3 = 0;
                        Console.WriteLine("Напишите свое предложение");
                        b = Console.ReadLine();
                        foreach (char u in b.ToLower())
                            if ("бвгджзклмйнпрстфхцчшщьъ".Contains(u))
                            {
                                t1++;
                            }
                            else if ("аеёиоуэыюя".Contains(u))
                            {
                                t2++;

                            }
                            else 
                            {
                                t3++;
                            }
                        Console.WriteLine("Количество согласных = " + t1);
                        Console.WriteLine("Количество глассных = " + t2);
                        Console.WriteLine("Количество символов = " + t3);


                        string s1, s2;
                        Console.WriteLine("Введите две строки для сравнения");
                        Console.WriteLine("Первая строка");
                        s1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Вторая строка");
                        s2 = Convert.ToString(Console.ReadLine());
                        if (s1.CompareTo(s2) == 0)
                        {
                            Console.WriteLine("Строки равны");
                        }
                        else
                        {
                            Console.WriteLine("Строки не равны");
                        }



                        string email, email1, login, login1, password1, password;
                        Console.WriteLine("Для авторизации введите адрес электронной почты");
                        email = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Теперь придумайте логин");
                        login = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Введите пароль");
                        password = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Для входа введите свою почту");
                        email1 = Convert.ToString(Console.ReadLine());

                        if (email1 != email)
                        {
                            Console.WriteLine("ошибка");
                        }
                        else
                        {
                            Console.WriteLine("Для входа введите свой логин");
                            login1 = Convert.ToString(Console.ReadLine());
                            if (login1 != login)
                            {
                                Console.WriteLine("ошибка");
                            }
                            else 
                            {
                                Console.WriteLine("Для входа введите свой пароль");
                                password1 = Convert.ToString(Console.ReadLine());
                                if(password1 != password)
                                {
                                    Console.WriteLine("Ошибка");
                                }
                            }
                        }


                        int s;
                        Console.WriteLine("Напишите число от 1 - 7 для определения дня недели");
                        s = Convert.ToInt32(Console.ReadLine());
                        switch (s)
                        {
                            case 1:
                                Console.WriteLine("Понедельник");
                                break;
                            case 2:
                                Console.WriteLine("Вторник");
                                break;
                            case 3:
                                Console.WriteLine("Среда");
                                break;
                            case 4:
                                Console.WriteLine("Четверг");
                                break;
                            case 5:
                                Console.WriteLine("Пятница");
                                break;
                            case 6:
                                Console.WriteLine("Суббота");
                                break;
                            case 7:
                                Console.WriteLine("Воскресенье");
                                break;
                            default:
                                Console.WriteLine("День недели неопределен");
                                break;

                        }

                        int ball;
                        Console.WriteLine("Напишите свой балл за тест");
                        ball = Convert.ToInt32(Console.ReadLine());
                        if (ball <= 60)
                        {
                            Console.WriteLine("Ваша оценка 2");
                        }
                        else if (ball <= 75)
                        {
                            Console.WriteLine("Ваша оценка 3");
                        }
                        else if (ball <= 90)
                        {
                            Console.WriteLine("Ваша оценка 4");
                        }
                        else if (ball <= 100)
                        {
                            Console.WriteLine("Ваша оценка 5");
                        }
                        else
                        {
                            Console.WriteLine("Ты даун");
                        }
            Kira c1 = new Kira();
            c1.Print();
            
            string skip;
            int v, n, v3;
            Console.WriteLine("Привет, ты находишься в мини игре по JoJo 4 части, тебе предстоит отыскать злодея Кира Йошикаге");
            Console.WriteLine("Напишите свое имя");
            Console.WriteLine("Выберите к кому вы хотите обратится за помощью");
            Console.WriteLine("1. Школьник с высокой прической");
            Console.WriteLine("2. Короткоткостриженный тип");
            v = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                Console.WriteLine("Вы: Привет, ты что то знаешь про местного убийцу?");
                Joske_1scene c1 = new Joske_1scene();
                c1.Print();
            }
            else if (v == 2)
            {
                Console.WriteLine("Вы: Привет, ты что то знаешь про местного убийцу?");
                Okuyasu_1scene c1 = new Okuyasu_1scene();
                c1.Print();
                Console.WriteLine("Затем вы втроем идете вместе с Джоске к Джотаро сану");
            }
            else
            {
                Console.WriteLine("Тебя отпинали другие школьники за то что наступил на черепаху");
            }
            Console.WriteLine("Нажмите Q чтобы продолжить");
            skip = Convert.ToString(Console.ReadLine());
            if (skip == "Q")
            {
                Console.WriteLine("Вы дошли до джотаро сана");
                Jotaro_2scene c2 = new Jotaro_2scene();
                c2.Print();
                Console.WriteLine("Выберите что сказать");
                Console.WriteLine("1. Здравствуйте, я друг Шигечи он в опасности, написал что за ним гонится убийца, сказал обратится к вам");
                Console.WriteLine("2. Здравствуйте, я видел что за моим однаклассником кто то гонится и звал вас судорожно на помощь, он лысый с колючками на голове");
                v3 = Convert.ToInt32(Console.ReadLine());
                Joske_3scene c3 = new Joske_3scene();
                c3.Print();
                skip = Convert.ToString(Console.ReadLine());
                if (skip == "Q")
                {
                    Console.WriteLine("Вы направляетесь в школу для помощи Шигечи");
                    Console.WriteLine("По пути вы видете картину что Шигечи лежит полу-мертвый");
                    Kira c4 = new Kira();
                    c4.Print();
                    skip = Convert.ToString(Console.ReadLine());
                    if (skip == "Q")
                    {
                        Console.WriteLine("Шигечи убили");
                        Console.WriteLine("Убийца скрылся");
                        Console.WriteLine("Теперь вы знаете что убийцу зовут Кира Йошикаге и у него желтые волосы");
                        Joske_5scene c5 = new Joske_5scene();
                        c5.Print();
                        skip = Convert.ToString(Console.ReadLine());
                        if (skip == "Q")
                        {
                            Console.WriteLine("Вы направляетесь по следам убийцы");
                            Jotaro_6scene c6 = new Jotaro_6scene();
                            c6.Print(); skip = Convert.ToString(Console.ReadLine());
                            if (skip == "Q")
                            {
                                Console.WriteLine("Вы видете на пути");
                                Console.WriteLine("1. Желтоволосого мужчину");
                                Console.WriteLine("2. Парихмахерская + салон красоты");
                                Console.WriteLine("Выберите к кому вы хотите подойти");
                                v = Convert.ToInt32(Console.ReadLine());
                                if (v == 1)
                                {
                                    Console.WriteLine("Вы подходите к мужчине и спрашиваете зовут ли его Кира Йошикаге");
                                    skip = Convert.ToString(Console.ReadLine());
                                    if (skip == "Q")
                                    {
                                        Console.WriteLine("Мужчина кидает монетку джотаро и говорит ДАААА");
                                        Console.WriteLine("Начинается потасовка Джотаро получает колосальный урон от взрыва монетки которая превратилась в бомбу от касания Killer Queen стенда Киры");
                                        skip = Convert.ToString(Console.ReadLine());
                                        if (skip == "Q")
                                        {
                                            Console.WriteLine("Джотаро лежит весь в крови");
                                            skip = Convert.ToString(Console.ReadLine());
                                            if (skip == "Q")
                                            {
                                                Console.WriteLine("Кира начинает издеваться над джотаро");
                                                Kira_11scene c11 = new Kira_11scene();
                                                c11.Print();
                                                Console.WriteLine("Кира продолжая смеяться разворачивается и уходит");
                                                skip = Convert.ToString(Console.ReadLine());
                                                if (skip == "Q")
                                                {
                                                    Console.WriteLine("");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            \n4. Издательства"\
            if (vibo == 4)
                                {
                                    Console.WriteLine();
                                }
           @"C:\Users\studkab8\Desktop\файлики\authors.txt"
            string authorsFilePath = "authors.txt";
            @"C:\Users\Dream PC\Desktop\файлики (1)\authors.txt"

*/

                int vibor, vibo;
                Console.WriteLine("Выберите что хотите сделать");
                Console.WriteLine("1. Открыть справочник");
                Console.WriteLine("2. Меню действий");
                Console.WriteLine("3. Выйти из системы");
                vibor = Convert.ToInt32(Console.ReadLine());
                switch (vibor)
                {
                    case 1:
                        bool run = true;

                        while (run)
                        {

                            Console.WriteLine("Какой справочник вы хотите открыть?\n1. Тайтлы\n2. Авторы\n3. Жанры");
                            Console.WriteLine("Введите '0' для выхода из программы.");
                            vibo = Convert.ToInt32(Console.ReadLine());
                            if (vibo == 1)
                            {

                                string Books = @"C:..\файлики (1)\books.txt";

                                try
                                {
                                    using (StreamReader reader = new StreamReader(Books))
                                    {
                                        string line;
                                        while ((line = reader.ReadLine()) != null)
                                        {

                                            string[] parts = line.Split('#');
                                            string result = string.Join(" ", parts);
                                            foreach (var part in parts)
                                            {
                                                Console.WriteLine(part.Trim()); // Используем Trim() для удаления пробелов
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Произошла ошибка при чтении файла: " + ex.Message);
                                }
                            }
                            if (vibo == 2)
                            {

                                string AuthorId = @"C:..\файлики (1)\authors.txt";

                                try
                                {
                                    using (StreamReader reader = new StreamReader(AuthorId))
                                    {
                                        string line;
                                        while ((line = reader.ReadLine()) != null)
                                        {

                                            string[] parts = line.Split('#');
                                            string result = string.Join(" ", parts);
                                            foreach (var part in parts)
                                            {
                                                Console.WriteLine(part.Trim()); // Используем Trim() для удаления пробелов
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Произошла ошибка при чтении файла: " + ex.Message);
                                }
                            }
                            if (vibo == 3)
                            {


                                string GenreId = @"C:..\файлики (1)\genres.txt";

                                try
                                {
                                    using (StreamReader reader = new StreamReader(GenreId))
                                    {
                                        string line;
                                        while ((line = reader.ReadLine()) != null)
                                        {

                                            string[] parts = line.Split('#');
                                            string result = string.Join(" ", parts);
                                            foreach (var part in parts)
                                            {
                                                Console.WriteLine(part.Trim()); // Используем Trim() для удаления пробелов
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Произошла ошибка при чтении файла: " + ex.Message);
                                }


                            }


                            if (vibo == 0)
                            {
                            Main(args); /*ВОЗВРАЩАЕТ К ПЕРВОЙ СТРОКЕ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
                            }
                        }
                        break;

                    case 2:

                        /*Library library = new Library();
                        library.LoadData();*/

                        bool running = true;

                        while (running)
                        {
                            Console.WriteLine("Система управления библиотеки");
                            Console.WriteLine("1. Добавить книгу");
                            Console.WriteLine("2. Изменить книгу");
                            Console.WriteLine("3. Удалить книгу");
                            Console.WriteLine("0. Выход");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    // код add book
                                    /*{
                                        Console.WriteLine("Напишите что вы хотите добавить по этому примеру (1#Война и мир#978-3-16-148410-0)");

                                        string books = @"C:\Users\Dream PC\Desktop\файлики (1)\books.txt"; 

                                        try
                                        {
                                            using (StreamWriter writer = new StreamWriter(books, true)) 
                                            {
                                                string[] dataToWrite = { "id1#name#Данные3", "Пример1#Пример2#Пример3" };

                                                foreach (var data in dataToWrite)
                                                {
                                                    writer.WriteLine(data);
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Произошла ошибка при записи в файл: " + ex.Message);
                                        }
                                    }*/
                                    string books = @"C:..\файлики (1)\books.txt";
                                    bool isRunning = true;

                                    Console.WriteLine("Введите 'exit' для выхода из программы.");
                                    Console.WriteLine("Напишите что вы хотите добавить по этому примеру (1#Война и мир#978-3-16-148410-0)");

                                    using (StreamWriter writer = new StreamWriter(books, true)) // true для добавления данных к существующему файлу
                                    {
                                        while (isRunning)
                                        {
                                            Console.Write("Введите данные: ");
                                            string input = Console.ReadLine();

                                            if (input.ToLower() == "exit")
                                            {
                                                isRunning = false;
                                            }
                                            else
                                            {
                                                writer.WriteLine(input); // Записываем введенные данные в файл
                                            }
                                        }
                                    }

                                    Console.WriteLine("Данные успешно сохранены в " + books);
                                    break;

                                case "2":

                                    string filetxtbook = @"C:..\файлики (1)\books.txt";

                                    try
                                    {
                                        using (StreamReader reader = new StreamReader(filetxtbook))
                                        {
                                            string line;
                                            while ((line = reader.ReadLine()) != null)
                                            {
                                                Console.WriteLine(line);
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Произошла ошибка при чтении файла: " + ex.Message);
                                    }


                                    string booksUpdate = @"C:..\файлики (1)\books.txt";
                                    Console.Write("Введите что вы хотите изменить: ");
                                    string oldtext = Console.ReadLine();
                                    string textToReplace = oldtext; // Текст, который нужно заменить
                                    Console.Write("Введите новое содержимое: ");
                                    string newtext = Console.ReadLine();
                                    string newText = newtext; // Текст, на который заменяем

                                    try
                                    {

                                        string fileContent = File.ReadAllText(booksUpdate);

                                        // Замена старого текста на новый
                                        fileContent = fileContent.Replace(textToReplace, newText);

                                        // Запись измененного содержимого обратно в файл
                                        File.WriteAllText(booksUpdate, fileContent);

                                        Console.WriteLine("Текст успешно изменен!");
                                    }
                                    catch (IOException ex)
                                    {
                                        Console.WriteLine($"Ошибка при работе с файлом: {ex.Message}");
                                    }
                                    break;
                                case "3":
                                string filetxtBook = @"C:..\файлики (1)\books.txt";

                                try
                                {
                                    using (StreamReader reader = new StreamReader(filetxtBook))
                                    {
                                        string line;
                                        while ((line = reader.ReadLine()) != null)
                                        {
                                            Console.WriteLine(line);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Произошла ошибка при чтении файла: " + ex.Message);
                                }
                                // код delete book
                                string filePath = @"C:..\файлики (1)\books.txt";
                                var lines = File.ReadAllLines(filePath).ToList();
                                Console.Write("Введите что вы хотите удалить: ");
                                string DeleteText = Console.ReadLine();
                                lines.RemoveAll(line => line.Contains(DeleteText)); 
                                File.WriteAllLines(filePath, lines); // Записываем оставшиеся строки обратно в файл
                                Console.WriteLine("Строки успешно удалены.");
                                break;
                                
                                case "0":
                                {
                                    Main(args); /*ВОЗВРАЩАЕТ К ПЕРВОЙ СТРОКЕ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
                                }
                                break;

                                default:
                                    Console.WriteLine("Звуки обезьяны...");
                                    break;
                            }
                        }
                        

                        break;
                    case 3:
                        Console.WriteLine("ДОМООООООООООООООООЙ");
                        break;
                    default:
                        Console.WriteLine("Звуки обезьяны...");
                        break;
                }
            }
        }
    }





    






/*
    class Kira_11scene
    {
        public int age = 33;
        public string Name { get; set; }
        string name = "Кира Йошикаге";
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void Print()
        {
            Console.WriteLine("Killer Queen способен стереть тебя в любой момент. Видишь ли, Killer Queen может превратить любой объект, которого он касается, в бомбу. Ты уже не жилец Джотаро я оставлю тебя умирать здесь как собаку ХАХАХАХА");
        }
    }
    class Jotaro_6scene
    {
        public int age = 28;
        public string Name { get; set; }
        string name = "Джотаро";
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Print()
        {
            Console.WriteLine("Джотаро Сан: Теперь нужно искать желтоволосого подтянутого мужчину который подозрительно скрывается");
        }
    }
    class Joske_5scene
    {

        public int age = 16;
        public string Name { get; set; }
        string name = "Хигишиката Джоске";
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Print()
        {
            Console.WriteLine("Хигишиката Джоске: Шигечи убили...");
        }
    }

    class Joske_3scene
    {

        public int age = 16;
        public string Name { get; set; }
        string name = "Хигишиката Джоске";
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Print()
        {
            Console.WriteLine("Хигишиката Джоске: Шигечи в опасности? Нужно поторопится в нашу школу она находится в центре Морио");
        }
    }
    class Jotaro_2scene
    {
        public int age = 28;
        public string Name { get; set; }
        string name = "Джотаро";
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Print()
        {
            Console.WriteLine("Джотаро Сан: Привет, ребята а это кто?");
        }
    }
    class Okuyasu_1scene
    {
        public int age = 16;
        public string Name { get; set; }
        string name = "Окуясу";
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Print()
        {
            Console.WriteLine("Окуясу: Ойжоске... Привет, ты тоже ищешь этого ублюдка? Я как раз иду к Джоске, а потом пойдем вместе к Джотаро сану ему нужна помощь");
        }
    }
    class Joske_1scene
    {

        public int age = 16;
        public string Name { get; set; }
        string name = "Хигишиката Джоске";
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Print()
        {
            Console.WriteLine("Хигишиката Джоске: Привет, ты тоже ищешь этого ублюдка? Сейчас жду Окуясу и мы пойдем к Джотаро сану, у него что то случилось там узнаем");
        }
    }
    class Kira
    {
        // может иметь
        // - поля (переменные, заданные на уровне класса)
        public int age = 33; // поле

        // - свойства (характеристики всех представителей класса)
        public string Name { get; set; }
        string name = "Кира Йошикаге";
        // свойство (имеет геттер - получатель значения из свойства у представителя класса - и сеттер - определитель значения для свойства в представителе класса)

        // поле и класс могут называться одинаково (поле age и свойство Age, свойство Name и поле name)
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // - методы (действия, которые может сделать сам класс или его представители)
        public void Print()
        {
            Console.WriteLine("Меня зовут Кира Йошикагэ. Мне 33 года. Мой дом находится в северо-восточной части Морио, в районе поместий. Работаю в офисе сети магазинов Kame Yu и домой возвращаюсь, самое позднее, в восемь вечера. Не курю, выпиваю изредка. Ложусь спать в 11 вечера и убеждаюсь, что получаю ровно восемь часов сна, несмотря ни на что. Перед сном я пью тёплое молоко, а также минут двадцать уделяю разминке, поэтому до утра сплю без особых проблем. Утром я просыпаюсь, не чувствуя ни усталости, ни стресса, словно младенец. На медосмотре мне сказали, что никаких проблем нет. Я пытаюсь донести, что я обычный человек, который хочет жить спокойной жизнью. Я не забиваю себе голову проблемами вроде побед или поражений, и не обзавожусь врагами, из-за которых не мог бы уснуть. Я знаю наверняка: в таком способе взаимодействия с обществом и кроется счастье. Хотя, если бы мне пришлось сражаться, я бы никому не проиграл.");

    }
}

}
*/
