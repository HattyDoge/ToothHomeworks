/*
classe abstract "Persona" che includa i dati personali (nome, cognome, data di nascita, età)

abstract stampaPersona();
1 sottoclasse "Studente"

classe frequentata
materia voto più alto - set
materia voto più basso - set
list<Professori> - set
list<double> voti - set
1 sottoclasse "impiegati
    2 sottoclassi:

Professori
list<Classi>(stringhe) - set
Bidelli-terrone (bool)
numero ore di lavoro(int)
 */
abstract class Person
{
    public string name;
    public Person(string name, string surname) 
    {
        this.name = name;
    }

}