using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        begin:
            int q = 0;
        enter:
            Console.WriteLine($"Выберите номер задачи (1 или 2) или нажмите 3 для выхода..");
            q = Convert.ToInt32(Console.ReadLine());
            switch (q)
            {
                case 1:
                    goto first;
                case 2:
                    goto second;
                case 3:
                    goto end;
                default:
                    Console.WriteLine("_Ошибка ввода данных! Попробуйте еще раз..");
                    goto enter;
            }
        first:
            Console.WriteLine($"...Длинное слово...");
            Console.WriteLine($"_Введите предложение..");
            string pr = Console.ReadLine();
            string[] spr = pr.Split(' ');
            int len = 0;
            string longer = "";
            for (int i = 0; i < spr.Length; i++)
            {
                if (spr[i].Length > len)
                {
                    len = spr[i].Length;
                    longer = spr[i];
                }
            }
            Console.WriteLine($"_Самое длинное слово: {longer}");
            goto begin;
        second:
            Console.WriteLine($"...Палиндром...");
            Console.WriteLine($"_Введите предложение..");
            string str = Console.ReadLine();
            string[] masp = str.Split(' ');
            string newstr = "";
            for (int i=0; i<masp.Length; i++)
            {
                newstr += masp[i];
            }
            newstr = newstr.ToLower();
            for ( int exit=0, key=0, i=0; i<newstr.Length/2; i++)
            {

                if (newstr[i] != newstr[newstr.Length - 1 - i])
                {
                    exit++;
                    Console.WriteLine($"_Не палиндром..");
                } else key++;
                if (exit != 0) break; else if (key == newstr.Length / 2) Console.WriteLine($"_Является палиндромом..");
            }
            goto begin;
        end:
            Console.WriteLine($"GoodBuy!!");
            Console.ReadKey();
        }
    }
}

