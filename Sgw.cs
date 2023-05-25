namespace РГР_Ч2
{
    internal class Program
    {
        public static double Func(int min, double v, string signature)
        {
            switch (signature){
                case "y":
                    return (1391 * min + 26 * (v - min) + 2704 * v) /27300;
                case "z":
                    return (1391 * (v - min) + 26 * min + 2704 * v)/27300;
                default:
                    return 0;
            }
        }
        public static double OilPumper(double v)
        {
            List<double> mins = new List<double>();
            int count = 0;
            int e = 1;
            while (count < v)
            {
                count += e;
                mins.Add(Func(count, v, "y"));
                mins.Add(Func(count, v, "z"));          
            }
            return mins.Min();   
        }
        static void Main(string[] args)
        {
            int k = 0;
            string input;
            string quite = " ";
            double answer;

            while (quite != "")
            {
                Console.Clear();
                Console.WriteLine("\tВведите объем нефти(м^3), перекачиваемый по маршруту A --> Г");
                Console.WriteLine("\tСправка об авторе --- введите 'author'");
                Console.WriteLine("\tВыход --------------- нажмите enter");
                input = Console.ReadLine();
                switch (input)
                {
                    case "author":
                        Console.Clear();
                        Console.WriteLine("Работу выполнил студент группы МО-221 Зябрев Кирилл Сергеевич.");
                        Console.ReadKey();
                        break;
                    case "":
                        quite = "";
                        break;
                    default:
                        try
                        {
                            Console.Clear();
                            if (k == 9999999)
                                answer = -1;
                            else
                                answer = OilPumper(double.Parse(input));
                            Console.WriteLine("Время перекачки составит {0} условных единиц", Math.Round(answer, 3));
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Ошибка ввода. Проверьте правильность введенных данных.");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
    }
}
