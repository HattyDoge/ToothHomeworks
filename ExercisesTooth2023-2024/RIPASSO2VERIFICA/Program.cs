/*
Descrizione dell'applicazione:
Si richiede di implementare un sistema di gestione di una libreria utilizzando il paradigma di 
programmazione ad oggetti in C#. L'applicazione dovrà fare uso di classi, classi derivate, virtual e override,
delegati e Lambda Expressions.

Requisiti dell'applicazione:
Libro:

Creare una classe Libro con i seguenti attributi:
Titolo
Autore
AnnoPubblicazione
Prezzo
Implementare un costruttore che consenta di inizializzare gli attributi.
Implementare un metodo MostraDettagli che stampi a schermo tutte le informazioni del libro.
LibroDigitale:

Creare una classe derivata chiamata LibroDigitale che estenda la classe Libro.
Aggiungere un nuovo attributo Formato (es. PDF, ePub) alla classe LibroDigitale.
Sovrascrivere il metodo MostraDettagli per includere anche il formato del libro digitale.
Libreria:

Creare una classe Libreria che contenga una lista di libri (sia fisici che digitali).
Implementare un metodo AggiungiLibro che consenta di aggiungere un libro alla lista.
Implementare un metodo MostraCatalogo che visualizzi i dettagli di tutti i libri presenti nella lista.
Sconto per libri digitali:

Implementare un delegato chiamato CalcolaScontoDelegate che accetti come parametro un oggetto di tipo Libro e restituisca un valore double rappresentante lo sconto applicato.
Creare una lambda expression che utilizzi il delegato per calcolare uno sconto del 10% per tutti i libri digitali.
*/
namespace RIPASSO2VERIFICA
{
	delegate double CalcolaScontoDelegate(Book koob);
	class Book
	{
		public int AnnoPubblicazione { get; set; }
		public string Titolo { get; set; }
		public string Autore { get; set; }
		public int Prezzo { get; set; }
		public Book(string titolo, string autore, int prezzo, int annoPubblicazione)
		{
			Titolo = titolo;
			Autore = autore;
			Prezzo = prezzo;
			AnnoPubblicazione = annoPubblicazione;
		}
		public Book(Book book) : this(book.Titolo, book.Autore, book.Prezzo, book.AnnoPubblicazione) { }
		public override string ToString() { return $"{Titolo} di {Autore} a {Prezzo},0 Euro nel {AnnoPubblicazione}"; }
	}
	class EBook : Book
	{
		public EBook(string titolo, string autore, int prezzo, int annoPubblicazione) : base(titolo, autore, prezzo, annoPubblicazione)
		{

		}
	}
	class Library
	{
		List<Book> books;
		public Book this[int index] { get { return books[index]; } set { books[index] = value; } }
	}


	internal class Program
	{

		static void Main(string[] args)
		{
			Book book = new Book("Drizzt", "Io", 5, 2020);
			Console.WriteLine("Hello, World!");
			Console.WriteLine(book);
			CalcolaScontoDelegate delegato = (x) => { return x.Prezzo * 0.9; };
			Console.WriteLine(delegato(book));
		}
	}
}
