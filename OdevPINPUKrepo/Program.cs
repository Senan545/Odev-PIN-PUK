using System;

namespace OdevPINPUKrepo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\tSenan'ın Ödevi\n");
            int dogruPIN = 1996;
            int dogruPUK = 1405;
            int girilenPIN = 0;
            int girilenPUK = 0;

            for (int PINhakki = 2; PINhakki >= 0; PINhakki--)
            {
                Console.Write("Telefonunu açmak için PIN Kodunu Giriniz: ");
                girilenPIN = int.Parse(Console.ReadLine());

                if (girilenPIN != dogruPIN)
                {
                    if (PINhakki == 0)
                    {
                        Console.Write("Yanlış PIN Girdiniz, PIN Hakkınız Kalmadı.\n");

                       
                    }
                    else
                    {
                        Console.WriteLine("Yanlış PIN Girdiniz. {0} Hakkınız Kaldı\n", PINhakki);
                    }
                }
                else
                {
                    break;
                }
            }
            if (girilenPIN == dogruPIN || girilenPUK == dogruPUK)
            {
                Console.WriteLine("Telefon Açılıyor...");
            }
            else
            {
                Console.WriteLine("\nTelefonu Açmak için Müşteri Hizmetlerine Gidiniz.");
            }

        }
    }
}
