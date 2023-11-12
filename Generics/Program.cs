internal class Program
{
    private static void Main(string[] args)
    {
        //Generic'te içine hangi tipi verirsek o tipte çalışır

        // List<> de bir class'tır
        List<string> sehirler = new List<string>();
        sehirler.Add("ankara");
        sehirler.Add("samsun");
        sehirler.Add("istanbul");
        sehirler.Add("izmir");
        Console.WriteLine(sehirler.Count);  // Count burada property'dir.
        



        MyList<string> sehirler2 = new MyList<string>();
        sehirler2.Add("ankara");
        sehirler2.Add("manisa");
        sehirler2.Add("aydın");
        sehirler2.Add("muğla");
        sehirler2.Add("trabzon");
        Console.WriteLine(sehirler2.Count); // buradaki Count aşağıda bizim kendi ürettiğimiz property'dir




        // T generic type i oluşturuyor burada ve ne tipte veri verirsek onu çalıştırıyor. 

        MyList<int> rakamlar = new MyList<int>();
        rakamlar.Add(1965);


    }
}


class MyList<T> //Generic Class'tır burası
{
    T[] _array;
    T[] _tempArray;


    public MyList()
    {
        _array = new T[0]; 
    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length+1]; // buradaki array kaç adetle sınırlı olduğumuzu gösterir
        for(int i=0; i< _tempArray.Length; i++) 
        {
            _array[i] = _tempArray[i];
        }

        _array[_array.Length-1] = item; // burası index i gösterir.

        // burada her eklemede new'lersek daha önceki veriler uçacaktır.
        // veriler uçmadan önce geçici bir array'de verilerimizi tutmamız daha sonra ekleme yapıldıktan sonra
        // geçici array'dan ilgili verileri iade almamız lazım.
    }

    public int Count
    {
       get { return _array.Length; }
    
    }

}