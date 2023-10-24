internal class Program
{
    private static void Main(string[] args)
    {

        //int, decimal, float, enum, boolean value types tır.
        // bunların değeri stack'te tutulur.
        int sayi1 = 10;
        int sayi2 = 20;

        sayi1 = sayi2;

        sayi2 = 100;

        Console.WriteLine("sayi 1: {0}", sayi1);
        Console.WriteLine("sayi 1: " + sayi1); // iki türlü de yazım doğrudur. 

        // burada cevap 10 dur


        // arrays, classes, interfaces... bunlar reference types tır.
        // burada stack'e ek olarak Heap devreye girer. Stack'te adrese ilişkin veri tutulur. adressin içeriği yani değerler de heap'te tutulur.
        // stack'te işaret edilen adrese heap'e gidildiğinde orada hangi değer varsa o dikkate alınır. 
        // aşağıda en son sayilar2'nin referans değeri atandığından artık sayilar1 in heapteki değerleri silinir çünkü o değerleri tutan kimse kalmamıştır.

        int[] sayilar1 = new int[] { 1, 2, 3 };
        int[] sayilar2 = new int[] { 10, 20, 30 };

        sayilar1 = sayilar2;

        sayilar2[0] = 1000;

        Console.WriteLine("sayilar1[0] " + sayilar1[0]);

        // burada cevap 10 değil 1000 dir çünkü bu bir dizidir ve diziler value type değil reference type tır,


        
    }
}