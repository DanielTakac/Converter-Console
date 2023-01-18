using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter {

    public class ColorText {

        public static void WriteLineColor(string input, ConsoleColor color) {

            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            Console.WriteLine(input);

            Console.ForegroundColor = currentColor;

        }

        public static void WriteColor(string input, ConsoleColor color) {

            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            Console.Write(input);

            Console.ForegroundColor = currentColor;

        }

        public static string ReadLineColor(ConsoleColor color) {

            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            string output = Console.ReadLine();

            Console.ForegroundColor = currentColor;

            return output;

        }

        public static string ReadColor(ConsoleColor color) {

            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            string output = Console.Read().ToString();

            Console.ForegroundColor = currentColor;

            return output;

        }

        public static char ReadKeyColor(ConsoleColor color) {

            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            char output = Console.ReadKey().KeyChar;

            Console.ForegroundColor = currentColor;

            return output;

        }

    }

}
