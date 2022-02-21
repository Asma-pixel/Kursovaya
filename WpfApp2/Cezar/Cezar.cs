using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string alfabet;
            string resultString = "";
            if (lang == "RU")
                alfabet = allRuAlfabet;
            else 
                alfabet = allEnAlfabet;

            for (int i = 0; i < encrypyptString.Length; i++)
            {
                resultString += Repl(encrypyptString.Substring(i,1), key, alfabet);
            }
                
      
            return resultString;
        }
        public static string DecryptWithKey(string decrypyptString, int key, string lang)
        {
            string resultString = Encrypt(decrypyptString, -key, lang);
            return resultString;
        }
    }
}
