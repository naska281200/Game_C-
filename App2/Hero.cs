using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    abstract class Hero
    {
        public string Name;     //создание полей (переменных), доступных вне класса Hero
        public int Level;      
        public int Hp;          //здоровье

        public Hero()       //конструктор по умолчанию
        {
        }
        public Hero(string name, int level, int hp)     //конструктор с параметром
        {
            Name = name;    //указываем каким полям принадлежат параметры из конструктора
            Level = level;
            if (hp < 1)
            {
                throw new Except ("Здоровье должно быть положительным и больше 0! Введите заново: ");  //"бросает"/вызывает исключение класса Except и передаёт входной параметр в ф-ию Except
            }
            else
            {
                Hp = hp;
            }
           
        }

        public abstract string GetInfo();  //создаём абстрактный метод GetInfo, не имеет тела

    }
}
