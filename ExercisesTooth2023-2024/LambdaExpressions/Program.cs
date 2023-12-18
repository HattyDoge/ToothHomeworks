/*
Esercizio 1
Acquisire da file un elenco di nomi (il file ha un nome per ogni riga) e memorizzarlo 
in un List<string>.
Le operazioni che seguono vanno implementate due volte:
• una in forma imperativa (cioè come abbiamo sempre fatto)
• una in forma funzionale (cioè con una lamda expression, utilizzando uno dei 
metodi di List<> che accetti un delegato)
Operazioni:
1. contare i nomi che iniziano per una certa lettera data (esempio ‘C’);
2. copiare tutti i nomi in una nuova lista
3. copiare i nomi che rispondono ad “un certo criterio” (cioè un delegato di tipo 
Predicate<string>()) in una nuova lista
*/
//fileDir ..\..\..\parole.txt
namespace LambdaExpressions
{
    internal class Program
    {
        static List<string> GetStringListFromFile(string fileDir)
        {
            var list = new List<string>();
            using (StreamReader sr = new StreamReader(fileDir))
            {
                while (sr.EndOfStream)
                {
                    list.Add(sr.ReadLine());
                }
            }
            return list;
        }
        static int CountNamesWithFirsLetterNoob(char firstLetter, List<string> list)
        {
            int count = 0;
            foreach (string s in list) 
            {
                if (s[0] == firstLetter)
                    count++;
            }
            return count;
        }
        static int CountNamesWithFirstLetterPro(char firstLetter, List<string> list)
        {
            int count = 0;
            list.ForEach(s => { if (s[0] == firstLetter) count++; });
            return count;
        }
        static List<string> CopyAllStringInListNoob(List<string> list)
        {
            List<string> copyList = new List<string>();
            foreach (string s in list)
            {
                copyList.Add(s);
            }
            return copyList;
        }
        static List<string> CopyAllStringInListPro(List<string> list)
        {
            List<string> copyList = new List<string>();
            list.ForEach(s => { copyList.Add(s); });
            return copyList;
        }
        static List<string> CopyNamePredicateNoob(List<string> list, Predicate<string> predicate)
        {
            List<string> copyList = new List<string>();
            foreach (string s in list)
            {
                if (predicate(s))
                    copyList.Add(s);
            }
            return copyList;
        }
        static List<string> CopyNamePredicatePro(List<string> list, Predicate<string> predicate)
        {
            List<string> copyList = new List<string>();
            list.ForEach(s => { if (predicate(s)) copyList.Add(s); });
            return copyList;
        }

    }
}