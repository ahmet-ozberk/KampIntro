using System;
using System.Collections.Generic;
using System.Text;

namespace Dicts
{
    class MyDict<K, L>
    {
        Dictionary<K, L> MyDictionary = new Dictionary<K, L>();

        public void Ekle(K Anahtar,L Deger)
        {
            MyDictionary.Add(Anahtar,Deger);
        }
        public int Boyut
        {
            get { return MyDictionary.Count; }
        }

    }
}
