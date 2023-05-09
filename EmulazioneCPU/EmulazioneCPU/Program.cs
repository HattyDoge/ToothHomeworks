namespace EmulazioneCPU
{
	// numero di operandi per ogni istruzione (deve avere 22 valori)
	static int[] op_codes = { 0, 2, 1, 1, 3, 3, 1, 2, 2, 3, 3, 3, 3, 3, 2, 2, 2, 1, 0, 1, 1, 0 };
	static int[] regs = new int[8];
	static int PC = 0;
	static int[] RAM = new int[32768];
	static List<int> stack = new List<int>();

	static int LeggiOperando(int operand)
	{
		if (0 <= operand && operand <= 32.767)  // è un valore a 15 bit?
			return operand;  // valore immediato

		if (0 <= operand - 32768 && operand - 32768 <= 7)  // è un registro ?
			return regs[operand - 32768];

		// è inammissibile!
		throw new Exception($"Valore {operand} non valido per un operando, all'indirizzo {PC}");
	}

	static void Main()
	{
		string file = "";
		// caricare da file .txt i valori per la memoria RAM
		// --> da fare
		using (StreamReader sr = new StreamReader(file))
			// loop infinito del processore
			while (true)
			{
				// Fase di FETCH
				int instr_code = RAM[PC];
				if (instr_code < 0 || 21 < instr_code)
					throw new Exception($"Istruzione {instr_code} non valida all'indirizzo {PC}");

				// ricava il numero di operandi
				int op_count = op_codes[instr_code];

				int op1 = (op_count >= 1 ? RAM[PC + 1] : 0);
				int op2 = (op_count >= 2 ? RAM[PC + 2] : 0);
				int op3 = (op_count >= 3 ? RAM[PC + 3] : 0);

				PC += 1 + op_count;  // +1 per l'istruzione + il numero operandi

				// Fase di EXECUTE
				switch (instr_code)
				{
					case 0: // halt
						throw new Exception($"Istruzione di halt all'indirizzo {PC}");
						break;

					case 1: // set
							// ..... codice per la set
						break;

					case 2: // push
							// stack.Add( operando );
						break;

					case 3: // pop
							// ..... codice per la pop
						break;

					// .....

					case 6: // jump
						PC = LeggiOperando(op1);
						break;

					case 7: // jt op1, op2
						if (LeggiOperando(op1) != 0)
							PC = LeggiOperando(op2);
						break;

					case 8: // jf op1, op2
						if (LeggiOperando(op1) == 0)
							PC = LeggiOperando(op2);
						break;

					// .....

					case 19: // out op1
						Console.Write((char)LeggiOperando(op1));
						break;

					// .....

					case 21: // nop
						break;
				}
			}
	}
}