internal class Program
{
    private static void Main(string[] args)
    {

        // int, decimal, float, enum, boolean value types tır.
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

        Person person1 = new Person();
        Person person2 = new Person();
        person1.FirstName = "Engin";
        person2 = person1;

        person1.FirstName = "Derin";

        Console.WriteLine(person2.FirstName); // Derin yazar referans değer nedeniyle


        Customer customer = new Customer();
        Employee employee = new Employee();
        employee.FirstName = "Veli";

        Person person3 = customer;
        customer.FirstName = "Salih";

        Console.WriteLine(person3.FirstName); // Salih yazar referans değer nedeniyle

        customer.FirstName = "Ahmet"; //Ahmet olur.

        // yukarıda Person person3 e customer'ı atadığımızdan Person base class'ındaki propert'ler çıkar.
        // Customer class'ında yer alan CreditCard property'si çıkmaz.
        // person3'ün CreditCardNumber property'sini istiyorsak Customer class ı ile boxing yapmalıyız aşağıdaki gibi.

        Console.WriteLine(((Customer)person3).CreditCardNumber);

        //  Person customer2 = new Customer();
        //  Person employee2 = new Employee();

        PersonManager personManager = new PersonManager();
        personManager.Add(person3);
        personManager.Add(employee);
    }

    // Base class : Person'dır. Inheritance edilen class'tır.
    class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    class Customer : Person // Person'ı inherit eden class'tır.
    {
        public int CreditCardNumber { get; set; }
    }

    class Employee : Person // Person'ı  inherit eden class'tır.
    {
        public int EmployeeNumber { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person) 
        // diyelim ki veri tabanına bir ekleme işlemi yapacağız.
        // Buraya Customer veya Employee gönderirsek sadece bu class'lardan biriyle çalışabiliriz.
        // Person'ı göndererek her iki yani Customer ve Employee ile çalışabiliriz.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}