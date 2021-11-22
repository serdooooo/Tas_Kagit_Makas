
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagıtMakas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Taş");
            Console.WriteLine("2-Kağıt");
            Console.WriteLine("3-Makas");
            int sayacKullanici = 0;
            int sayacBilgisayar = 0;
            basadon: while (true)
            {
                
                Random rnd = new Random();
                int computer = rnd.Next(1, 4);
                bool kullanicikontrol=false;
                int kullanici;
                Console.Write("1/2/3 değer giriniz:");
                kullanicikontrol = int.TryParse(Console.ReadLine(), out kullanici);
                if (!kullanicikontrol)
                {
                    Console.WriteLine("Lütfen sayısal bir değer giriniz.");
                    Console.WriteLine("Sayısal bir değer girmeniz için yönlendiriliyorsunuz...");
                    System.Threading.Thread.Sleep(2000);
                    goto basadon;
                }
                else
                {
                    

                    //bilgisayarın taş seçme durumu
                    if (computer == 1)
                    {
                        Console.WriteLine("Bilgisayarın seçimi: taş");
                        if (kullanici == 1)
                        {
                            Console.WriteLine("Kullanıcının seçimi: taş");
                            Console.WriteLine("Berabere");
                        }
                        else if (kullanici == 2)
                        {
                            Console.WriteLine("Kullanıcının seçimi: kağıt");
                            Console.WriteLine("Kullanıcı kazandı");
                            sayacKullanici++;
                        }
                        else if (kullanici == 3)
                        {
                            Console.WriteLine("Kullanıcının seçimi: makas");
                            Console.WriteLine("Bilgisayar kazandı");
                            sayacBilgisayar++;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış seçim yaptınız");
                            goto basadon;
                        }
                    }

                    //bilgisayarın kağıt seçme durumu
                    else if (computer == 2)
                    {
                        Console.WriteLine("Bilgisayarın seçimi: kağıt");
                        if (kullanici == 1)
                        {
                            Console.WriteLine("Kullanıcının seçimi: taş");
                            Console.WriteLine("Bilgisayar kazandı");
                            sayacBilgisayar++;
                        }
                        else if (kullanici == 2)
                        {
                            Console.WriteLine("Kullanıcının seçimi: kağıt");
                            Console.WriteLine("Berabere");
                        }
                        else if (kullanici == 3)
                        {
                            Console.WriteLine("Kullanıcının seçimi: makas");
                            Console.WriteLine("Kullanıcı kazandı");
                            sayacKullanici++;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış seçim yaptınız");
                            goto basadon;
                        }
                    }
                    //bilgisayarın makas seçme durumu
                    else if (computer == 3)
                    {
                        Console.WriteLine("Bilgisayarın seçimi: makas");
                        if (kullanici == 1)
                        {
                            Console.WriteLine("Kullanıcının seçimi: taş");
                            Console.WriteLine("Kullanıcı kazandı");
                            sayacKullanici++;
                        }
                        else if (kullanici == 2)
                        {
                            Console.WriteLine("Kullanıcının seçimi: kağıt");
                            Console.WriteLine("Bilgisayar kazandı");
                            sayacBilgisayar++;
                        }
                        else if (kullanici == 3)
                        {
                            Console.WriteLine("Kullanıcının seçimi: makas");
                            Console.WriteLine("Berabere");
                        }
                        else
                        {
                            Console.WriteLine("Yanlış seçim yaptınız");
                            goto basadon;
                        }
                    }
                    if (sayacBilgisayar == 3)
                    {
                        goto son;
                    }
                    if (sayacKullanici == 3)
                    {
                        goto son;
                    }
                }
            }
            
            son:if(sayacBilgisayar==3)  Console.WriteLine("Bilgisayar 3'te 3 yaptı ve oyunu kazandı");
            
            else  Console.WriteLine("Kullanıcı 3'te 3 yaptı ve oyunu kazandı");
            

            Console.ReadLine();
        }
    }
}
