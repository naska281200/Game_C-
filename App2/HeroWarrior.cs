using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    abstract class HeroWarrior : Hero            //создание класса воина, унаследованного от класса Hero и также abstract
    {
        public int Power;               //создание поля (переменной - сила) класса, другие поля наследуем от Hero
        public int Key_army_player;     //создание поля (переменной - ключа) класса, другие поля наследуем от Hero
        public HeroWarrior()            //конструктор по умолчанию
        {
        }
        public HeroWarrior(string name, int level,int hp, int power, int key_army_player) : base(name, level, hp)        //конструктор с параметром, с помощью base передаём параметры на установку в конструктор базового класса
        {
            Power = power;              //определяем только новый параметр
            Key_army_player = key_army_player;      
        }
        public override string GetInfo() //переопределяем метод из класса Hero, так как он был абстрактным
        {
            return $"Имя: {Name,3} Уровень: {Level,3} HP: {Hp,3} Power: {Power,3}";
        }

        public virtual int GetPower()      //ф-ия возвращающая кол-во сил
        {
            return Power;
        }
        public abstract string Attack(Hero A);      //абстрактная функция атака (тип: string, имя ф-ии: Attack), входной параметр: объект класса Hero, тела не имеет

        public abstract int GetArrows { get; }      //свойтсво, возвращающее кол-во стрел

        public abstract int GetSword { get; }     //свойство, возвращающее кол-во мечей
    }
}
