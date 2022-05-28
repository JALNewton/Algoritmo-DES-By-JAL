using System;
using System.Text;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criptografando texto!
            string text = "ByJoseph";
            byte[] iv = new byte[8] { 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0xFF , 0xAA};
            byte[] key = new byte[8] { 0x0C, 0x0D, 0x0A, 0x0F, 0xFF, 0x0F, 0xFF , 0xAA};
            

            byte[] resultEncrypted = DESEncryption.EncryptData(ASCIIEncoding.ASCII.GetBytes(text), iv, key);

            Console.WriteLine(string.Format("texto: {0} \n bytes encrypted: {1}",text, BitConverter.ToString(resultEncrypted).Replace("-", " ")));

            byte[] resultdecrypted = DESEncryption.DecryptData(resultEncrypted, iv, key);

            Console.WriteLine(string.Format("texto: {0} \n bytes decrypted: {1}",text, BitConverter.ToString(resultdecrypted).Replace("-", " ")));
            Console.WriteLine(string.Format("texto: {0} \n texto decrypted: {1}",text, ASCIIEncoding.ASCII.GetString(resultdecrypted)));

            
        }
    }
}