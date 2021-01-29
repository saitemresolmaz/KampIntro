using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyDictionary<T1,T2>
    {
        T1[] keys;
        T2[] values;
        public MyDictionary()   //ctor kısayoluyla Constructor oluşturduk. MtList classı new'lenirse otomatik çalışır.
        {
            keys = new T1[0];
            values = new T2[0];
        }
        public void Add(T1 key, T2 value)
        {
            T1[] tempArrayKeys = keys;
            T2[] tempArrayValues = values;
            keys = new T1[keys.Length + 1];
            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                keys[i] = tempArrayKeys[i];
            }
            keys[keys.Length - 1] = key;
          //  -----------------------------------------------
            values = new T2[values.Length + 1];
            for (int i = 0; i < tempArrayValues.Length; i++)
            {
                values[i] = tempArrayValues[i];
            }
            values[values.Length - 1] = value;


        }

        public int LengthKey
        {
            get { return keys.Length; }
        }
        public int LengthValue
        {
            get { return values.Length; }
        }
        public T1[] Keys
        {
            get { return keys; }
        }
        public T2[] Values
        {
            get { return values; }
        }

    }

}
