using System;
using System.Diagnostics;

namespace Курсач1
{
    class Task1
    {
        double procent;
        double dolg;
        double platezh;
        double mounth;
        int variable;
        public void text()
        {
            Console.WriteLine("1 января 2015 года Павел Витальевич взял в банке 1 млн. рублей в кредит.");
            Console.WriteLine("Схема выплаты кредита следующая: 1 числа каждого следующего месяца банк начисляет");
            Console.WriteLine("1% на оставшуюся сумму долга (то есть увеличивает долг на 1%), затем Павел");
            Console.WriteLine("Витальевич переводит в банк платеж. На какое минимальное количество месяцев");
            Console.WriteLine("Павел Витальевич может взять кредит, чтобы ежемесячные выплаты были не");
            Console.WriteLine("более 125 тыс. рублей?");
            while (true)
            {
                Console.WriteLine("\nОставить данные исходными или ввести свои?\n1.Оставить исходные данные\n2.Изменить исходные данные");
                variable = Convert.ToInt32(Console.ReadLine());
                if (variable == 1)
                {
                    procent = 1;
                    dolg = 1000000;
                    platezh = 125000;
                    mounth = 0;
                    break;
                }
                else if (variable == 2)
                {
                    Console.Write("\nВведите сумму долга: ");
                    dolg = double.Parse(Console.ReadLine());
                    Console.Write("Введите сумму платежа: ");
                    platezh = double.Parse(Console.ReadLine());
                    Console.Write("Укажите процент: ");
                    procent = double.Parse(Console.ReadLine());
                    break;
                }
            }
            
        }
        public void getresult()
        {
            do
            {
                dolg *= (1 + procent / 100);
                Console.WriteLine(dolg);
                if (dolg < platezh || dolg == platezh)
                {
                    platezh = dolg;
                }
                dolg -= platezh;
                mounth += 1;
                Console.WriteLine("В " + mounth + "-м месяце долг будет равен " + dolg);  
            }
            while (dolg > 0);
            Console.WriteLine("Ответ: При данных условиях Павел Витальевич может взять кредит на " + --mounth + " месяцев");
        }
    }
    class Task2
    {
        //кредит
        double s = 1000000;
        double b = 1 + 0.01;

        public void text()
        {
            Console.WriteLine("31 декабря 2014 года Антон взял в банке 1 млн. рублей в кредит. Схема");
            Console.WriteLine("выплаты кредита следующая: 31 декабря каждого следующего года банк");
            Console.WriteLine("начисляет проценты на оставшуюся сумму долга (то есть увеличивает долг");
            Console.WriteLine("на определенное колличество процентов), затем Антон переводит ");
            Console.WriteLine("очередной транш. Антон выплатил кредит за два транша, переводя в первый");
            Console.WriteLine("раз 510 тыс. рублей, во второй - 649 тыс. рублей. Под какой процент банк");
            Console.WriteLine("выдал кредит Антону?");
        }
        public void getresult()
        { 
            
        }
    }
    class Task3
    {
        double s, p, n, a, Sp, Sum;
        public void text()
        {
            Console.WriteLine("15 января планируется взять кредит в банке на 9 месяцев. Условия его возврата таковы:\n");
            Console.WriteLine("- 1-го числа каждого месяца долг возврастает на 3% по сравнению с концом");
            Console.WriteLine("предыдущего месяца;");
            Console.WriteLine("- со 2-го по 14-е число каждого месяца необходимо выплатить часть долга;\n");
            Console.WriteLine("- со 2-го по 14-е число каждого месяца необходимо выплатить часть долга;\n");
            Console.WriteLine("- 15-го числа каждого месяца долг должен быть на одну и ту же величину меньше");
            Console.WriteLine("долга на 15-е число предыдущего месяца.\n");
            Console.WriteLine("Известно, что на пятый месяц кредитования нужно выплатить 57,5 тыс. рублей.");
            Console.WriteLine("какую сумму нужно вернуть банку в течении всего срока кредитования?");
            Console.WriteLine("Введите процент");
            p = Convert.ToDouble(Console.ReadLine());//процент
            Console.WriteLine("Введите месяц");
            n = Convert.ToDouble(Console.ReadLine());//месяц
            Console.WriteLine("Введите обязательную сумму выплаты за 5 месяцев");
            a = Convert.ToDouble(Console.ReadLine());//обязательная сумма выплаты за 5 месяцев
        }
        public void getresult()
        {
            p = 1 + p / 100;
            s = a * n / (5 * p - 4);
            Sum = 0;
            Sp = s;
            p = p / 100 + 1;
            while (Sp >= 0)
            {
                Sum = Sum + Sp;
                Sp = Sp * p - (n - 1) * s / n;
            }
            
            Console.WriteLine(Sum);
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Task1 t1 = new Task1();
            Task2 t2 = new Task2();
            Task3 t3 = new Task3();
            while (true)
            {
                int cont=1;
                if (cont == 1)
                {
                    Console.Write("Выберите номер задачи(1-3): ");
                    int variable = Convert.ToInt32(Console.ReadLine());
                    switch (variable)
                    {
                        case 1:
                            t1.text();
                            t1.getresult(); 
                            break;
                        case 2:
                            t2.text();
                            t2.getresult();
                            break;
                        case 3:
                            t3.text();
                            t3.getresult();
                            break;

                    }
                    Console.WriteLine("Продолжить?\n1.Да 2.Нет");
                    cont = Convert.ToInt32(Console.ReadLine());
                    if (cont == 2)
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Очистить консоль?\n1.Да 2.Нет");
                    cont = Convert.ToInt32(Console.ReadLine());
                    if (cont == 1)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
        }
    }
}