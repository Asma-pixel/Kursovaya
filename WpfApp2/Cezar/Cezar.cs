

using System.Linq;

namespace WpfApp2
{
    public class Cezar
    {
        private static string alfabetRuCapital = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private static string alfabetEnCapital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string alfabetRu = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private static string alfabetEn = "abcdefghijklmnopqrstuvwxyz";
        private static string alfabetNumbers = "0123456789";
        private static string alfabetSybols = @"!\#$%^&*()+=-_'?.,|/`~№:;@[]{}";
        private static string spaceSymbol = " ";
        private static string allRuAlfabet = alfabetRuCapital + alfabetRu + alfabetNumbers + alfabetSybols + spaceSymbol;
        private static string allEnAlfabet = alfabetEnCapital + alfabetEn + alfabetNumbers + alfabetSybols + spaceSymbol;
        private static string Repl(string s, int key, string alfabet)
        {
            int pos = alfabet.IndexOf(s);
            pos = (pos + key) % alfabet.Length;
            if (pos < 0) pos += alfabet.Length;
            return alfabet.Substring(pos, 1);
        }
        public static string Encrypt(string encrypyptString, int key, string lang)
        {

            string tempEncrypt = encrypyptString.Trim();
            string alfabet;
            string resultString = "";
            if (lang == "RU")
                alfabet = allRuAlfabet;
            else 
                alfabet = allEnAlfabet;

            for (int i = 0; i < tempEncrypt.Length; i++)
            {
                resultString += Repl(tempEncrypt.Substring(i,1), key, alfabet);
            }
      
            return resultString;
        }
        public static string DecryptWithKey(string decrypyptString, int key, string lang)
        {
            string tempDecrypt = decrypyptString.Trim();
            string resultString = Encrypt(decrypyptString, -key, lang);
            return resultString;
        }
        public static string DecryptWithoutKey(string decrypyptString, string lang)
        {
            int key = 0;
            string symbol = "";
            string resultString = "'";
            symbol = decrypyptString.GroupBy(c => c).OrderByDescending(g => g.Count()).First().Key.ToString();
            if (symbol == " ")
            {
                symbol = "S";
            }
            /*if (lang == "RU")
                key = allRuAlfabet.IndexOf("о") - allRuAlfabet.IndexOf(symbol);
            else
                key = allEnAlfabet.IndexOf("e") - allEnAlfabet.IndexOf(symbol);
            resultString = Cezar.Encrypt(decrypyptString, key, lang);*/
            return resultString += symbol +"'";
        }
    }
}
