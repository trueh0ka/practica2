namespace практическая_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("Выберите программу, которую вы хотите запустить:" +
                "\n1. Угадай число" +
                "\n2. Таблица умножения" +
                "\n3. Вывод делителей числа" +
                "\n4. Закрыть программу");
                choose = Int32.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    GuessTheNumber();
                }
                if (choose == 2)
                {
                    Tablica();
                }
                if (choose == 3)
                {
                    Dividers();
                }
                if (choose > 4)
                {
                    Console.WriteLine("В выборе нет такого числа)");
                }
            }
            while (choose != 4);
        }
        static void GuessTheNumber()
        {
            Console.WriteLine("Угадайте число от 0 до 100!");
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            int number;
            do
            {
                number = Int32.Parse(Console.ReadLine());
                if (number > value)
                {
                    Console.WriteLine("Надо меньше");
                }
                else
                {
                    Console.WriteLine("Надо больше");
                }
                if (number == value)
                {
                    Console.WriteLine("Угадал!");
                }
            }
            while (number != value);
        }
        static int[,] Tablica()
        {
            int[,] matrica = new int[10, 10];
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    matrica[i, j] = i * j;
                }
            }
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
            return (matrica);
        }
        static int Dividers()
        {
            Console.WriteLine("Введите ваше число:");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ответ:");
            for (int i = 1; i <= number2; i++)
            {
                if (number2 % i == 0)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();
            return (number2);
        }
    }
}