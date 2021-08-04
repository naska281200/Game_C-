using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Except : Exception    //создание класса Except, унаследованного от Exception
    {
        public Except() { }     //конструктор без параметров

        public Except(string message)       //ф-ия с параметром
        {
           Console.WriteLine(message);
        }
        //public string Negativ(Archer A)
        //{

        //}

        //internal new string Message()
        //{
        //    return "Hp не должно быть отрицательной или = 0";
        //}
    }
}
