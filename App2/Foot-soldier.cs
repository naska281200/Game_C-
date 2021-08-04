using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Foot_soldier: HeroWarrior      //создание класса пехотинец, унаследованного от класса HeroWarrior
    {
        public int Sword { private set; get; }        //создание поля (переменной - меч) класса, другие поля наследуем от HeroWarrior

        public Foot_soldier()               //конструктор по умолчанию
        {
        }

        public Foot_soldier (string name, int level, int hp, int power, int key_army_player, int sword) : base(name, level, hp, power, key_army_player) //конструктор с параметром, с помощью base передаём параметры на установку в конструктор базового класса
        {
            Sword = sword;      //определяем только новый параметр
        }

        public override string GetInfo()        //переопределяем метод из класса HeroWarrior
        {
            return $"Пехотинец: {base.GetInfo()} Кол-во мечей: {Sword,3}";    //используем base.GetInfo(), чтобы не писать снова, а взять у класса родителя
        }

        public override int GetSword     //свойство, возвращающее кол-во мечей
        {
            get     //возвращает значение
            {
                return Sword;
            }
        }

        public override int GetArrows { get; }

        public override string Attack(Hero A)   //функция атака (тип: string, имя ф-ии: Attack), входной параметр: объект класса Hero
        {                                       //переопределяем, так как был абстрактный
            if (Sword == 0)
                return "Не смог атаковать, нет меча\n";
            else
            {
                if (A.Hp < 1)
                {
                    throw new Except("\nЗдоровья не хватает для атаки! Вызовите мага для лечения!");       //"бросает"/вызывает исключение класса Except и передаёт входной параметр в конструктор 
                }
                else
                {
                    A.Hp = A.Hp - Power * 3;
                    if (A.Hp < 1)
                    {
                        A.Hp = 0;
                    }
                    Power -= 1;                     //тратим силу на атаку
                    Sword -= 1;                      //тратим меч на атаку
                    return "\nВы атаковали соперника успешно\n";
                }
            }
        }
    }
}
