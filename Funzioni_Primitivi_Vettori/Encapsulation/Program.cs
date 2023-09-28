namespace Encapsulation
{
    internal class Program
    {
        class Vect
        {
            int[] v;
            int count;                          // Senza nulla è private

            public Vect(int value)
            {
                v = new int[value];             // Con this. oppure senza lavora con il valore messo dentro dalla chiamata dell'oggetto
                count = 0;
            }
            public bool Add(int value)
            {
                if (count == v.Length)          // Vettore utilizzato al 100%
                                                // Ci vorrebbe una politica di riallocazione
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
                if (this.count == this.v.Length)  // vettore utilizzato al 100%
                {
                    // FIX : TODO : qua ci vorrebbe una "politica di riallocazione"
                    //              ad esempio dei raddoppi oppure un +10%
                    int new_length = this.v.Length + 1;
                    this.v = Realloc(this.v, new_length);
                }
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
            public void PrintAll()
            {
                for (int i = 0; i < count; ++i)
                {
                    Console.Write($"{v[i]} ");
                }
            }
            public bool GetAt(int index, out int value)
            {
                if( index < 0 || index > count )
                {
                    value = v[index];
                    return true;
                }
                value = 0;
                return false;
            }
            public void BubbleSort()
            {
                for (int i = 0; i < count - 1; i++)
                {
                    for (int j = 0; j < count - 1; j++)
                    {
                        if (v[j] > v[j + 1])
                            Swap(ref v[j], ref v[j + 1]);
                    }
                }
            }
            public void Append(Vect vect) // Aggiunge tutti i valori di un vettore a un altro vettore
            {
                if (this == vect)  // evita la Append() di un vettore su se stesso
                    return;

                if (count + vect.count > v.Length)
                    v = Realloc(v, count + vect.count);
                
                for(int i = 0; i < vect.count; i++)
                    Add(vect.v[i]);
            }
            private void Swap(ref int value1, ref int value2)
            {
                //Swaps values
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

                if (index < 0 || count < index)
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
            Vect vett = new Vect(1); // è diventato un oggetto quindi sia dati che codice
            vett.Add(2);
            vett.Add(7);
            vett.Add(10);
            vett.Add(11);
            vett.Add(35);
            vett.Add(40);
            vett.Add(8);
            vett.InsertAt(2, 999);
            vett.RemoveAt(1);
            vett.PrintAll();

            Vect vettore = new Vect(40);
            vettore.Add(2);
            vettore.Add(54);
            vettore.PrintAll();
            vettore.InsertAt(1, 10);
            int value;
            vettore.GetAt(2, out value);
            Console.WriteLine($"{value} ");
			vettore.Add(13);

            vett.Append(vettore);
			vett.BubbleSort();
			vett.PrintAll();
            // Da provare
            vett.Append(vett);
            vett.BubbleSort();
            vett.PrintAll();
        }
    }
}