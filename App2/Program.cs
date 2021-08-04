using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hero
            /*
            Hero Orc = new Hero();          //создание объекта в куче с использованием конструктора по умолчанию
            Orc.Name = "Orc";               //инициализируем поля объекта
            Orc.Level = 11;                 //инициализируем поля объекта
            Orc.Hp = 100;                   //инициализируем поля объекта
            Console.WriteLine($"Hero Orc = Name: {Orc.Name,5} Level: {Orc.Level,5} Hp: {Orc.Hp,5}"); //даёт 5 полей под запись


            Hero Human = new Hero()        //инициализатор   
            {
                Name = "Bob",               
                Level = 1
            };
            //Console.WriteLine(Human.Name +" "+ Human.Level);       //вывод только значений полей
            Console.WriteLine($"\nHero Human = Name: {Human.Name} Level: {Human.Level}");

            Hero Elf = new Hero("Ozi", 50, 100);                //создание объекта в куче с использованием конструктора с параметром
            Console.WriteLine($"\nHero Elf = Name: {Elf.Name} Level: {Elf.Level} Hp: {Elf.Hp}");
            */

            /*
            Hero DarkElf = new Hero();                          //создание объекта в куче с использованием конструктора по умолчанию
            Console.Write("\nВведите Имя DarkElf : ");
            DarkElf.Name = Console.ReadLine();                  //инициализируем поле Name
            Console.Write("Введите уровень DarkElf: ");
            DarkElf.Level = int.Parse(Console.ReadLine());      //инициализируем поле Level
            Console.Write("Введите кол-во жизней DarkElf: ");
            DarkElf.Hp = int.Parse(Console.ReadLine());         //инициализируем поле Level

            Console.WriteLine("\n" + DarkElf.GetInfo());               //вызов функции GetInfo
            Console.WriteLine();
            */

            //HeroWizard Potter = new HeroWizard("Potter", 100, 100, 10);     //создание объекта в куче с использованием конструктора с параметром
            //Console.WriteLine(Potter.GetInfo() + "\n");

            //Hero VolanDeMort = new HeroWizard("VolandDeMort", 2, 100, 9);
            //Console.WriteLine(VolanDeMort.GetInfo());

            //HeroWizard Ronald = new HeroWizard("Ronald", 5, 100, 10);       //создание объекта в куче с использованием конструктора с параметром
            //Console.WriteLine(Ronald.GetInfo() + "\n");

            //HeroWarrior Spartak = new HeroWarrior("Spartak", 10, 100, 20);  //создание объекта в куче с использованием конструктора с параметром
            //Console.WriteLine(Spartak.GetInfo()+"\n");

            //HeroWarrior Lancelot = new HeroWarrior("Lancelot", 10, 100, 35);//создание объекта в куче с использованием конструктора с параметром
            //Console.WriteLine(Lancelot.GetInfo()+ "\n");

            //Console.WriteLine(Lancelot.Attack(Spartak));               //вызов функции атака
            //Console.WriteLine(Spartak.Attack(Lancelot));               //вызов функции атака
            //Console.WriteLine(Lancelot.GetInfo() + "\n");              //проверяем данные после атаки
            //Console.WriteLine(Spartak.GetInfo() + "\n");               //проверяем данные после атаки

            //Console.WriteLine(Potter.ToBeHeal(Spartak));               //вызов функции лечения
            //Console.WriteLine(Ronald.ToBeHeal(Lancelot));              //вызов функции лечения
            //Console.WriteLine(Spartak.GetInfo() + "\n");               //проверяем данные после лечения
            //Console.WriteLine(Lancelot.GetInfo() + "\n");              //проверяем данные после лечения
            #endregion

            string name;            //создание переменных для полей объектов
            int level, hp, power, arrows, mp, sword;        
            string variable;        //создаём переменную для значения "Хотите начать игру? (да, нет): "
            int amount = 0; //перменная для хранения кол-ва записанных игроков в армии
            bool flag;    //создание переменной flag для выявления правильности значения переменной hp
            int key_army_player;     //переменная, для значения ключа воина в армии (1-лучник, 2-пехотинец) 
            List<HeroWizard> Wizard = new List<HeroWizard>();   //создание списка для магов
            Dictionary<int, HeroWarrior> Army = new Dictionary<int, HeroWarrior>(); //создаём словарь из воинов
            Console.WriteLine("Хотите начать игру? (да, нет): ");
            do
            {
                variable = Console.ReadLine();
                if (variable == "да")
                {
                    char player;        //создание переменной для значения персонажа маг, своя армия, всех уже создал
                    do
                    {
                        Console.WriteLine("Какого персонажа хотите создать? (1-маг, 2-своя армия, 3-всех уже создал, больше не нужно): ");
                        player = Convert.ToChar(Console.ReadLine());
                        #region Wizard
                        if (player == '1')
                        {
                            HeroWizard Gendalf = new HeroWizard();  //создание объекта Gendalf класса маг
                            Console.WriteLine("Сколько Вам нужно магов для игры?");
                            int count_wizard = int.Parse(Console.ReadLine());      //переменная, для кол-ва магов
                            for (int i = 0; i < count_wizard; i++)
                            {
                                Console.WriteLine($"Введите имя {i + 1} мага: ");
                                name = Console.ReadLine();
                                Console.WriteLine($"Введите уровень {i + 1} мага: ");
                                level = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Введите здоровье {i + 1} мага: ");
                                hp = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Введите кол-во волшебной энергии {i + 1} мага: ");
                                mp = int.Parse(Console.ReadLine());
                                flag = true;
                                while (flag)
                                {
                                    try
                                    {
                                        Gendalf = new HeroWizard(name, level, hp, mp);//каждый i раз создаём нового Gendalf с параметрами
                                        flag = false;       //для выхода из цикла
                                    }
                                    catch (Except)
                                    {
                                        hp = int.Parse(Console.ReadLine());     //при возникновении ошибки (hp<1)
                                    }
                                }
                                Wizard.Add(Gendalf);      //добавление объекта Gendalf в список(коллекцию) Wizard
                            }
                            Console.WriteLine("В объединении Wizard содержится: ");
                            foreach (HeroWizard i in Wizard)      //проходим по всем объектам в листе
                            {
                                Console.WriteLine($"{i.GetInfo()} ");      //выводим информацию о магах
                            }

                            Console.WriteLine("\nХотите создать другого персонажа?(да(напиши да) или нет(напиши любой символ)):");
                            if (Console.ReadLine() == "да")
                                player = '0';       //присваиваем любое значение(кроме 1 и 2), чтобы не вышел из цикла
                            else
                                player = '1';       //для выхода из большого цикла
                        }
                        #endregion
                        #region Army
                        else if (player == '2')     //если создаём армию
                        {
                            #region Dictionary
                            char player_army;       //создаём переменную для значения игрока в армии
                            do
                            {
                                Console.WriteLine("Кого хотите создать в армии (1-лучник, 2-пехотинец)?");
                                player_army = Convert.ToChar(Console.ReadLine());
                                #region Archer
                                if (player_army == '1')     //создаём лучников
                                {
                                    Archer Archman = new Archer();//создание объекта Archman класса Archer без параметров
                                    Console.WriteLine("Сколько Вам нужно лучников в Army для игры?");
                                    int count_archer = int.Parse(Console.ReadLine());   //кол-во лучников
                                    for (int i = 0; i < count_archer; i++)
                                    {
                                        Console.WriteLine($"Введите имя {i + 1} лучника: ");
                                        name = Console.ReadLine();
                                        Console.WriteLine($"Введите уровень {i + 1} лучника: ");
                                        level = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"Введите здоровье {i + 1} лучника: ");
                                        hp = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"Введите кол-во сил {i + 1} лучника: ");
                                        power = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"Введите кол-во стрел {i + 1} лучника: ");
                                        arrows = int.Parse(Console.ReadLine());
                                        key_army_player = 1;        //ключ, по которому определяем лучника
                                        flag = true;
                                        while (flag) 
                                        {
                                            try
                                            {
                                                Archman = new Archer(name, level, hp, power, key_army_player, arrows);//каждый i раз создаём нового Archman с параметрами
                                                flag = false;
                                            }
                                            catch (Except)
                                            {
                                                hp = int.Parse(Console.ReadLine());     //при возникновении ошибки (hp<1)
                                            }
                                        }
                                        if (amount == 0)    //ещё не созданы игроки в армии
                                        {
                                            Army.Add(i, Archman);      //добавление объекта Archman в словарь Army
                                        }
                                        else
                                        {
                                            Army.Add(i + amount, Archman);      //добавление объекта Archman в словарь Army
                                        }
                                    }
                                    amount += count_archer;     //меняем значение amount на записавшихся игроков

                                    Console.WriteLine("В Army содержится: ");
                                    foreach (KeyValuePair<int, HeroWarrior> keyValue in Army)      //проходим по всем объектам в словаре
                                    {
                                        Console.WriteLine($"Ключ: {keyValue.Key}  {keyValue.Value.GetInfo()}");      //выводим информацию об армии
                                    }
                                    Console.WriteLine("\nХотите создать другого персонажа?(да(напиши да) или нет(напиши любой символ)):");
                                    if (Console.ReadLine() == "да")
                                        player = '0';       //присваиваем любое значение(кроме 1 и 2), чтобы не вышел из цикла
                                    else
                                        player = '1';       //для выхода из большого цикла
                                }
                                #endregion
                                #region Foot-soldier
                                else if (player_army == '2')      //создаём пехотинцев
                                {
                                    Foot_soldier Soilder = new Foot_soldier();   //создание объекта в куче с использованием конструктора с параметром
                                    Console.WriteLine("Сколько Вам нужно пехотинцев в Army для игры?");
                                    int count_soldier = int.Parse(Console.ReadLine());    //кол-во пехотинцев
                                    for (int i = 0; i < count_soldier; i++)
                                    {
                                        Console.WriteLine($"Введите имя {i + 1} пехотинца: ");
                                        name = Console.ReadLine();
                                        Console.WriteLine($"Введите уровень {i + 1} пехотинца: ");
                                        level = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"Введите здоровье {i + 1} пехотинца: ");
                                        hp = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"Введите кол-во сил {i + 1} пехотинца: ");
                                        power = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"Введите кол-во мечей {i + 1} пехотинца: ");
                                        sword = int.Parse(Console.ReadLine());
                                        key_army_player = 2;
                                        flag = true;
                                        while (flag)
                                        {
                                            try
                                            {
                                                Soilder = new Foot_soldier(name, level, hp, power, key_army_player, sword);//каждый i раз создаём нового Foot_soldier с параметрами
                                                flag = false;
                                            }
                                            catch (Except)
                                            {
                                                hp = int.Parse(Console.ReadLine());     //при возникновении ошибки (hp<1)
                                            }
                                        }
                                        if (amount == 0)
                                            Army.Add(i, Soilder);      //добавление объекта Soilder в словарь(коллекцию) Army, где i - ключ
                                        else
                                        {
                                            Army.Add(i + amount, Soilder);      //добавление объекта Soilder в словарь(коллекцию) Army, где i - ключ
                                        }
                                    }
                                    amount = amount + count_soldier;     //меняем значение amount на записавшихся игроков
                                    Console.WriteLine("В Army содержится: ");
                                    foreach (KeyValuePair<int, HeroWarrior> keyValue in Army)      //проходим по всем объектам в словаре
                                    {
                                        Console.WriteLine($"Ключ: {keyValue.Key}  {keyValue.Value.GetInfo()}");      //выводим информацию об армии
                                    }
                                    Console.WriteLine("\nХотите создать другого персонажа?(да(напиши да) или нет(напиши любой символ)):");
                                    if (Console.ReadLine() == "да")
                                        player = '0';       //присваиваем любое значение(кроме 1 и 2), чтобы не вышел из цикла
                                    else
                                        player = '2';       //для выхода из большого цикла
                                }
                                #endregion
                                else
                                {
                                    Console.WriteLine("Некорректный ввод. Введите заново: ");
                                }
                            } while (player_army != '1' & player_army != '2');//пока ввод будет некорректным, не выйдет из цикла
                            #endregion
                        }
                        #endregion
                        else if (player == '3')    //игрок всех создал уже, выход из большого цикла
                        {
                            player = '1';       //для выхода из большого цикла
                        }
                        else
                            Console.WriteLine("Некорректный ввод. Введите заново: ");
                    } while (player != '1' & player != '2');    //пока ввод будет некорректным, не выйдет из цикла
                }
                else if (variable == "нет")
                {
                    Console.WriteLine("Game over...");
                    goto End;   //переход в End
                }
                else
                    Console.WriteLine("Некорректный ввод. Введите заново: ");

            } while (variable != "да" & variable != "нет");    //пока ввод будет некорректным, не выйдет из цикла

            Console.Clear();       //очищаем консоль

            #region Battle 
            Archer Mongolf = new Archer("Mongolf", 20, 100, 9, 1, 4);     //создание лучника Mongolf (уже установлен в игре)
            Foot_soldier Phinick = new Foot_soldier("Phinick", 12, 100, 4, 2, 10);   //создание объекта в куче с использованием конструктора с параметром (уже установлен в игре)
            Console.WriteLine("\nНачнём битву! ");
            Dictionary<int, HeroWarrior> Army2 = new Dictionary<int, HeroWarrior>   //инициализация словаря Army2
            {
                {0,  Mongolf},
                {1,  Phinick}
            };
            if (Army.Count == 0)    //не создан ни один воин
            {
                Console.WriteLine("\nНевозможно сражаться, так как не создан ни один воин");
                Console.WriteLine("Game over...");
                goto End;       //выход из игры
            }
            string b; //переменная для значения выбора Будешь сражаться или попросишь мага прибавить тебе здоровья, или хочешь выйти из игры
            //цикл для битвы и лечения
            do
            {
                Console.WriteLine("\nБудешь сражаться (1) или попросишь мага прибавить тебе здоровья (2), или хочешь выйти из игры (3)?");
                b = Console.ReadLine();  //переменная для значения выбора
                if (b == "1")     //сражение
                {
                    flag = true;     //приравниваем значение истина для цикла
                    while (flag)     //выполняется, когда = 1
                    {
                            Dictionary <int, HeroWarrior> Loser = new Dictionary <int, HeroWarrior>();      //создание словаря для проигравших игроков
                            foreach (KeyValuePair<int, HeroWarrior> keyValue in Army)      //проходим по всем объектам в словаре
                            {   //если нет сил или меча или стрел, то игрок покидает игру
                                if (keyValue.Value.Key_army_player==1)      //воин лучник
                                {
                                    if ((keyValue.Value.Power < 1) | (keyValue.Value.GetArrows < 1))    //проверяем силу и стрелы
                                    {
                                        Console.WriteLine($"\nК сожалению игрок {keyValue.Value.GetInfo()} проиграл, так как у него нет либо сил либо стрел(((");
                                        Loser.Add(keyValue.Key, keyValue.Value);  //добавляем в словарь проигравшего
                                    }
                                }
                                if (keyValue.Value.Key_army_player == 2)      //воин пехотинец
                                {
                                    if ((keyValue.Value.Power < 1) | (keyValue.Value.GetSword < 1))    //проверяем силу и мечи
                                    {
                                        Console.WriteLine($"\nК сожалению игрок {keyValue.Value.GetInfo()} проиграл, так как у него нет либо сил либо мечей(((");
                                        Loser.Add(keyValue.Key, keyValue.Value);  //добавляем в список проигравшего
                                    }
                                }
                            }
                            foreach (KeyValuePair<int,HeroWarrior> keyValue in Loser)    //пробегаемся по всему списку проигрвших
                            {
                                Army.Remove(keyValue.Key);      //удаляет по ключу из армии воина
                            }
                            if (Army.Count == 0)    //все проиграли
                            {
                                Console.WriteLine("\nВсе твои воины проиграли(((");
                                Console.WriteLine("\nGame over...");
                                goto End;
                            }

                            //смотрим воинов противника
                            Dictionary<int, HeroWarrior> Loser_protiv = new Dictionary<int, HeroWarrior>();      //создание словаря для проигравших игроков противника
                            foreach (KeyValuePair<int, HeroWarrior> keyValue in Army2)      //проходим по всем объектам в словаре
                            {   //если нет сил или меча или стрел, то игрок покидает игру
                                if (keyValue.Value.Key_army_player == 1)      //воин лучник
                                {
                                    if ((keyValue.Value.Power < 1) | (keyValue.Value.GetArrows < 1))    //проверяем силу и стрелы
                                    {
                                        Console.WriteLine($"\nПротивник {keyValue.Value.GetInfo()} проиграл, так как у него нет либо сил либо стрел)))");
                                        Loser_protiv.Add(keyValue.Key, keyValue.Value);  //добавляем в словарь проигравшего
                                    }
                                }
                                if (keyValue.Value.Key_army_player == 2)      //воин пехотинец
                                {
                                    if ((keyValue.Value.Power < 1) | (keyValue.Value.GetSword < 1))    //проверяем силу и мечи
                                    {
                                        Console.WriteLine($"\nПротивник {keyValue.Value.GetInfo()} проиграл, так как у него нет либо сил либо мечей(((");
                                        Loser_protiv.Add(keyValue.Key, keyValue.Value);  //добавляем в словарь проигравшего
                                    }
                                }
                            }
                            foreach (KeyValuePair<int, HeroWarrior> keyValue in Loser_protiv)    //пробегаемся по всему списку проигравших у противника
                            {
                                Army2.Remove(keyValue.Key);      //удаляет по ключу из армии противника
                            }
                            if (Army2.Count == 0)    //все проиграли у соперника
                            {
                                Console.WriteLine("\nВсе соперники погибли. Ты выиграл!!!!!!!");
                                goto End;
                            }
                            else if ((Army.Count != 0) & (Army2.Count != 0))       //имеется и своя армия, и противника, тогда происходит сражение 
                            {
                                bool bad=true;      //переменная, определяющая сражение (если для сражения не хватает здоровья и нет магов, то сражение не состоится)
                                Console.WriteLine("\nВыбери кого-нибудь из соперников для сражения(напиши номер ключа):");
                                foreach (KeyValuePair<int, HeroWarrior> keyValue in Army2)      //проходим по всем объектам в словаре Army2
                                {
                                    Console.WriteLine($"Ключ: {keyValue.Key}  {keyValue.Value.GetInfo()}");      //выводим информацию всех объектов из армии
                                }
                                int varity = int.Parse(Console.ReadLine());     //создаём переменную для значения ключа выбранного противника
                                Console.WriteLine("\nВыбери какой герой будет сражаться из твоей Армии? (напиши номер ключа):");
                                foreach (KeyValuePair<int, HeroWarrior> keyValue in Army)      //проходим по всем объектам в словаре
                                {
                                    Console.WriteLine($"Ключ: {keyValue.Key}  {keyValue.Value.GetInfo()}");      //выводим информацию всех объектов из армии
                                }
                                amount = int.Parse(Console.ReadLine());      //используем переменную для ключа воина из армии
                                bool flag2 = true;
                                while (flag2)   //цикл для атаки(если здоровья нет, то атаковать нельзя)
                                {
                                    try
                                    {
                                        Army2[varity].Attack(Army[amount]);     //соперник атакует
                                        Console.WriteLine("\nВас ранили(((");
                                        flag2 = false;
                                    }
                                    catch (Except)
                                    {
                                        int k = 0;      //переменная для ключа в списке магов
                                        if (Wizard.Count == 0)    //не создан ни один маг
                                        {
                                            Console.WriteLine("\nНевозможно вылечить воина, так как не создан ни один маг");
                                            flag2= false;   //для выхода из цикла
                                            bad = false;    //сражения не состоится, так как нет мага, чтобы поднять здоровье
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nВыберите и напишите его ключ:");  //ключ мага
                                            foreach (HeroWizard i in Wizard)      //проходим по всем объектам в списке магов
                                            {
                                                Console.WriteLine($"Ключ: {k} {i.GetInfo()}");      //выводим информацию всех объектов из объединения магов
                                                k += 1;
                                            }
                                            int player_wizard = int.Parse(Console.ReadLine());      //используем переменную для ключа мага из списка
                                            if (Wizard[player_wizard].Mp == 0)  //у мага закончилась волшебная энергия
                                            {
                                                Console.WriteLine("Добавить энергии магу? если да (напиши да), если нет (напиши любой символ)");
                                                if (Console.ReadLine() == "да")
                                                {
                                                    Console.WriteLine(Wizard[player_wizard].ToBeHealWizard(Wizard[player_wizard]));     //добавление энергии магу
                                                    Console.WriteLine(Wizard[player_wizard].ToBeHeal(Army[amount]));    //маг player_wizard из списка лечит нашего воина
                                                }
                                                else
                                                {
                                                    flag2 = true;       //просто переходим в начало цикла
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine(Wizard[player_wizard].ToBeHeal(Army[amount]));    //маг player_wizard из списка лечит нашего воина
                                            }
                                        }
                                    }
                                }
                                if (bad == false)    //сражение не состоится 
                                {
                                    Console.WriteLine("\nСражения не было, так как нет ни одного мага, чтобы поднять здоровье!!!");
                                }
                                else
                                {
                                    Console.WriteLine(Army[amount].Attack(Army2[varity]));      //наш воин атакует соперника
                                }
                            }

                            Console.WriteLine("\nХотите сразиться снова? (да(напиши да) или нет(напиши любой символ):");
                            variable = Console.ReadLine();      //присваиваем выбор
                            if (variable == "да")
                            {
                                flag = true;        //чтобы остаться в цикле и сражаться снова
                            }
                            else
                            {
                                flag = false;       //чтобы выйти из цикла
                                Console.Clear();    //очищает консоль
                            }
                    }
                }
                else  if (b=="2")   //лечение магом
                {
                    flag = true;
                    while (flag)
                    {
                        if (Wizard.Count==0)    //не создан ни один маг
                        {
                            Console.WriteLine("\nНевозможно вылечить воина, так как не создан ни один маг");
                            flag = false;   //для выхода из цикла
                        }
                        else
                        {
                            Console.WriteLine("\nВыберите воина для добавления здоровья (напишите его ключ):");
                            foreach (KeyValuePair<int, HeroWarrior> keyValue in Army)      //проходим по всем объектам в словаре
                            {
                                Console.WriteLine($"Ключ: {keyValue.Key}  {keyValue.Value.GetInfo()}");      //выводим информацию всех объектов из армии
                            }
                            amount = int.Parse(Console.ReadLine());      //используем переменную для ключа воина из армии
                            Console.WriteLine("\nВыберите мага (напишите его ключ):");
                            int k = 0;      //переменная для ключа в списке магов
                            foreach (HeroWizard i in Wizard)      //проходим по всем объектам в объединении магов
                            {
                                Console.WriteLine($"Ключ: {k} {i.GetInfo()}");      //выводим информацию всех объектов из армии
                                k += 1;
                            }
                            int player_wizard = int.Parse(Console.ReadLine());      //используем переменную для ключа мага из списка
                            Console.WriteLine(Wizard[player_wizard].ToBeHeal(Army[amount]));    //маг player_wizard из списка лечит воина по ключу amount
                            Console.WriteLine("\nХотите ещё кому-то добавить здоровья? (да(напишите да) или нет(напишите любой символ):");
                            string str = Console.ReadLine();      //присваиваем выбор
                            if (str == "да")
                            {
                                flag = true;        //чтобы остаться в цикле и вылечиться снова
                            }
                            else
                            {
                                flag = false;
                                Console.Clear();    //очищает консоль
                            }
                        }
                    }
                }
                else if (b=="3")    //выход из игры
                {
                    Console.WriteLine("Game over...");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Введите заново: ");
                }
            } while (b != "3");
            #endregion
            End:
            Console.ReadKey();
        }
    }
}
