namespace RIPASSO1VERIFICA
{
	internal class Program
	{
		class ClasseEsempio
		{
			string nomeClasse;
			protected List<double> valoriClasse;
			public string NomeClasse { get { return nomeClasse; } set { nomeClasse = value; } }
			public List<double> ValoriClasse { get { return valoriClasse; } }
			public ClasseEsempio(string nomeClasse, List<double> valoriClasse) 
			{
				this.nomeClasse = nomeClasse;
				this.valoriClasse = new List<double>(valoriClasse); 
			}
			public ClasseEsempio(string nomeClasse) : this(nomeClasse, new List<double>()) { }
			public double this[int i]
			{
				get { return valoriClasse[i];}
				set 
				{ 
					if (i <= valoriClasse.Count && i > 0)
						valoriClasse[i] = value;
				}
			}
			public virtual void Riempi()
			{
				for (int i = 0; i < valoriClasse.Count; i++)
				{
					valoriClasse[i] = 1;
				}
			}
		}
		class FiglioClasseEsempio : ClasseEsempio
		{
			string nome;
			public FiglioClasseEsempio(string nomeClasse, List<double> valoriClasse):base(nomeClasse,valoriClasse) 
			{
				
			}
			public override void Riempi()
			{
				for (int i = 0; i < valoriClasse.Count; i++)
				{
					valoriClasse[i] = 3;
				}
			}
		}
	}
}