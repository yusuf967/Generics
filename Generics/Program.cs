
List<string> sehirler=new List<string>();

sehirler.Add("Elazığ");
sehirler.Add("İstanbul");
Console.WriteLine(sehirler.Count);

MyList<string> sehirler2 = new MyList<string>(); //Kendi oluşturduğumuz Generic Class ımız.
sehirler2.Add("Elazığ");
sehirler2.Add("İstanbul");
sehirler2.Add("Ankara");
Console.WriteLine(sehirler2.Count);

class MyList<T> //Generic Class
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0]; // MyList her başladığında 0 elemanlı olacak.
    }

    public void Add(T item)
    {
        _tempArray = _array; // _array in içindeki elemanları kaybetmemek için farklı bir array e saklıyoruz.
        _array= new T[_array.Length+1];//_array e eleman ekleyeceğimiz için array uzunluğunu bir artırıyoruz.
        for(int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];  //sakladığımız elemanları eleman sayısını artırdığımız -array e sırasıyla artırıyoruz.
        }

        _array[_array.Length - 1] = item; // ekleyeceğimiz elemanı _array in son index ine atıyoruz.
    }

    public int Count { get { return _array.Length; } }  // Array in uzunluğunu döndüren fonksiyonumuz.
}