using System;

namespace PowerOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("qüvvet = ");
                long number = Convert.ToInt64(Console.ReadLine());
                Console.Write("eded = ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (IsPowerOfNumber(number, n))
                    Console.WriteLine($"\n{number} ədədi {GetNumberWithPostfix(n)} qüvvətidir");
                else
                    Console.WriteLine($"\n{number} ədədi {GetNumberWithPostfix(n)} qüvvəti deyil");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static bool IsPowerOfNumber(long number, int n)
        {
            if (number % n != 0)
                return false;
            while (number > 1)
            {
                if (number % n == 0)
                {
                    number /= n;
                    continue;
                }
                else
                    return false;
            }
            return true;
        }


        private static string GetNumberWithPostfix(int n)
        {
            switch (n % 10)
            {
                case 1:
                case 5:
                case 8:
                    return $"{n}-in";
                case 2:
                case 6:
                case 7:
                    return $"{n}-nin";
                case 3:
                case 4:
                    return $"{n}-ün";
                case 9:
                    return $"{n}-un";
                case 0:
                    switch (n % 100)
                    {
                        case 10:
                            return $"{n}-nun";
                        case 30:
                            return $"{n}-un";
                        case 20:
                        case 50:
                        case 80:
                            return $"{n}-nin";
                        case 40:
                        case 60:
                        case 90:
                            return $"{n}-ın";
                        case 70:
                            return $"{n}-in";
                        case 0:
                            if (n % 1000 != 0)
                                return $"{n}-ün";
                            else
                                return $"{n}-nin";
                    }
                    break;
            }

            return String.Empty;
        }
    }
}
