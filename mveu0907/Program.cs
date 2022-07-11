using System;
using System.Linq;
using System.Text;

namespace mveu
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            (TimeSpan[], string[])[] timeTable = FillTimeTable();
            //Console.WriteLine("test");            
            PrintTimeTableAtConsole((DayOfWeek)6, timeTable);
            //Console.WriteLine("test");
            
        }


        public static void PrintTimeTableAtConsole(DayOfWeek dayOfWeek, (TimeSpan[], string[])[] timeTable)
        {
            ConsoleColor tempConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = GetConsoleColor(dayOfWeek);

            Console.WriteLine(dayOfWeek.ToString());
            for (int i = 0; i < timeTable[(int)dayOfWeek].Item1.Length; i++)
            {
                Console.WriteLine(timeTable[(int)dayOfWeek].Item1[i] + "  " + timeTable[(int)dayOfWeek].Item2[i]);
            }

            Console.ForegroundColor = tempConsoleColor;

        }

        public static ConsoleColor GetConsoleColor(DayOfWeek dayOfWeek) => dayOfWeek switch
        {
            (>= (DayOfWeek)1) and (<= (DayOfWeek)5) => ConsoleColor.Green,
            ((DayOfWeek)6) or ( (DayOfWeek)0) => ConsoleColor.Red
        };


        public static (TimeSpan[], string[])[] FillTimeTable()
        {
            (TimeSpan[], string[])[] timeTable = new (TimeSpan[], string[])[7];

            timeTable[0].Item1 = new TimeSpan[5] {
                new TimeSpan(8, 45, 0), new TimeSpan(9, 00, 0), new TimeSpan(12, 00, 0),
                new TimeSpan(18, 00, 0), new TimeSpan(19, 00, 0)
            };

            timeTable[0].Item2 = new string[5]
            {
                "Завтрак", "Прогулка с собакой",  "Сон", "Сон ", "Прогулка с собакой"
            };
            //
            timeTable[1].Item1 = new TimeSpan[5] {
                new TimeSpan(8, 45, 0), new TimeSpan(9, 00, 0), new TimeSpan(12, 00, 0),
                new TimeSpan(18, 00, 0), new TimeSpan(19, 00, 0)
            };

            timeTable[1].Item2 = new string[5]
            {
                "Завтрак", "Прогулка с собакой",  "Обед", "Программирование", "Прогулка с собакой"
            };
            //
            timeTable[2].Item1 = new TimeSpan[5] {
                new TimeSpan(8, 45, 0), new TimeSpan(9, 00, 0), new TimeSpan(12, 00, 0),
                new TimeSpan(18, 00, 0), new TimeSpan(19, 00, 0)
            };

            timeTable[2].Item2 = new string[5]
            {
                "Завтрак", "Программирование",  "Обед", "Программирование", "Прогулка с собакой"
            };
            //
            timeTable[3].Item1 = new TimeSpan[5] {
                new TimeSpan(8, 45, 0), new TimeSpan(9, 00, 0), new TimeSpan(13, 00, 0),
                new TimeSpan(18, 00, 0), new TimeSpan(19, 00, 0)
            };

            timeTable[3].Item2 = new string[5]
            {
                "Завтрак", "Учёба",  "Обед", "Спорт", "Прогулка с собакой"
            };
            //
            timeTable[4].Item1 = new TimeSpan[5] {
                new TimeSpan(8, 45, 0), new TimeSpan(9, 00, 0), new TimeSpan(12, 00, 0),
                new TimeSpan(18, 00, 0), new TimeSpan(19, 00, 0)
            };

            timeTable[4].Item2 = new string[5]
            {
                "Завтрак", "Прогулка с собакой",  "Работа", "Работа ", "Прогулка с собакой"
            };
            //
            timeTable[5].Item1 = new TimeSpan[5] {
                new TimeSpan(8, 45, 0), new TimeSpan(9, 00, 0), new TimeSpan(12, 00, 0),
                new TimeSpan(18, 00, 0), new TimeSpan(19, 00, 0)
            };

            timeTable[5].Item2 = new string[5]
            {
                "Завтрак", "Прогулка с собакой",  "Учёба", "Работа", "Прогулка с собакой"
            };
            //
            timeTable[6].Item1 = new TimeSpan[5] {
                new TimeSpan(8, 45, 0), new TimeSpan(9, 00, 0), new TimeSpan(12, 00, 0),
                new TimeSpan(18, 00, 0), new TimeSpan(19, 00, 0)
            };

            timeTable[6].Item2 = new string[5]
            {
                "Завтрак", "Учёба",  "Сон", "Программирование ", "Прогулка с собакой"
            };
            return timeTable;
        }





        /// <summary>
        /// считает кол-во слогов в слове
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int CountSyll(string word)
        {
            string[] vowel = new string[] { "у", "е", "ы", "а", "о", "э", "и", "ё", "ю", "я" };

            int result = 0;

            word.ToCharArray().ToList().ForEach(x =>
            {
                if (vowel.Contains(x.ToString().ToLower()))
                    result++;
            });

            return result;
        }

    }
}