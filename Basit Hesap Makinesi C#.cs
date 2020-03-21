using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("1. Sayıyı Giriniz :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2. Sayıyı Giriniz :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Toplama İşlemi İçin '+' Tuşuna Basınız");
        Console.WriteLine("Çıkarma İşlemi İçin '-' Tuşuna Basınız");
        Console.WriteLine("Çarpma İşlemi İçin '*' Tuşuna Basınız");
        Console.WriteLine("Bölme İşlemi İçin '/' Tuşuna Basınız");
        char secim = Convert.ToChar(Console.ReadLine());
        switch (secim)
        {
            case '+':
                Console.WriteLine("Toplama İşleminin Sonucu : {0}", sayi1 + sayi2);
                break;
            case '-':
                Console.WriteLine("Çıkarma İşleminin Sonucu : {0}", sayi1 - sayi2);
                break;
            case '/':
                Console.WriteLine("Bölme İşleminin Sonucu : {0}", sayi1 / sayi2);
                break;
            case '*':
                Console.WriteLine("Çarpma İşleminin Sonucu : {0}", sayi1 * sayi2);
                break;
            default:
                Console.WriteLine("Hatalı Bir Tuşa Bastınız");
                break;



        }
        Console.ReadKey();
    } }
    
