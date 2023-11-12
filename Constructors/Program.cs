internal class Program
{
    private static void Main(string[] args)
    {
        // Constructor bir sınıfı new'lediğimiz zaman çalışan bir bloktur.
        // Yani bir class ilk kez çalıştığı zaman bir kere çalışır ve bir daha çalışmaz.
        // Yapıcı bloktur. Class'ı ilk kez çalıştırdığımız zaman çalışan bloktur.
        // operasyon class'ları ve özellik class'larının her ikisinde de kullanılır.


        // Customer customer = new Customer();


        // Yukarıda görüldüğü üzere new Customer() 'da parantez vardır ve bu bir metot gibi çalışır.
        // Yani aslında constructor bir metot gibi çalışır, aşağıya ctor yazıp çıkan public Customer()'ı yazmasak da
        // her new'lemede default benzer kod arkada çalışır.
        // Yazdıysak bizim yazdığımız çalışır, yazmadıysak aşağıdaki default constructor çalışır;


        //  public Customer()
        //  {
        //
        //  }


        // Keza yukarıdaki new'leme akabinde aşağıdaki public Customer()
        // blogunun içine  Console.WriteLine("Yapıcı blok çalıştı"); yazarsak çalıştığını terminalden görebiliriz.
        // kısaca her new'leme yaptığımızda arkada default contructor bloğu çalışır.

        // constructor'a 4 adet parametre ekleyince bu sefer aşağıdaki gibi bir hata alıyoruz. İçine parametre girmemizi istiyor.
        // peki hem aşağıdaki gibi hem de parametreli kullanmak isteseydik nasıl olurdu?
        // çözümü çok basit parametresiz default bir constructor daha açardık bir metot gibi.
        // not aşağıda süslü parantez öncesi normal parantez açabiliriz de açmayabiliriz de çok önemli değil.


        Customer customer1 = new Customer { Id = 1, FirstName = "Özlem", LastName = "Belörenoğlu",City = "Ankara"};


        // aşağıdaki gibi new Customer()  sanki bir fonksiyonmuş gibi, içine de ilgili verileri yazabiliyoruz. 
        // ancak"'Customer' does not contain a constructor that takes 4 arguments" hatası veriyor
        // Çünkü constructor'ı default 0 argumentli alıyor.
        // Nihayetinde hocanın vermek istediği mantık şu:
        // Constructor'lar da metot gibi çalışırlar.Bu nedenle metotlara parametre geçebiliyor olmalıyız.
        // Constructor default 0 argumentli olduğundan aşağıdaki gibi yazmak istersek,
        // constructor'a da tıpkı metot yapar gibi parametresini vermeliyiz.


        Customer customer2 = new Customer(2,"Mustafa","Emir","İstanbul"); // aşağıya parametreleri ekledikten sonra hata almıyoruz.

        Console.WriteLine(customer2.FirstName); 

        // işte contructor'a sadece parametre eklersek  ve iç kod kısmını gerektiği gibi yazmaksak, bu sefer burayı çalıştıramayız.
        // Sadece adını, soyadını vs isteyemeyiz.
        // çünkü sadece parametre olarak hepsini verdik.
        // bu kodu çalıştırabilmek için aşağıda parametreli constructor'ın içini aşağıdaki gibi doldurmamız lazım.



        Method(1, "özlem", "belörenoğlu", "ankara");
        //Örn metot, metot'ta verilen parametreleri girmemiz gerekir.


        Customer customer3 = new Customer();
        customer3.Id = 3;
        customer3.FirstName = "Ali"; 
    
    }

    // örn metot
    static void Method(int id, string firstName, string lastName, string city)
    {

    }
}
 class Customer

{   
    // Default Constructor'dır aşağıdaki
    // default'ta public Customer() boş yani 0 argument'li.
    // hem parametreli hem parametresiz kullanmak istersek constructor'ı hem parametreli olanı(aşağıdaki 2. constructor yapısı) eklemeliyiz.
    // hem de buradaki gibi default olanı yani parametresiz olanı eklemeliyiz.
    public Customer()
    {
        
    }

    // Yukarıdaki parametreli constructor kodumuzu çalıştırmak için aşağıdaki 4 argumenti ekledik.
    // Kısaca metot gibi içine parametre ekleyebiliriz.
    public Customer(int id, string firstName, string lastName, string city)

    {
        Console.WriteLine("Yapıcı blok çalıştı");

        // aşağıdakileri yazmazsak "costumer3.FirstName" gibi ifadeleri çağıramayız yukarıda.

        Id = id;

        FirstName = firstName;

        LastName = lastName;

        City = city;

    }
    public int Id{ get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string City { get; set; }
}