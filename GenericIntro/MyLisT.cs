using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    class MyLisT<T>
    {
        //"T" mainde çağırılırken ne değer verilirse ona göre çalışmasını sağlar...
        T[] items;
        //Constructor...
        public MyLisT()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //Elemanlarımızı geçici bir diziye atıyoruz..
            T[] tempArray = items;
            //eleman sayısını 1 artırmamız lazım...
            items = new T[items.Length + 1];
            //yeni items dizimize geçicideki eski elemanları geri ekliyoruz...
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //Yeni eklenecek itemın nereye ekleneceğini söylüyoruz...
            items[items.Length - 1] = item;
        }
    }
}
