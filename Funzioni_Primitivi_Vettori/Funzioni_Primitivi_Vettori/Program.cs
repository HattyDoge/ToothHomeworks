namespace lwzione_21_12___primitive_vettore
{
    internal class Program
    {
        struct Vett
        {
            public int[] v;
            public int count;                  // senza nulla è private
        }
        static void Vett_Inizialize(ref Vett vett, int value)
        {
            vett.v = new int[value];
            vett.count = 0;
        }
        static bool Vett_Add(ref Vett vett, int value)
        {
            if (vett.count == vett.v.Length)  // vettore utilizzato al 100%
                return false;

            vett.v[vett.count++] = value;
            return true;

            /* ^^^ Equivale a:
            
                v[v_count] = value;
                v_count += 1;
            */
        }
        static bool Vett_InsertAt(ref Vett vett, int index, int value)
        {
            // Elimina il valore v[index] compattando i valori restanti
            // NOTA: deve valere che 0 <= index < v_count
            if (!Vett_ShiftRight(ref vett, index))
                return false;

            vett.v[index] = value;
            return true;
        }
        static void Vett_RemoveAt(ref Vett vett, int index)
        {
            // Elimina il valore v[index] compattando i valori restanti
            // NOTA: deve valere che 0 <= index < v_count
            Vett_ShiftLeft(ref vett, index);
        }
        static bool Vett_ShiftLeft(ref Vett vett, int index)
        {
            // Elimina il valore v[index] compattando i valori restanti
            // NOTA: deve valere che 0 <= index < v_count

            if (index < 0 || vett.count <= index)
                return false;

            for (int cnt = 0; cnt < vett.count -index-1; ++cnt)
            {
                int i = index + cnt;
                vett.v[i] = vett.v[i+1];
            }

            --vett.count;
            return true;
        }
        static bool Vett_ShiftRight(ref Vett vett, int index)
        {
            // Elimina il valore v[index] compattando i valori restanti
            // NOTA: deve valere che 0 <= index < v_count

            if (index < 0 || vett.count <= index)
                return false;

            for (int cnt = vett.count - index - 1; cnt >= 0; --cnt)
            {
                int i = index + cnt;
                vett.v[i+1] = vett.v[i];
            }

            ++vett.count;
            return true;
        }
        static int[] Vett_Realloc(int[] v, int newLength)
        {
            // NOTA: deve valere che newLength >= v.Length

            int[] newVect = new int[newLength];

            // Copia elemento per elemento
            for (int i = 0; i < v.Length; i++)
                newVect[i] = v[i];

            return newVect;
        }
        static void Main(string[] args)
        {
            Vett vett = new Vett();
            Vett_Inizialize(ref vett, 1000);
            Vett_Add(ref vett, 2);
            Vett_Add(ref vett, 7);
            Vett_Add(ref vett, 10);
            Vett_Add(ref vett, 11);
            Vett_Add(ref vett, 35);
            Vett_Add(ref vett, 40);
            Vett_Add(ref vett, 8);
            Vett_InsertAt(ref vett, 2, 999);
            Vett_RemoveAt(ref vett, 2);

            Vett vettore = new Vett();
            Vett_Inizialize(ref vettore, 40);
            Vett_Add(ref vettore, 2);
            Vett_Add(ref vettore, 54);
        }
    }
}