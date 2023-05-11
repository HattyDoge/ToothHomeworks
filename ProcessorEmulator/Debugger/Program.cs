namespace Debugger
{
	internal class Program
	{
		static int[] op_codes = { 0, 2, 1, 1, 3, 3, 1, 2, 2, 3, 3, 3, 3, 3, 2, 2, 2, 1, 0, 1, 1, 0 };
		static int[] regs = new int[8];
		static int PC = 0;
		static int[] RAM = new int[32768];

		static void Main()
		{
			string file = @"..\..\..\file.txt";
			// caricare da file .txt i valori per la memoria RAM

			using (StreamReader sr = new StreamReader(file))
			{
				int index = 0;
				while (!sr.EndOfStream)
				{
					string linea = sr.ReadLine();
					RAM[index++] = int.Parse(linea);
				}
				sr.Close();
			}
			// loop infinito del processore
			int haltCount = 0;
			while (true)
			{
				// Fase di FETCH
				if (PC == RAM.Length || haltCount > 3) 
					break;
				int instr_code = RAM[PC];

				// ricava il numero di operandi
				int op_count = 0;
				if (instr_code < 21)
				{
					op_count = op_codes[instr_code];
					if (instr_code != 19)
						Console.WriteLine("*");
				}
				if (instr_code != 0)
					haltCount = 0;

					int op1 = (op_count >= 1 ? RAM[PC + 1] : 0);
				int op2 = (op_count >= 2 ? RAM[PC + 2] : 0);
				int op3 = (op_count >= 3 ? RAM[PC + 3] : 0);

				PC++;  // +1 per l'istruzione + il numero operandi

				// Fase di EXECUTE
				switch (instr_code)
				{
					case 0: // halt
						Console.Write("\nhalt");
						haltCount++;
						break;

					case 1:
						break;

					case 2:
						break;

					case 3:
						break;

					case 4:
						break;

					case 5:
						break;

					case 6:
						break;

					case 7:
						break;

					case 8:
						break;

					case 9:
						break;

					case 10:
						break;

					case 11:
						break;

					case 12:
						break;

					case 13:
						break;

					case 14:
						break;

					case 15: // rmem
						break;

					case 16: // wmem
						break;

					case 17: // call
						break;

					case 18: 
						break;

					case 19: // out
						Console.Write("\nout");
						break;

					case 20: // in
						break;

					case 21: // nop
						break;
					default:
						Console.Write($" {instr_code}");
						break;
				}
			}
		}
	}
}