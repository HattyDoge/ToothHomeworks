namespace Encapsulation
{
    internal class Program
    {
        struct Vett
        {
            int[] v;
            int count;                          // senza nulla è private

            public void Vett_Inizialize(int value)
            {
                v = new int[value];             // con this. oppure senza lavora con 
                this.count = 0;
            }
            public bool Vett_Add(int value)
            {
                if (this.count == this.v.Length)  // vettore utilizzato al 100%
                    return false;

                this.v[this.count++] = value;
                return true;

                /* ^^^ Equivale a:

                    v[v_count] = value;
                    v_count += 1;
                */
            }
            public bool Vett_InsertAt(int index, int value)
            {
                // Elimina il valore v[index] compattando i valori restanti
                // NOTA: deve valere che 0 <= index < v_count
                if (!Vett_ShiftRight(index))
                    return false;

                this.v[index] = value;
                return true;
            }
            public void Vett_RemoveAt(int index)
            {
                // Elimina il valore v[index] compattando i valori restanti
                // NOTA: deve valere che 0 <= index < v_count
                Vett_ShiftLeft(index);
            }
            private bool Vett_ShiftLeft(int index)
            {
                // Elimina il valore v[index] compattando i valori restanti
                // NOTA: deve valere che 0 <= index < v_count

                if (index < 0 || this.count <= index)
                    return false;

                for (int cnt = 0; cnt < this.count - index - 1; ++cnt)
                {
                    int i = index + cnt;
                    this.v[i] = this.v[i + 1];
                }

                --this.count;
                return true;
            }
            private bool Vett_ShiftRight(int index)
            {
                // Elimina il valore v[index] compattando i valori restanti
                // NOTA: deve valere che 0 <= index < v_count

                if (index < 0 || this.count <= index)
                    return false;

                for (int cnt = this.count - index - 1; cnt >= 0; --cnt)
                {
                    int i = index + cnt;
                    this.v[i + 1] = this.v[i];
                }

                ++this.count;
                return true;
            }
            private int[] Vett_Realloc(int[] v, int newLength)
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
            Vett vett = new Vett(); // è diventato un oggetto quindi sia dati che codice
            vett.Vett_Inizialize(1000);
            vett.Vett_Add(2);
            vett.Vett_Add(7);
            vett.Vett_Add(10);
            vett.Vett_Add(11);
            vett.Vett_Add(35);
            vett.Vett_Add(40);
            vett.Vett_Add(8);
            vett.Vett_InsertAt(2, 999);
            vett.Vett_RemoveAt(2);

            Vett vettore = new Vett();
            vettore.Vett_Inizialize(40);
            vettore.Vett_Add(2);
            vettore.Vett_Add(54);
        }
    }
}