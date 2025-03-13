// See https://aka.ms/new-console-template for more information
using System;
using modul4_103022300050;



public class Program
{
    public static void Main()
    {
        KodeProduk kodeProduk = new KodeProduk();
        string produkElec = Console.ReadLine();
        string kodProduk = kodeProduk.getKodeProduk(produkElec);
        Console.WriteLine(kodProduk);
    }
}
