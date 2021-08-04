using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class HeroWizard:Hero       //класс волшебника, наследуется от класса родителя - Hero
    {
        public int Mp;          //создание поля (переменной - энергия) класса, другие поля наследуем от Hero

        public HeroWizard()     //конструктор без параметров
        { }
        public HeroWizard(string name, int level, int hp, int mp) : base(name, level, hp)   //конструктор с параметром, с помощью base передаём параметры на установку в конструктор базового класса
        {
            Mp = mp;                        //определяем только новый параметр
        }
        public override string GetInfo()    //полиморфизм - переопределяем метод от класса Hero, так как был абстрактным
        {
            return $"HeroWizard = Имя: {Name,3} Уровень: {Level,3} HP: {Hp,3} MP: {Mp,3}";
        }
        public string ToBeHeal(Hero A)        //функция излечивания (тип: string, имя ф-ии: ToBeHeal), входной параметр: объект класса Hero
        {
            if (Mp == 0)                     //если энергии не осталось
                return "\nМаг не вылечил, у него закончилась волшебная энергия((\n";
            else
            {
                A.Hp = A.Hp + 3 * Level;
                Mp -= 1;                    //тратит энергию на излечивание
                if (A.Hp > 100)
                    A.Hp = 100;
                return "\nМаг добавил немного здоровья вашему воину\n";    //возвращаем объект класса Hero
            }
        }

        public string ToBeHealWizard(HeroWizard A)        //функция излечивания мага (тип: string, имя ф-ии: ToBeHealWizard), входной параметр: объект класса HeroWizard
        {
            Mp = 20;      //добавляем волшебную энергию магу
            return ("\nМагу прибавилась волшебная энергия!");
        }
    }
}
