namespace Encapsulation
{
    internal class Program
    {
        class Vect
        {
            int[] v;
            int count;                          // senza nulla è private

            public Vect(int value)
            {
                v = new int[value];             // con this. oppure senza lavora con il valore messo dentro dalla chiamata dell'oggetto
                count = 0;
            }
            public bool Add(int value)
            {
                if (count == v.Length)  // vettore utilizzato al 100%
                    // ci vorrebbe una politica di riallocazione
                    v = Realloc(v, v.Length * 2);
                v[count++] = value;
                return true;

                /* ^^^ Equivale a:

                    v[v_count] = value;
                    v_count += 1;
                */
            }
            public bool InsertAt(int index, int value)
            {
                // Elimina il valore v[index] compattando i valori restanti
                // NOTA: deve valere che 0 <= index < v_count
                if (!ShiftRight(index))
                    return false;

                this.v[index] = value;
                return true;
            }
            public void RemoveAt(int index)
            {
                // Elimina il valore v[index] compattando i valori restanti
                // NOTA: deve valere che 0 <= index < v_count
                ShiftLeft(index);
            }
            public void Print()
            {
                for (int i = 0; i < count; ++i)
                {
                    Console.Write($"{v[i]} ");
                }
            }
            public int GetAt(int index)
            {
                return v[index];
            }
            public void BubbleSort()
            {
                for (int i = 0; i < count - 1; i++)
                {
                    for (int j = 0; j < 1 - count; j++)
                    {
                        if (v[j] > v[j + 1])
                            Swap(ref v[j], ref v[j + 1]);
                    }
                }
            }
            public void Append() // Sposta tutti gli elementi del vettore in fondo
            {
                for(int i = 0; i < count; i++)
                {
                    if (v[v.Length - 1 - i] == 0)
                        v[v.Length - 1 - i] = v[i];
                    
                }
            }
            private void Swap(ref int value1, ref int value2)
            {
                int temp = value1;
                value1 = value2;
                value2 = temp;
            }
            private bool ShiftLeft(int index)
            {
                // Elimina il valore v[index] compattando i valori restanti
                // NOTA: deve valere che 0 <= index < v_count

                if (index < 0 || count <= index)
                    return false;

                for (int cnt = 0; cnt < count - index - 1; ++cnt)
                {
                    int i = index + cnt;
                    this.v[i] = this.v[i + 1];
                }

                --count;
                return true;
            }
            private bool ShiftRight(int index)
            {
                // Elimina il valore v[index] compattando i valori restanti
                // NOTA: deve valere che 0 <= index < v_count

                if (index < 0 || count <= index)
                    return false;

                for (int cnt = count - index - 1; cnt >= 0; --cnt)
                {
                    int i = index + cnt;
                    v[i + 1] = v[i];
                }

                ++count;
                return true;
            }
            private int[] Realloc(int[] v, int newLength)
            {
                // NOTA: deve valere che newLength >= v.Length

                int[] newVect = new int[newLength];

                // Copia elemento per elemento
                for (int i = 0; i < v.Length; i++)
                    newVect[i] = v[i];

                return newVect;
            }
        }
        static void Main(string[] args)
        {
            Vect vett = new Vect(1000); // è diventato un oggetto quindi sia dati che codice
            vett.Add(2);
            vett.Add(7);
            vett.Add(10);
            vett.Add(11);
            vett.Add(35);
            vett.Add(40);
            vett.Add(8);
            vett.InsertAt(2, 999);
            vett.RemoveAt(2);
            vett.Print();

            Vect vettore = new Vect(40);
            vettore.Add(2);
            vettore.Add(54);
            vettore.Print();
            vettore.InsertAt(2, 10);
            Console.WriteLine($"{vettore.GetAt(2)} ");

            vett.BubbleSort();
            vett.Append();
            vett.Print();
        }
    }
}