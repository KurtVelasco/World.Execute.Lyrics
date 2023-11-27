using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace World.Execute.Lyrics_Me_
{
    public class TextAnimation
    {
        public static void SlowType(string Text,string Color,int DelayMiliSeconds)
        {
            TimeSpan delay = TimeSpan.FromMilliseconds(DelayMiliSeconds);
            Console.ForegroundColor = ConsoleColor.Green;
            switch (Color)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            Console.Write("[Console] ");
            foreach (char c in Text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.ResetColor();
        }

        public static char[] ShuffleCharacters(string Unshuffled_Word)
        {
            string word = Unshuffled_Word;
            char[] charArray = word.ToCharArray();
            Random random = new Random();

            for (int i = charArray.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }
            return charArray;
        }

        public static void AnimateText(string Animate_Word, string Constant_Word, string Color, int Animate_Loop)
        {
            Console.Write("\r");
            for (int a = 0; a < Animate_Loop; a++)
            {
                string cc = new string(ShuffleCharacters(Animate_Word));
                Console.Write(Constant_Word + "" + cc + "\r");
                Thread.Sleep(50);
            }
            switch (Color)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            Console.Write("\r" + Constant_Word + " " + Animate_Word);    
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void ReadFile(string FileName)
        {
            string filePath = FileName;
            try
            {
                using (StreamReader reader = new StreamReader(filePath + ".txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        Thread.Sleep(5);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file could not be found.");
            }
            catch (IOException)
            {
                Console.WriteLine("An error occurred while reading the file.");
            }
        }

        public static void SimulateLoading(string Final_Message, int Progress_SpeedMili, int Total_BarAmount)
        {
            int delay = Progress_SpeedMili;
            string[] phrases = { "Applying AI", "Adding Stars", "Giving Weather" };
            for (int i = 0; i <= Total_BarAmount; i++)
            {
                string progressBar = "[" + new string('#', i) + new string('-', Total_BarAmount - i) + "]";
                Console.Write("\r{0} {1}%", progressBar, i * 100 / Total_BarAmount);
                Thread.Sleep(delay);
            }
            Console.Write(Final_Message + '\n');
        }
    }
}
