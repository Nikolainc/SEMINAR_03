class Program
{
    static void Main(string[] args)
    {
        #region SEMINAR

        #region Задача 1
        //Напишите программу, которая принимает на вход координаты точки(X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

        //int X;
        //int Y;
        //int.TryParse(Console.ReadLine(), out X);
        //int.TryParse(Console.ReadLine(), out Y);

        //if (X != 0 && Y != 0)
        //{
        //    if (X > 0 && Y > 0)
        //    {
        //        Console.WriteLine("I Четверть");
        //    }
        //    else if (X < 0 && Y < 0)
        //    {
        //        Console.WriteLine("III Четверть");
        //    }
        //    else if (X < 0 && Y > 0)
        //    {
        //        Console.WriteLine("II Четверть");
        //    }
        //    else if (X > 0 && Y < 0)
        //    {
        //        Console.WriteLine("IV Четверть");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Точки находятся в 0, 0");
        //}

        #endregion

        #region Задача 2

        ////Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
        //A(3, 6); B(2, 1)-> 5,09
        //A(7, -5); B(1, -1)-> 7,21

        //int[] vector1 = { 1, 2 };
        //int[] vector2 = { 3, 4 };
        //Console.Write("Введите Х1: ");
        //vector1[0] = int.Parse(Console.ReadLine());
        //Console.Write("Введите Y1: ");
        //vector1[1] = int.Parse(Console.ReadLine());
        //Console.Write("Введите Х2: ");
        //vector2[0] = int.Parse(Console.ReadLine());
        //Console.Write("Введите Y2: ");
        //vector2[1] = int.Parse(Console.ReadLine());
        //Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(vector1[0] - vector2[0], 2) + Math.Pow(vector1[1] - vector2[1], 2)), 3));

        #endregion

        #region Задача 3
        //Напишите программу, которая принимает на вход число(N) и выдаёт таблицу квадратов чисел от 1 до N.
        //5-> 1, 4, 9, 16, 25.
        //2-> 1,4

        //int N;
        //int.TryParse(Console.ReadLine(), out N);

        //for (int i = 1; i <= N; i++)
        //{
        //    Console.WriteLine(Math.Pow(i, 2));
        //}

        #endregion

        #region Задача 4



        #endregion

        #endregion

        #region HOMEWORK

        #region Задача 19
        //Задача 19
        //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        //14212->нет
        //12821->да
        //23432->да

        //while (true)
        //{
        //    int value;
        //    Console.Write("Введите пятизначное число: ");
        //    int.TryParse(Console.ReadLine(), out value);
        //    if (value >= 100000 || value < 10000)
        //        continue;
        //    var value2 = value / 1000;
        //    value = ((value % 100) % 10) * 10 + (value % 100) / 10;
        //    if (value2 == value)
        //    {
        //        Console.WriteLine($"Верно, число палиндром");
        //    }
        //}

        #endregion

        #region Задача 21
        //Задача 21
        //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        //A(3, 6, 8); B(2, 1, -7), -> 15.84
        //A(7, -5, 0); B(1, -1, 9)-> 11.53

        //int[] vector1 = new int[3];
        //int[] vector2 = new int[3];
        //Console.Write("Введите Х1: ");
        //vector1[0] = int.Parse(Console.ReadLine());
        //Console.Write("Введите Y1: ");
        //vector1[1] = int.Parse(Console.ReadLine());
        //Console.Write("Введите Z1: ");
        //vector1[2] = int.Parse(Console.ReadLine());
        //Console.Write("Введите Х2: ");
        //vector2[0] = int.Parse(Console.ReadLine());
        //Console.Write("Введите Y2: ");
        //vector2[1] = int.Parse(Console.ReadLine());
        //Console.Write("Введите Z2: ");
        //vector2[2] = int.Parse(Console.ReadLine());

        //Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(vector1[0] - vector2[0], 2) + Math.Pow(vector1[1] - vector2[1], 2) + Math.Pow(vector1[2] - vector2[2], 2)), 2, MidpointRounding.ToNegativeInfinity));

        #endregion

        #region Задача 23
        //Задача 23
        //Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
        //3-> 1, 8, 27
        //5-> 1, 8, 27, 64, 125

        int N;
        int.TryParse(Console.ReadLine(), out N);

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(Math.Pow(i, 3));
        }

        #endregion

        #endregion
    }
}