using Microsoft.VisualBasic;
using System;
using System.Text;

namespace Converter {

    public class Functions {

        static Dictionary<char, string> morseCodes = new Dictionary<char, string>() {
            { 'A', ".-" },
            { 'B', "-..." },
            { 'C', "-.-." },
            { 'D', "-.." },
            { 'E', "." },
            { 'F', "..-." },
            { 'G', "--." },
            { 'H', "...." },
            { 'I', ".." },
            { 'J', ".---" },
            { 'K', "-.-" },
            { 'L', ".-.." },
            { 'M', "--" },
            { 'N', "-." },
            { 'O', "---" },
            { 'P', ".--." },
            { 'Q', "--.-" },
            { 'R', ".-." },
            { 'S', "..." },
            { 'T', "-" },
            { 'U', "..-" },
            { 'V', "...-" },
            { 'W', ".--" },
            { 'X', "-..-" },
            { 'Y', "-.--" },
            { 'Z', "--.." },
            { '0', "-----" },
            { '1', ".----" },
            { '2', "..---" },
            { '3', "...--" },
            { '4', "....-" },
            { '5', "....." },
            { '6', "-...." },
            { '7', "--..." },
            { '8', "---.." },
            { '9', "----." },
            { '.', ".-.-.-" },
            { ',', "--..--" },
            { '?', "..--.." },
            { '\'', ".----." },
            { '!', "-.-.--" },
            { '/', "-..-." },
            { '(', "-.--." },
            { ')', "-.--.-" },
            { '&', ".-..." },
            { ':', "---..." },
            { ';', "-.-.-." },
            { '=', "-...-" },
            { '+', ".-.-." },
            { '-', "-....-" },
            { '_', "..--.-" },
            { '"', ".-..-." },
            { '$', "...-..-" },
            { '@', ".--.-." }
        };

        public static string HashString(string plainText) {

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);

            return System.Convert.ToBase64String(plainTextBytes);

        }

        public static string UnhashString(string base64EncodedData) {

            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);

            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);

        }

        public static string StringToBinary(string data) {

            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray()){

                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            
            }
            
            return sb.ToString();
        
        }

        public static string BinaryToString(string data) {

            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8){

                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            
            }
            
            return Encoding.ASCII.GetString(byteList.ToArray());
        
        }

        public static string StringToHex(string data) {

            byte[] ba = Encoding.Default.GetBytes(data);

            var hexString = BitConverter.ToString(ba);

            hexString = hexString.Replace("-", "");

            return hexString;

        }

        public static string HexToString(string data) {

            byte[] bb = Enumerable.Range(0, data.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(data.Substring(x, 2), 16))
                     .ToArray();
            return Encoding.ASCII.GetString(bb);

        }

        public static string StringToMorse(string data) {

            string text = data;
            
            string newText = string.Empty;

            foreach (char character in text) {

                char uppercaseChar = char.ToUpper(character);

                if (uppercaseChar == ' ') {

                    newText += " / ";

                } else if (morseCodes.ContainsKey(uppercaseChar)) {

                    newText += morseCodes[uppercaseChar] + " ";

                } else {

                    ColorText.WriteLineColor($"\n'{uppercaseChar}' can't be converted to morse code", ConsoleColor.Red);

                    return null;

                }

            }

            return newText;

        }

        public static string MorseToString(string data) {

            string newText = string.Empty;

            // Splits the string into words and trims the spaces
            string[] words = (from x in data.Split('/') select x.Trim()).ToArray();

            foreach (string word in words) {

                string[] letters = word.Split(' ');

                foreach (var letter in letters) {

                    bool isValid = letter.All(c => c == '.' || c == '-' || c == ' ');

                    if (!isValid) {

                        ColorText.WriteLineColor($"\n'{letter}' is not a valid morse code character", ConsoleColor.Red);

                        return null;

                    }

                    var key = morseCodes.FirstOrDefault(x => x.Value == letter).Key;

                    newText += key;

                }

                newText += " ";

            }

            return newText;

        }

    }

}
