using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Cezar
    {

        public static string Encrypt(byte[] arr, int key)
        {
            string encryptString;
            byte[] mass = new byte[arr.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = (byte)(arr[i] ^ key);
            }
            encryptString = Encoding.UTF8.GetString(mass);
            return encryptString;
        }
        public static string DecryptWithKey(string encryptString, int key)
        {
            string decryptString;
            byte[]arr = Encoding.UTF8.GetBytes(encryptString);
            decryptString = Encrypt(arr, key);
            return decryptString;
        }
    }
}
