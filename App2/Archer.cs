using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Archer : HeroWarrior         //создание класса лучник, унаследованного от класса HeroWarrior
    {
        public int Amount_arrows;      //создание поля (переменной - кол-во стрел) класса, другие поля наследуем от HeroWarrior

        public Archer()               //конструктор по умолчанию
        {
        }
        public Archer (string name, int level, int hp, int power, int key_army_player, int amount_arrows) : base(name, level, hp, power, key_army_player) //конструктор с параметром, с помощью base передаём параметры на установку в конструктор базового класса
        {
            Amount_arrows = amount_arrows;      //определяем только новый параметр
        }

        public override string GetInfo()        //переопределяем метод из класса HeroWarrior
        {
            return $"Лучник: {base.GetInfo()}  Кол-во стрел: {Amount_arrows,3}";    //используем base.GetInfo(), чтобы не писать снова, а взять у класса родителя
        }

        public  override int GetArrows      //свойство, возвращающее кол-во стрел
        {
            get     //возвращает значение
            {
                return Amount_arrows;
            }

        }

        public override int GetSword { get; }


        public override string Attack(Hero A)   //функция атака (тип: string, имя ф-ии: Attack), входной параметр: объект класса Hero
        {                                       //переопределяем, так как был абстрактный
            if (Amount_arrows == 0)
                return "Не смог атаковать, закончились стрелы\n";
            else
            {
                if (A.Hp < 1 )
                {
                    throw new Except("\nЗдоровья не хватает для атаки! Вызовите мага для лечения!");       //"бросает"/вызывает исключение класса Except и передаёт входной параметр в конструктор 
                }
                else
                {
                    A.Hp = A.Hp - Power * 3;
                    if (A.Hp<1)
                    {
                        A.Hp = 0;
                    }
                    Power -= 1;                     //тратим силу на атаку
                    Amount_arrows -= 1;             //тратим стрелы на атаку
                    return "\nВы атаковали соперника успешно\n";
                }
            }
        }
    }
}
