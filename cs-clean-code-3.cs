using SoftwareQuiz.SampleCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareQuiz.SampleCode
{
    public class MyClass
    {
        public string strMyString;
        public int i;
        private readonly byte[] Key;
        private readonly byte[] IV;

        public MyClass()
        {
            Key = Encoding.ASCII.GetBytes("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
            IV = Encoding.ASCII.GetBytes("a0b1c2d3e4f6gh78j9K0L1M2N3O4P5Q6R7S8T9U0V1W2X3Y4Z5");
        }

        public int myMethod(int a, int b)
        {
            var SumValue = a + b;
            return SumValue;
        }

        /* Obsolete. Use Logger.LogText(string text) instead.
        public void LogText(string text)
        {
            // Implementation omitted.
        }*/

        public double Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        public string security(string plainText)
        {
            try
            {
                byte[] encrypted;
                using (AesManaged aes = new AesManaged())
                {
                    ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                    using (MemoryStream ms = new MemoryStream())
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
                Console.WriteLine($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");
                using (AesManaged aesm = new AesManaged())
                {
                    ICryptoTransform decryptor = aesm.CreateDecryptor(Key, IV);
                    using (MemoryStream ms = new MemoryStream(encrypted))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cs))
                                plainText = reader.ReadToEnd();
                        }
                    }
                }
                Console.WriteLine($"Decrypted data: {plainText}");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.ReadKey();
            return plainText;
        }

        public void BreFlowControlExample(BusinessRuleException bre)
        {
            switch (bre.Message)
            {
                case "OutOfAcceptableRange":
                    DoOutOfAcceptableRangeWork();
                    break;
                default:
                    DoInAcceptableRangeWork();
                    break;
            }
        }

        public void BetterFlowControlExample(bool isInAcceptableRange)
        {
            if (isInAcceptableRange)
                DoInAcceptableRangeWork();
            else
                DoOutOfAcceptableRangeWork();
        }

        private void DoOutOfAcceptableRangeWork()
        {
            Console.WriteLine("OutOfAcceptableRange()");
        }

        private void DoInAcceptableRangeWork()
        {
            Console.WriteLine("DoInAcceptableRangeWork()");
        }
    }
}
