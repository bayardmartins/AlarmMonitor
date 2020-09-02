using System;
using System.Security.Cryptography;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Byte[] bytes = new Byte[] { (byte)17 , (byte)45, (byte)15, (byte)36 };
            Byte[] ct = new Byte[] { bytes[1], bytes[2] };
            int conta = BitConverter.ToInt16(ct, 0);
            Console.Write(conta);
        }
    }
}
