using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Kerem");
            isimler.Add("Gökay");
            isimler.Add("Ahmet");
            isimler.Add("Elif");
            isimler.Add("Büşra");
            Console.WriteLine(isimler.MyProperty);
        }
    }
    class MyList<T>
    {
        T[] _isim;
        T[] _temp;

        public MyList()
        {
            _isim = new T[0];
        }

        public void Add(T item)
        {
            _temp = _isim;
            _isim = new T[_isim.Length + 1];
            for (int i = 0; i < _temp.Length; i++)
            {
                _isim[i] = _temp[i];
            }
            _isim[_isim.Length - 1] = item;
        }

        public int MyProperty
        {
            get { return _isim.Length; }
        }

    }
}
