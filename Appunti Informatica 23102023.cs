//Appunti Informatica 23/10/2023
internal class Program
{
	class Persona
	{
		protected string cognome, nome;
		protected DateOnly dataNascita;
		public Persona (string cognome, string nome, DateOnly dataNascita)
		{
			this.cognome = cognome;
			this.nome = nome;
			this.dataNascita = dataNascita
		}
	}
	class Studente : Persona // non si può accedere a cognome e nome a meno che non è protected ( privato per tutto il codice esterno allla classe )
	{
		string classe;
		public Studente(string cognome, string nome, DateOnly, string classe)
	}
	class Personale : Persona
	{
		string estremiContratto;
	}
	class ATA : Personale
	{
		string livelloContrattuale;
	}
	class Docente : Personale
	{
		string materia;
	}
	class Dirigente : Docente
	{
		int annoPromozione
	}
	static void Main(string[] args)
	{
		
	}
}
//	PROGRAMMAZIONE A OGGETTI E IL CONCETTO DI EREDITARIETÀ (pag 147)
//	mantenere dati di una scuola con studenti e personale
//	Classe Base / Super Classe
//	Classe Derivate / Sottoclasse
//	